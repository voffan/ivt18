using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Motherboard : Device
    {
        public Motherboard() { }
        public Motherboard(Dictionary<string, object> dict) : base(dict)
        {
            if (dict.ContainsKey("computerId"))
                ComputerId = dict["computerId"] as string;
        }
        public override Dictionary<string, object> ToDict()
        {
            var deviceDict = base.ToDict();
            var dict = new Dictionary<string, object>
            {
                { "computerId", ComputerId }
            };
            foreach (var deviceField in deviceDict)
            {
                dict.Add(deviceField.Key, deviceField.Value);
            }
            return dict;
        }
        public string ComputerId { get; set; }
    }
}
