using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Manufacturer
    {
        public Manufacturer() { }
        public Manufacturer(Dictionary<string, object> dict)
        {
            if (dict.ContainsKey("name"))
                Name = dict["name"] as string;
        }
        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>
            {
                { "name", Name }
            };
        }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
