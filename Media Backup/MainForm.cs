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
        public HelperClass Proxy { get; set; }

        public MainForm()
        {
            InitializeComponent();
            DataClass = new DataClass();
            Proxy = new HelperClass();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*Device detection, otherwise project will not run*/
            var deviceCount = Proxy.GetDevices().Count();
            while (deviceCount == 0)
            {
                var result = MessageBox.Show("No devices detected. Please plug in your device and try again.", "No active devices", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.Retry)
                {
                    deviceCount = Proxy.GetDevices().Count();
                }
            }

            /*Choosing which device, if there are multiple*/
            ChooseDeviceForm form = new ChooseDeviceForm(this, Proxy.GetDevices());
            var res = form.ShowDialog();
            if (res == DialogResult.Cancel)
                Environment.Exit(0);
            this.Text = DataClass.MediaDevice.FriendlyName;

            /*Accessing data from the device*/
            DataClass.MediaDevice.Connect();
            var photoDir = DataClass.MediaDevice.GetDirectoryInfo(@$"\Internal storage\DCIM\Camera");
            var files = photoDir.EnumerateFiles("*.*", SearchOption.AllDirectories);

            foreach(var file in files)
            {
                //sort 
                MemoryStream memoryStream = new MemoryStream();
                DataClass.MediaDevice.DownloadFile(file.FullName, memoryStream);
                memoryStream.Position = 0;
            }

            DataClass.MediaDevice.Disconnect();
        }
    }
}
