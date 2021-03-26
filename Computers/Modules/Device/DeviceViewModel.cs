using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Device
{
    public class DeviceViewModel
    {
        public Utils.DeviceType deviceType = Utils.DeviceType.None;
        
        public Dictionary<string, Models.Manufacturer> manufacturers = new Dictionary<string, Models.Manufacturer> {};
        
        public Dictionary<string, Models.Status> statuses = new Dictionary<string, Models.Status>{};
    }
}
