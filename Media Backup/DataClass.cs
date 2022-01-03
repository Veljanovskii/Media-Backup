using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
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
        public int MinutesRange { get; set; }
        public List<int> TagIndexes { get; set; }
        public List<string> MediaFormats { get; set; }
        public Bitmap image { get; set; }
        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public VideoView videoView;

        public DataClass()
        {
            MediaIndex = 0;
            MinutesRange = 2;
            TagIndexes = new List<int>();
            IsPlaying = false;

            MediaFormats = new List<string>();
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
            Cursor.Current = Cursors.WaitCursor;
            MediaDirectoryInfo photoDir = null;
            NewFiles = new List<MediaDevices.MediaFileInfo>();
            try
            {
                MediaDevice.Connect();
                photoDir = MediaDevice.GetDirectoryInfo(SourceFolder);
            }
            catch(Exception e)
            {
                var result = MessageBox.Show(e.Message, "Unable to connect to the device", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cursor.Current = Cursors.Default;
                if (result == DialogResult.OK)
                    return;
            }

            var files = photoDir.EnumerateFiles("*.*", SearchOption.AllDirectories)
                .OrderBy(s => s.FullName)
                .Where(s => MediaFormats.Contains(s.FullName.Substring(s.FullName.Length - 3, 3))
                || MediaFormats.Contains(s.FullName.Substring(s.FullName.Length - 4, 4)));

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
                String filePath = Path.Combine(folderPath, ExtractYear(file));
                                
                Directory.CreateDirectory(filePath);
                WriteStreamToDisc(Path.Combine(filePath, file.Name), memoryStream);

                BarForm.SetProgress(progress++);
                BarForm.lbl_progress.Text = $@"Transferring... {progress}/{NewFiles.Count} ({Math.Round((double)progress / NewFiles.Count * 100)}%)";
            }
            BarForm.Close();
            MediaDevice.Disconnect();
            Cursor.Current = Cursors.Default;
        }

        private string ExtractYear(MediaFileInfo file)
        {
            if (UseFileName == true)
                return file.Name.Substring(4, 4);       // starting index 4, length 4
            else
                return file.LastWriteTime.Value.Year.ToString();
        }

        private string ExtractDateTime(MediaFileInfo file)
        {
            if (UseFileName == true)
            {
                var name = file.Name;
                string result = name.Substring(10, 2) + "." + name.Substring(8, 2) + "." + name.Substring(4, 4);
                result += " " + name.Substring(13, 2) + ":" + name.Substring(15, 2) + ":" + name.Substring(17, 2);

                return result;
            }
            else
            {
                return file.LastWriteTime.Value.ToString("dd.MM.yyyy HH:mm:ss");
            }
        }

        public void MediaPreview(MainForm form)
        {
            if (image != null) 
                image.Dispose();
            form.pcb_image.Visible = false;

            if (videoView != null)
            {
                videoView.Visible = false;
            }

            /*Shows new media count*/
            LabelMessage(form);
            form.lbl_datetime.Visible = false;
            form.lbl_counter.Visible = false;
            form.lbl_media.Visible = false;

            if (NewFiles.Count == 0)
                return;

            string path;
            form.lbl_counter.Visible = true;
            form.lbl_counter.Text = (MediaIndex + 1) + "/" + NewFiles.Count;

            path = Path.Combine(DestinationFolder, MediaDevice.FriendlyName, ExtractYear(NewFiles.ElementAt(MediaIndex)), NewFiles.ElementAt(MediaIndex).Name);
            
            form.lbl_datetime.Visible = true;
            form.lbl_datetime.Text = ExtractDateTime(NewFiles.ElementAt(MediaIndex));
            
            form.lbl_media.Visible = true;
            form.lbl_media.Text = NewFiles.ElementAt(MediaIndex).Name;
            IsPlaying = false;

            form.clb_media.SelectedIndex = MediaIndex;
            form.clb_media.Focus();

            /*Image preview*/
            if (NewFiles.ElementAt(MediaIndex).Name.EndsWith("jpg"))
            {
                /*Retrieve image*/
                image = new Bitmap(path);
                form.pcb_image.Image = image;
                form.pcb_image.Visible = true;

                /*Show image*/
                if (image.Width == 4160)
                {
                    form.pcb_image.Size = new Size(520, 390);
                    form.pcb_image.Location = new Point(6, 66);

                }
                else if (image.Width == 3120)
                {
                    form.pcb_image.Size = new Size(305, 390);
                    form.pcb_image.Location = new Point(113, 66);
                }
            }
            else if (NewFiles.ElementAt(MediaIndex).Name.EndsWith("mp4"))
            {
                /*VLC settings*/

                _libVLC = new LibVLC();
                videoView = new VideoView();
                _mp = new MediaPlayer(_libVLC);
                videoView.MediaPlayer = _mp;
                form.grb_preview.Controls.Add(videoView);

                videoView.Visible = true;
                videoView.Location = new Point(6, 66);
                videoView.Size = new Size(520, 390);
                _mp.Play(new Media(_libVLC, path));
                _mp.Volume = 0;
                IsPlaying = true;
            }

            FindInRange(form);
        }

        internal void DeleteCurrentMedia(MainForm form)
        {
            if (image != null)
                image.Dispose();

            if (videoView != null)
            {
                form.grb_preview.Controls.Remove(videoView);
                _libVLC.Dispose();
                videoView.Dispose();
                videoView = null;
                _mp.Dispose();
            }

            var path = Path.Combine(DestinationFolder, MediaDevice.FriendlyName, ExtractYear(NewFiles[MediaIndex]), NewFiles[MediaIndex].Name);
            File.Delete(path);
            NewFiles.RemoveAt(MediaIndex);
            form.clb_media.Items.RemoveAt(MediaIndex);

            if (MediaIndex > 0)
                MediaIndex--;

            MediaPreview(form);
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

        internal void FillMediaList(MainForm form)
        {
            form.clb_media.Items.Clear();
            foreach (var item in NewFiles)
                form.clb_media.Items.Add(item.Name);
        }

        internal void FindInRange(MainForm form)
        {
            TagIndexes.Clear();

            for (int i = 0; i < NewFiles.Count; i++)
            {
                if (CheckRange(ExtractDateTime(NewFiles[MediaIndex]), ExtractDateTime(NewFiles[i])) == true)
                {
                    TagIndexes.Add(i);
                }
            }
            
            /*Uncheck all*/
            for (int i = 0; i < NewFiles.Count; i++)
            {
                form.clb_media.SetItemChecked(i, false);
            }

            /*Check selected*/
            for (int i = 0; i < TagIndexes.Count; i++)
            {
                form.clb_media.SetItemChecked(TagIndexes[i], true);
            }

            form.lbl_selected.Visible = true;
            form.lbl_selected.Text = TagIndexes.Count + " media selected";
        }

        private bool CheckRange(string v1, string v2)
        {
            DateTime value1 = DateTime.ParseExact(v1, "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            DateTime value2 = DateTime.ParseExact(v2, "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan span = value1 - value2;

            return Math.Abs(span.TotalMinutes) <= MinutesRange;
        }

        internal void MoveMedia(MainForm form)
        {
            if (image != null) 
                image.Dispose();

            if (videoView != null)
            {
                form.grb_preview.Controls.Remove(videoView);
                _libVLC.Dispose();
                videoView.Dispose();
                videoView = null;
                _mp.Dispose();
            }

            String path = Path.Combine(DestinationFolder, MediaDevice.FriendlyName);

            TagIndexes.Sort();
            
            for (int i = TagIndexes.Count - 1; i >= 0; i--) 
            {
                var pathYear = Path.Combine(path, ExtractYear(NewFiles[TagIndexes[i]]));
                var sourcePath = Path.Combine(pathYear, NewFiles[TagIndexes[i]].Name);
                var destFolder = Path.Combine(pathYear, form.txt_tag.Text);
                                
                Directory.CreateDirectory(destFolder);
                var destPath = Path.Combine(destFolder, NewFiles[TagIndexes[i]].Name);

                File.Copy(sourcePath, destPath, true);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(sourcePath);

                NewFiles.RemoveAt(TagIndexes[i]);
                form.clb_media.Items.RemoveAt(TagIndexes[i]);
            }

            TagIndexes.Clear();
            MediaIndex = 0;
            MediaPreview(form);            
        }
    }
}
