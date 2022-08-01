using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnvifRestApiGW.OnvifObjects.Inputs
{
    public class OnvifSetNetworkInterfacesInputs
    {
        public string InterfaceName { get; set; }
        public bool Enabled { get; set; }
        public int MTU { get; set; }
        public int IPV4PrefixLength { get; set; }
        public bool IPV4Enabled { get; set; }
        public bool IPV4Manual { get; set; }
        public string IPV4ManualAddress { get; set; }
        public bool IPV4DHCP { get; set; }
    }
}
