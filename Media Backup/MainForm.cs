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

namespace Media_Backup
{
    public partial class MainForm : Form
    {
        private String deviceName;
        public MainForm()
        {
            InitializeComponent();
        }

        public void SetDeviceName(String deviceName)
        {
            this.deviceName = deviceName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var proxy = new HelperClass();

            /*Device detection, otherwise project will not run*/
            var devices = proxy.GetDevices();
            while (devices.Count() == 0)
            {
                var result = MessageBox.Show("No devices detected. Please plug in your device and try again.", "No active devices", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.Retry)
                {
                    devices = proxy.GetDevices();
                }
            }

            /*Choosing which device, if there are multiple*/
            ChooseDeviceForm form = new ChooseDeviceForm();
            for (int i = 0; i < devices.Count(); i++) 
            {
                form.cmb_devices.Items.Add(devices.ElementAt(i).FriendlyName);
            }
            form.ShowDialog();

            this.deviceName = form.cmb_devices.SelectedItem.ToString();
            this.Text = this.deviceName;

        }
    }
}
