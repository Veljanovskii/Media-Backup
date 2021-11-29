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
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace Media_Backup
{
    public partial class MainForm : Form
    {
        public DataClass proxy { get; set; }

        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public VideoView videoView;

        public MainForm()
        {
            InitializeComponent();
            proxy = new DataClass();

            /*VLC Media player*/
            Core.Initialize();
            _libVLC = new LibVLC();
            videoView = new VideoView();
            _mp = new MediaPlayer(_libVLC);
            videoView.MediaPlayer = _mp;
            grb_preview.Controls.Add(videoView);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            /*Choosing which device, if there are multiple*/
            ChooseDeviceForm form = new ChooseDeviceForm(this, proxy.GetDevices());
            var res = form.ShowDialog();
            if (res == DialogResult.Cancel)
                Environment.Exit(0);

            this.Text = proxy.MediaDevice.FriendlyName;

            /*Trackbar settings*/
            trb_time.Minimum = 2;
            trb_time.Maximum = 120;
            trb_time.TickFrequency = 10;

            /*Accessing data from the device*/
            proxy.TransferMedia();

            /*Media preview*/            
            proxy.MediaPreview(this);

            proxy.FillMediaList(this);
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (proxy.MediaIndex < proxy.NewFiles.Count - 1)
            {
                proxy.MediaIndex++;
                proxy.MediaPreview(this);
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (proxy.MediaIndex > 0)
            {
                proxy.MediaIndex--;
                proxy.MediaPreview(this);
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            proxy.MediaIndex = proxy.NewFiles.Count - 1;
            proxy.MediaPreview(this);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            proxy.MediaIndex = 0;
            proxy.MediaPreview(this);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            /*VLC Media Controls*/
            switch (e.KeyCode)
            {                
                case Keys.Add:
                    if (proxy.IsPlaying == true)
                    {
                        _mp.Pause();
                        proxy.IsPlaying = false;
                    }
                    else
                    {
                        _mp.Play();
                        proxy.IsPlaying = true;
                    }
                    break;
            }
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            /*Prevents focus change*/
            var keys = new[] { Keys.Add };
            if (keys.Contains(e.KeyData))
                e.IsInputKey = true;
        }

        private void trb_time_Scroll(object sender, EventArgs e)
        {
            lbl_trackbar.Text = trb_time.Value + " minutes";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoView.Dispose();
            _mp.Dispose();
            _libVLC.Dispose();
        }
    }
}
