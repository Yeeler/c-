using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using MVVM.Model;

namespace MVVM.DataAccess
{
    public class DeviceRepository
    {
        readonly List<Device> devices;

        public DeviceRepository()
        {
            if (devices == null)
            {
                devices = new List<Device>();
            }

            devices.Add(Device.CreateDevice("Galatica", "Windows", new List<string> { "192.168.1.150", "192.168.1.140" }));
            devices.Add(Device.CreateDevice("Infinity", "Linux", new List<string> { "192.168.1.110" }));
            devices.Add(Device.CreateDevice("Prometheus", "MAC", new List<string> { "192.168.1.105" }));
        }

        public List<Device> GetDevices()
        {
            return new List<Device>(devices);
        }
    
    }
}
