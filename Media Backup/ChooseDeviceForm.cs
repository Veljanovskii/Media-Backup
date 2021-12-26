using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Media_Backup
{
    public partial class ChooseDeviceForm : Form
    {
        public MainForm Parent_Form;
        public IEnumerable<MediaDevices.MediaDevice> Devices; 

        public ChooseDeviceForm(MainForm parent, IEnumerable<MediaDevices.MediaDevice> devices)
        {
            InitializeComponent();
            this.Parent_Form = parent;
            this.Devices = devices;
        }

        private void ChooseDeviceForm_Load(object sender, EventArgs e)
        {
            /*Device detection, otherwise application will not run*/
            while (Devices.Count() == 0)
            {
                var result = MessageBox.Show("No devices detected. Please plug in your device and try again.", "No active devices", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.Retry)
                {
                    Devices = Parent_Form.proxy.GetDevices();
                }
            }

            /*Setting up Combobox*/
            for (int i = 0; i < Devices.Count(); i++)
            {
                this.cmb_devices.Items.Add(Devices.ElementAt(i).FriendlyName);
            }

            cmb_devices.SelectedIndex = 0;

            lbl_source_path.MaximumSize = new Size(320, 0);
            lbl_source_path.AutoSize = true;
            lbl_source_path.Text = @"\Internal storage\DCIM\Camera";

            lbl_dest_path.MaximumSize = new Size(320, 0);
            lbl_dest_path.AutoSize = true;
            lbl_dest_path.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (cmb_devices.SelectedIndex != -1)
            {
                Parent_Form.proxy.MediaDevice = Devices.ElementAt(cmb_devices.SelectedIndex);

                if (Parent_Form.proxy.SourceFolder == null)
                {
                    Parent_Form.proxy.SourceFolder = @"\Internal storage\DCIM\Camera";
                }
                else
                {
                    String path = $@"\Internal storage" + Parent_Form.proxy.SourceFolder.Split(":")[1];
                    Parent_Form.proxy.SourceFolder = path;
                }

                if (Parent_Form.proxy.DestinationFolder == null)
                {
                    Parent_Form.proxy.DestinationFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }

                if (chb_metafiles.Checked)
                {
                    Parent_Form.proxy.UseFileName = true;
                }
                else
                {
                    Parent_Form.proxy.UseFileName = false;
                }

                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_source_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Parent_Form.proxy.SourceFolder = fbd.SelectedPath;
                lbl_source_path.Text = fbd.SelectedPath;
            }
        }

        private void btn_dest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Parent_Form.proxy.DestinationFolder = fbd.SelectedPath;
                lbl_dest_path.Text = fbd.SelectedPath;
            }
        }

        private void ChooseDeviceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != 0) 
                Environment.Exit(0);
        }
    }
}
