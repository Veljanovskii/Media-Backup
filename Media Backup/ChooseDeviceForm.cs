using MediaDevices;
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
        public IEnumerable<MediaDevice> Devices;

        public ChooseDeviceForm(MainForm parent, IEnumerable<MediaDevices.MediaDevice> devices)
        {
            InitializeComponent();
            this.Parent_Form = parent;
            this.Devices = devices;
        }

        private void ChooseDeviceForm_Load(object sender, EventArgs e)
        {
            txt_source_path.Text = @"\Internal storage\DCIM\Camera";
            txt_dest_path.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (Devices.Count() == 0) 
            {
                txt_source_path.Enabled = false;
                txt_dest_path.Enabled = false;
                chb_metafiles.Enabled = false;
                btn_ok.Enabled = false;
                btn_source.Enabled = false;
                btn_dest.Enabled = false;

                chb_avi.Enabled = false;
                chb_flv.Enabled = false;
                chb_gif.Enabled = false;
                chb_jpeg.Enabled = false;
                chb_jpg.Enabled = false;
                chb_mov.Enabled = false;
                chb_mp4.Enabled = false;
                chb_png.Enabled = false;
                chb_svg.Enabled = false;
                chb_wmv.Enabled = false;

                return;
            }

            /*Setting up Combobox*/
            for (int i = 0; i < Devices.Count(); i++)
            {
                this.cmb_devices.Items.Add(Devices.ElementAt(i).FriendlyName);
            }

            cmb_devices.SelectedIndex = 0;                      
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (Parent_Form.proxy.GetDevices().Count() == 0)
                return;
            else
            {
                this.Devices = Parent_Form.proxy.GetDevices();

                txt_source_path.Enabled = true;
                txt_dest_path.Enabled = true;
                chb_metafiles.Enabled = true;
                btn_ok.Enabled = true;
                btn_source.Enabled = true;
                btn_dest.Enabled = true;

                chb_avi.Enabled = true;
                chb_flv.Enabled = true;
                chb_gif.Enabled = true;
                chb_jpeg.Enabled = true;
                chb_jpg.Enabled = true;
                chb_mov.Enabled = true;
                chb_mp4.Enabled = true;
                chb_png.Enabled = true;
                chb_svg.Enabled = true;
                chb_wmv.Enabled = true;

                for (int i = 0; i < Devices.Count(); i++)
                {
                    this.cmb_devices.Items.Add(Devices.ElementAt(i).FriendlyName);
                }

                cmb_devices.SelectedIndex = 0;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (cmb_devices.SelectedIndex != -1)
            {
                Parent_Form.proxy.MediaDevice = Devices.ElementAt(cmb_devices.SelectedIndex);
                Parent_Form.proxy.SourceFolder = txt_source_path.Text;
                Parent_Form.proxy.DestinationFolder = txt_dest_path.Text;   

                if (Parent_Form.proxy.SourceFolder != @"\Internal storage\DCIM\Camera")
                {
                    if (Parent_Form.proxy.SourceFolder.StartsWith("M:"))
                    {
                        Parent_Form.proxy.SourceFolder = $@"\Internal storage" + Parent_Form.proxy.SourceFolder.Split(":")[1];
                    }
                    else
                    {
                        var deviceName = Parent_Form.proxy.MediaDevice.FriendlyName;
                        Parent_Form.proxy.SourceFolder = Parent_Form.proxy.SourceFolder.Split(deviceName)[1];
                    }
                }

                if (chb_metafiles.Checked)
                {
                    Parent_Form.proxy.UseFileName = true;
                }
                else
                {
                    Parent_Form.proxy.UseFileName = false;
                }

                /*Media formats*/
                this.Parent_Form.proxy.MediaFormats.Clear();
                this.Parent_Form.proxy.MediaFormats.Add("jpg");
                this.Parent_Form.proxy.MediaFormats.Add("mp4");

                if (chb_avi.Checked) 
                    this.Parent_Form.proxy.MediaFormats.Add("avi");
                if (chb_flv.Checked) 
                    this.Parent_Form.proxy.MediaFormats.Add("flv");
                if (chb_gif.Checked) 
                    this.Parent_Form.proxy.MediaFormats.Add("gif");
                if (chb_jpeg.Checked) 
                    this.Parent_Form.proxy.MediaFormats.Add("jpeg");
                if (chb_mov.Checked) 
                    this.Parent_Form.proxy.MediaFormats.Add("mov");
                if (chb_png.Checked) 
                    this.Parent_Form.proxy.MediaFormats.Add("png");
                if (chb_svg.Checked) 
                    this.Parent_Form.proxy.MediaFormats.Add("svg");
                if (chb_wmv.Checked) 
                    this.Parent_Form.proxy.MediaFormats.Add("wmv");

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_source_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Parent_Form.proxy.SourceFolder = fbd.SelectedPath;
                txt_source_path.Text = fbd.SelectedPath;
            }
        }

        private void btn_dest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Parent_Form.proxy.DestinationFolder = fbd.SelectedPath;
                txt_dest_path.Text = fbd.SelectedPath;
            }
        }
    }
}
