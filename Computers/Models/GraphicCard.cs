using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class GraphicCard : Device
    {
        public GraphicCard() { }
        public GraphicCard(Dictionary<string, object> dict) : base(dict)
        {
            if (dict.ContainsKey("computerId"))
                ComputerId = dict["computerId"] as string;
            if (dict.ContainsKey("capacity"))
                Capacity = Convert.ToInt32(dict["capacity"]);
        }
        public override Dictionary<string, object> ToDict()
        {
            var deviceDict = base.ToDict();
            var dict = new Dictionary<string, object>
            {
                { "computerId", ComputerId },
                { "capacity", Capacity }
            };
            foreach (var deviceField in deviceDict)
            {
                dict.Add(deviceField.Key, deviceField.Value);
            }
            return dict;
        }
        public int Capacity { get; set; }
        public string ComputerId { get; set; }
    }
}
