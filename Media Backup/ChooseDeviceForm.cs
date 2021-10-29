using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Media_Backup
{
    public partial class ChooseDeviceForm : Form
    {
        public ChooseDeviceForm()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //var name = cmb_devices.SelectedItem.ToString();
            //MainForm form = new MainForm();
            //form.SetDeviceName(name);
            //form.Show();
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChooseDeviceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var el = e.CloseReason;
            if (e.CloseReason != 0) 
                Application.Exit();
        }
    }
}
