using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media_Backup;
using System.IO;

namespace Media_Backup
{
    public partial class MainForm : Form
    {
        public DataClass DataClass { get; set; }
        public HelperClass HelperClass { get; set; }

        public MainForm()
        {
            InitializeComponent();
            DataClass = new DataClass();
            HelperClass = new HelperClass();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*Device detection, otherwise project will not run*/
            var deviceCount = HelperClass.GetDevices().Count();
            while (deviceCount == 0)
            {
                var result = MessageBox.Show("No devices detected. Please plug in your device and try again.", "No active devices", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.Retry)
                {
                    deviceCount = HelperClass.GetDevices().Count();
                }
            }

            /*Choosing which device, if there are multiple*/
            ChooseDeviceForm form = new ChooseDeviceForm(this, HelperClass.GetDevices());
            var res = form.ShowDialog();
            if (res == DialogResult.Cancel)
                Environment.Exit(0);
            this.Text = DataClass.MediaDevice.FriendlyName;

            /*Accessing data from the device*/
            DataClass.MediaDevice.Connect();
            var photoDir = DataClass.MediaDevice.GetDirectoryInfo(@$"\Internal storage\DCIM\Camera");
            var files = photoDir.EnumerateFiles("*.*", SearchOption.AllDirectories)
                .OrderBy(s => s.FullName)
                .Where(s => s.FullName.EndsWith(".jpg") || s.FullName.EndsWith(".mp4"));

            String folderPath = Path.Combine(DataClass.DestinationFolder, DataClass.MediaDevice.FriendlyName);
            Directory.CreateDirectory(folderPath);      // if directory already exists, nothing happens

            foreach(var file in files)
            {
                if (!HelperClass.FileExists(folderPath, file.Name)) // file already exists
                {
                    DataClass.NewFiles.Add(file);
                    //idea: local files = newfiles.fullpath
                }
            }
                        
            foreach(var file in DataClass.NewFiles)
            {
                MemoryStream memoryStream = new MemoryStream();
                DataClass.MediaDevice.DownloadFile(file.FullName, memoryStream);
                memoryStream.Position = 0;
                String filePath = Path.Combine(folderPath, file.LastWriteTime.Value.Year.ToString());
                Directory.CreateDirectory(filePath);
                HelperClass.WriteStreamToDisc(Path.Combine(filePath, file.Name), memoryStream);
            }

            /*Image preview*/
            if (DataClass.NewFiles.Count == 0)
            {
                lbl_count.Text = @$"There are {DataClass.NewFiles.Count} new files detected.";
            }
            else
            {
                if (DataClass.NewFiles.Count == 1)
                {
                    lbl_count.Text = @$"There is {DataClass.NewFiles.Count} new file detected.";
                }
                else
                {
                    lbl_count.Text = @$"There are {DataClass.NewFiles.Count} new files detected.";
                }
                DataClass.ImageIndex = 0;
                HelperClass.ImagePreview(this);                
            }

            DataClass.MediaDevice.Disconnect();
        }
    }
}
