using MediaDevices;
using System;
using System.Collections.Generic;
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
    }
}
