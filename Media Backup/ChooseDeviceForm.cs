using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            for (int i = 0; i < Devices.Count(); i++)
            {
                this.cmb_devices.Items.Add(Devices.ElementAt(i).FriendlyName);
            }
            lbl_folder_path.MaximumSize = new Size(320, 0);
            lbl_folder_path.AutoSize = true;
            lbl_folder_path.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (cmb_devices.SelectedIndex != -1)
            {
                Parent_Form.DataClass.MediaDevice = Devices.ElementAt(cmb_devices.SelectedIndex);
                Parent_Form.DataClass.DestinationFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Parent_Form.DataClass.DestinationFolder = fbd.SelectedPath;
                lbl_folder_path.Text = fbd.SelectedPath;
            }
        }

        private void ChooseDeviceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != 0) 
                Environment.Exit(0);
        }
    }
}
