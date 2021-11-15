using MediaDevices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Media_Backup
{
    public class DataClass
    {
        public MediaDevices.MediaDevice MediaDevice { get; set; }
        public String DestinationFolder { get; set; }
        public bool Metadata { get; set; }
        public IList<MediaDevices.MediaFileInfo> NewFiles { get; set; }
        public int MediaIndex { get; set; }


        public DataClass()
        {
            NewFiles = new List<MediaDevices.MediaFileInfo>();
            MediaIndex = 0;
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
                if (Metadata == true)
                {
                    filePath = Path.Combine(folderPath, file.LastWriteTime.Value.Year.ToString());
                }
                else
                {
                    filePath = Path.Combine(folderPath, ExtractYear(file));
                }
                Directory.CreateDirectory(filePath);
                WriteStreamToDisc(Path.Combine(filePath, file.Name), memoryStream);

                BarForm.SetProgress(progress++);
                BarForm.lbl_progress.Text = @$"Transferring...{progress}/{NewFiles.Count} ({Math.Round((double)progress / NewFiles.Count * 100)}%)";
            }
            BarForm.Close();
        }

        private string ExtractYear(MediaFileInfo file)
        {
            return file.Name.Substring(4, 4);       // starting index 4, length 4
        }

        public void MediaPreview(MainForm form)
        {
            /*Image preview*/
            if (NewFiles.ElementAt(MediaIndex).Name.EndsWith("jpg"))
            {
                /*Retrieve image*/
                Bitmap image;
                if (Metadata == true) 
                   image = new Bitmap(Path.Combine(DestinationFolder, MediaDevice.FriendlyName, NewFiles.ElementAt(MediaIndex).LastWriteTime.Value.Year.ToString(), NewFiles.ElementAt(MediaIndex).Name));
                else
                   image = new Bitmap(Path.Combine(DestinationFolder, MediaDevice.FriendlyName, ExtractYear(NewFiles.ElementAt(MediaIndex)), NewFiles.ElementAt(MediaIndex).Name));

                form.grb_preview.Location = new Point(12, 12);
                form.grb_preview.Visible = true;
                form.pcb_image.Location = new Point(6, 36);
                form.pcb_image.Visible = true;
                
                if (image.Width == 4160)
                {
                    form.grb_preview.Size = new Size(532, 518);
                    form.pcb_image.Size = new Size(520, 390);

                    /*Buttons settings*/
                    form.btn_start.Location = new Point(172, 450);
                    form.btn_left.Location = new Point(215, 450);
                    form.btn_right.Location = new Point(271, 450);
                    form.btn_end.Location = new Point(314, 450);

                    form.pcb_image.Image = image;

                }
                else if (image.Width == 3120)
                {
                    form.grb_preview.Size = new Size(402, 648);
                    form.pcb_image.Size = new Size(390, 520);

                    /*Buttons settings*/
                    form.btn_start.Location = new Point(112, 600);
                    form.btn_left.Location = new Point(165, 600);
                    form.btn_right.Location = new Point(221, 600);
                    form.btn_end.Location = new Point(264, 600);

                    form.pcb_image.Image = image;
                }

            }
            else if(NewFiles.ElementAt(MediaIndex).Name.EndsWith("mp4"))
            {

            }

            

            if (NewFiles.Count == 0)
            {
                form.lbl_count.Text = @$"There are 0 new files detected.";
            }
            else
            {
                if (NewFiles.Count == 1)
                {
                    form.lbl_count.Text = @$"There is 1 new file detected.";
                }
                else
                {
                    form.lbl_count.Text = @$"There are {NewFiles.Count} new files detected.";
                }
            }

            //var image = new Bitmap(@$"This PC\HUAWEI P smart 2019\Internal storage\DCIM\Camera\IMG_20200220_140911.jpg");
            
        }
    }
}
