using MediaDevices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;

namespace Media_Backup
{
    public class HelperClass
    {
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

        public void ImagePreview(MainForm form)
        {
            var image = new Bitmap(Path.Combine(form.DataClass.DestinationFolder, form.DataClass.MediaDevice.FriendlyName, form.DataClass.NewFiles.ElementAt(form.DataClass.ImageIndex).LastWriteTime.Value.Year.ToString(), form.DataClass.NewFiles.ElementAt(form.DataClass.ImageIndex).Name));
            //grb_preview.Width = image.Width / 8;
            form.pcb_image.Width = image.Width / 8;
            //grb_preview.Height = image.Height / 8 + 100;
            form.pcb_image.Height = image.Height / 8;
            form.pcb_image.Image = image;
            //maybe make form resizable
        }
    }
}
