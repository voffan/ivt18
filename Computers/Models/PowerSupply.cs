using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class PowerSupply : Device
    {
        public PowerSupply() { }
        public PowerSupply(Dictionary<string, object> dict) : base(dict)
        {
            if (dict.ContainsKey("computerId"))
                ComputerId = dict["computerId"] as string;
            if (dict.ContainsKey("power"))
                Power = Convert.ToInt32(dict["power"]);
        }
        public override Dictionary<string, object> ToDict()
        {
            var deviceDict = base.ToDict();
            var dict = new Dictionary<string, object>
            {
                { "computerId", ComputerId },
                { "power", Power }
            };
            foreach (var deviceField in deviceDict)
            {
                dict.Add(deviceField.Key, deviceField.Value);
            }
            return dict;
        }
        public int Power { get; set; }
        public string ComputerId { get; set; }
    }
}
