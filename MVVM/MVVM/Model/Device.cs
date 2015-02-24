using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace MVVM.Model
{
    public class Device
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public list<IPAddress> IPAddressList { get; set; }

        public Device()
        {
            return new Device {Name="Unknow", Type="Unknow", IPAddressList = new IPAddressList()};
        }
    }
}
