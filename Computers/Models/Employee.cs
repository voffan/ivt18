using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Employee
    {
        public Employee() { }
        public Employee(Dictionary<string, object> dict)
        {
            if (dict.ContainsKey("surname"))
                Surname = dict["surname"] as string;
            if (dict.ContainsKey("name"))
                Name = dict["name"] as string;
            if (dict.ContainsKey("patronymicName"))
                PatronymicName = dict["patronymicName"] as string;
            if (dict.ContainsKey("room"))
                Room = dict["room"] as string;
            if (dict.ContainsKey("computerId"))
                ComputerId = dict["computerId"] as string;
            if (dict.ContainsKey("peripheralIds"))
                PeripheralIds = dict["peripheralIds"] as List<string>;
        }
        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>
            {
                { "surname", Surname },
                { "name", Name },
                { "patronymicName", PatronymicName },
                { "room", Room },
                { "computerId", ComputerId },
                { "peripheralIds", PeripheralIds }
            };
        }
        public string Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string PatronymicName { get; set; }
        public string Room { get; set; }
        public string ComputerId { get; set; }
        public List<string> PeripheralIds { get; set; }
    }
}
