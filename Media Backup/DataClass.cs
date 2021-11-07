using System;
using System.Collections.Generic;
using System.Text;

namespace Media_Backup
{
    public class DataClass
    {
        public MediaDevices.MediaDevice MediaDevice { get; set; }
        public String DestinationFolder { get; set; }
        public IList<MediaDevices.MediaFileInfo> NewFiles;
        public int ImageIndex { get; set; }

        public DataClass()
        {
            NewFiles = new List<MediaDevices.MediaFileInfo>();
        }
    }
}
