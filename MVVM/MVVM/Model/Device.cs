using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace MVVM.Model
{
    public class Device
    {
        public static Device CreateDevice(string name, string type, List<string> ipAddressList)
        {
            return new Device { Name = name, Type = type, IPAddressList = ipAddressList };
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public List<string> IPAddressList { get; set; }




    }
}
