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
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Parent_Form.DataClass.MediaDevice = Devices.ElementAt(cmb_devices.SelectedIndex);
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChooseDeviceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != 0) 
                Application.Exit();
        }
    }
}
