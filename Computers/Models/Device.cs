using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Device
    {
        public Device() { }
        public Device(Dictionary<string, object> dict)
        {
            if (dict.ContainsKey("name"))
                Name = dict["name"] as string;
            if (dict.ContainsKey("price"))
                Price = Convert.ToInt32(dict["price"]);
            if (dict.ContainsKey("manufacturerId"))
                ManufacturerId = dict["manufacturerId"] as string;
            if (dict.ContainsKey("statusId"))
                StatusId = dict["statusId"] as string;
        }
        public virtual Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object> 
            {
                { "name", Name },
                { "price", Price },
                { "manufacturerId", ManufacturerId },
                { "statusId", StatusId }
            };
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ManufacturerId { get; set; }
        public string StatusId { get; set; }
    }
}
