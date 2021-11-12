﻿using MediaDevices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Media_Backup
{
    public class DataClass
    {
        public MediaDevices.MediaDevice MediaDevice { get; set; }
        public String DestinationFolder { get; set; }
        public bool Metafiles { get; set; }
        public IList<MediaDevices.MediaFileInfo> NewFiles { get; set; }
        public int ImageIndex { get; set; }


        public DataClass()
        {
            NewFiles = new List<MediaDevices.MediaFileInfo>();
        }

        public IEnumerable<MediaDevice> GetDevices()
        {
            return MediaDevice.GetDevices();
        }

        public bool FileExists(String rootPath, String fileName)
        {
            if (File.Exists(Path.Combine(rootPath, fileName)))
                return true;

            foreach (string subDir in Directory.GetDirectories(rootPath))
            {
                if (FileExists(subDir, fileName))
                    return true;
            }

            return false;
        }

        public void WriteStreamToDisc(String filePath, MemoryStream memoryStream)
        {
            using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                byte[] bytes = new byte[memoryStream.Length];
                memoryStream.Read(bytes, 0, (int)memoryStream.Length);
                file.Write(bytes, 0, bytes.Length);
                memoryStream.Close();
            }
        }

        public void TransferMedia()
        {
            /*Accessing data from the device*/
            MediaDevice.Connect();
            var photoDir = MediaDevice.GetDirectoryInfo(@$"\Internal storage\DCIM\Camera");
            var files = photoDir.EnumerateFiles("*.*", SearchOption.AllDirectories)
                .OrderBy(s => s.FullName)
                .Where(s => s.FullName.EndsWith(".jpg") || s.FullName.EndsWith(".mp4"));

            String folderPath = Path.Combine(DestinationFolder, MediaDevice.FriendlyName);
            Directory.CreateDirectory(folderPath);      // if directory already exists, nothing happens

            foreach (var file in files)
            {
                if (!FileExists(folderPath, file.Name)) // file already exists
                {
                    NewFiles.Add(file);
                    //idea: local files = newfiles.fullpath
                }
            }

            foreach (var file in NewFiles)
            {
                MemoryStream memoryStream = new MemoryStream();
                MediaDevice.DownloadFile(file.FullName, memoryStream);
                memoryStream.Position = 0;
                String filePath = Path.Combine(folderPath, file.LastWriteTime.Value.Year.ToString());
                Directory.CreateDirectory(filePath);
                WriteStreamToDisc(Path.Combine(filePath, file.Name), memoryStream);
            }

            /*Progress bar*/
            ProgressBarForm progressBarForm = new ProgressBarForm();
            //progressBarForm.ShowDialog();
            //progressBarForm.Close();
        }

        public void ImagePreview(MainForm form)
        {
            //var image = new Bitmap(@$"This PC\HUAWEI P smart 2019\Internal storage\DCIM\Camera\IMG_20200220_140911.jpg");
            var image = new Bitmap(Path.Combine(form.proxy.DestinationFolder, form.proxy.MediaDevice.FriendlyName, form.proxy.NewFiles.ElementAt(form.proxy.ImageIndex).LastWriteTime.Value.Year.ToString(), form.proxy.NewFiles.ElementAt(form.proxy.ImageIndex).Name));
            //grb_preview.Width = image.Width / 8;
            form.pcb_image.Width = image.Width / 8;
            //grb_preview.Height = image.Height / 8 + 100;
            form.pcb_image.Height = image.Height / 8;
            form.pcb_image.Image = image;
            //maybe make form resizable
        }
    }
}
