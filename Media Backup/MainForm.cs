﻿using System;
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
using Shell32;

namespace Media_Backup
{
    public partial class MainForm : Form
    {
        public DataClass proxy { get; set; }

        public MainForm()
        {
            InitializeComponent();
            proxy = new DataClass();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            /*Choosing which device, if there are multiple*/
            ChooseDeviceForm form = new ChooseDeviceForm(this, proxy.GetDevices());
            var res = form.ShowDialog();
            if (res == DialogResult.Cancel)
                Environment.Exit(0);
            this.Text = proxy.MediaDevice.FriendlyName;

            /*Accessing data from the device*/
            proxy.TransferMedia();

            /*Media preview*/            
            proxy.MediaPreview(this);

            //DataClass.MediaDevice.Disconnect();
        }

        private void btn_source_Click(object sender, EventArgs e)
        {
            Shell shell = new Shell();
            Folder folder = shell.BrowseForFolder(0, "Choose source folder", 0, 0);
            if (folder != null)
            {
                FolderItem fi = (folder as Folder3).Self;
                var path = fi.Path;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.MediaDevice.Disconnect();
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
    }
}
