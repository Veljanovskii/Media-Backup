using LibVLCSharp.Shared;
using MediaDevices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace Media_Backup
{
    public class DataClass
    {
        public MediaDevices.MediaDevice MediaDevice { get; set; }
        public String SourceFolder { get; set; }
        public String DestinationFolder { get; set; }
        public bool UseFileName { get; set; }
        public IList<MediaDevices.MediaFileInfo> NewFiles { get; set; }
        public int MediaIndex { get; set; }
        public bool IsPlaying { get; set; }


        public DataClass()
        {
            NewFiles = new List<MediaDevices.MediaFileInfo>();
            MediaIndex = 0;
            IsPlaying = false;
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
            var photoDir = MediaDevice.GetDirectoryInfo(SourceFolder);
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
                }
            }

            /*Progress bar*/
            ProgressBarForm BarForm = new ProgressBarForm();
            BarForm.Text = "Transferring...";
            BarForm.pgb_bar.Minimum = 0;
            BarForm.pgb_bar.Maximum = NewFiles.Count;
            BarForm.pgb_bar.Style = ProgressBarStyle.Blocks;
            BarForm.Show();
            int progress = 1;

            foreach (var file in NewFiles)
            {
                MemoryStream memoryStream = new MemoryStream();
                MediaDevice.DownloadFile(file.FullName, memoryStream);
                memoryStream.Position = 0;
                String filePath;
                if (UseFileName == true)
                {
                    filePath = Path.Combine(folderPath, ExtractYear(file));
                }
                else
                {
                    filePath = Path.Combine(folderPath, file.LastWriteTime.Value.Year.ToString());
                }
                Directory.CreateDirectory(filePath);
                WriteStreamToDisc(Path.Combine(filePath, file.Name), memoryStream);

                BarForm.SetProgress(progress++);
                BarForm.lbl_progress.Text = $@"Transferring...{progress}/{NewFiles.Count} ({Math.Round((double)progress / NewFiles.Count * 100)}%)";
            }
            BarForm.Close();
            MediaDevice.Disconnect();
        }

        private string ExtractYear(MediaFileInfo file)
        {
            return file.Name.Substring(4, 4);       // starting index 4, length 4
        }

        public void MediaPreview(MainForm form)
        {
            /*Buttons settings*/
            form.btn_start.Location = new Point(180, 550);
            form.btn_left.Location = new Point(220, 550);
            form.btn_right.Location = new Point(280, 550);
            form.btn_end.Location = new Point(320, 550);

            /*Groupbox*/
            form.grb_preview.Location = new Point(12, 48);
            form.grb_preview.Visible = true;
            form.grb_preview.Size = new Size(532, 490);

            form.videoView.Visible = false;
            form.pcb_image.Visible = false;

            LabelMessage(form);

            if (NewFiles.Count == 0)
                return;

            string path;
            if (UseFileName == true)
            {
                path = Path.Combine(DestinationFolder, MediaDevice.FriendlyName, ExtractYear(NewFiles.ElementAt(MediaIndex)), NewFiles.ElementAt(MediaIndex).Name);
            }
            else
            {
                path = Path.Combine(DestinationFolder, MediaDevice.FriendlyName, NewFiles.ElementAt(MediaIndex).LastWriteTime.Value.Year.ToString(), NewFiles.ElementAt(MediaIndex).Name);
            }
            form.lbl_media.Text = NewFiles.ElementAt(MediaIndex).Name;
            form._mp.Pause();
            IsPlaying = false;

            /*Image preview*/
            if (NewFiles.ElementAt(MediaIndex).Name.EndsWith("jpg"))
            {
                /*Retrieve image*/
                Bitmap image = new Bitmap(path);                
                form.pcb_image.Visible = true;
                form.lbl_times.Visible = false;
                
                /*Show image*/
                if (image.Width == 4160)
                {
                    form.pcb_image.Size = new Size(520, 390);
                    form.pcb_image.Location = new Point(6, 36);
                    form.pcb_image.Image = image;

                }
                else if (image.Width == 3120)
                {
                    form.pcb_image.Size = new Size(305, 390);
                    form.pcb_image.Location = new Point(113, 36);
                    form.pcb_image.Image = image;
                }
            }
            else if(NewFiles.ElementAt(MediaIndex).Name.EndsWith("mp4"))
            {
                /*VLC settings*/
                form.videoView.Visible = true;
                form.videoView.Location = new Point(6, 36);
                form.videoView.Size = new Size(520, 390);
                form._mp.Play(new Media(form._libVLC, path));
                IsPlaying = true;
                form.lbl_times.Visible = false;
                form.lbl_times.Text = form._mp.Time + "/" + form._mp.Length;
            }            
        }

        private void LabelMessage(MainForm form)
        {
            if (NewFiles.Count == 0)
            {
                form.lbl_count.Text = $@"There are 0 new files detected.";
            }
            else
            {
                if (NewFiles.Count == 1)
                {
                    form.lbl_count.Text = $@"There is 1 new file detected.";
                }
                else
                {
                    form.lbl_count.Text = $@"There are {NewFiles.Count} new files detected.";
                }
            }
        }
    }
}
