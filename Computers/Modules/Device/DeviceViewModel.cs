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
        
        public Dictionary<Models.Manufacturer, string> manufacturers = new Dictionary<Models.Manufacturer, string> {};
        
        public Dictionary<Models.Status, string> statuses = new Dictionary<Models.Status, string> {};
    }
}
