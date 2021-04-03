using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Computer : Device
    {
        public Computer() { }
        public Computer(Dictionary<string, object> dict) : base(dict)
        {
            if (dict.ContainsKey("ip"))
                Ip = dict["ip"] as string;
            if (dict.ContainsKey("itemNo"))
                ItemNo = dict["itemNo"] as string;
            if (dict.ContainsKey("employeeId"))
                EmployeeId = dict["employeeId"] as string;
            if (dict.ContainsKey("diskDriveId"))
                DiskDriveId = dict["diskDriveId"] as string;
            if (dict.ContainsKey("processorId"))
                ProcessorId = dict["processorId"] as string;
            if (dict.ContainsKey("motherboardId"))
                MotherboardId = dict["motherboardId"] as string;
            if (dict.ContainsKey("powerSupplyIds"))
                PowerSupplyIds = dict["powerSupplyIds"] as List<string>;
            if (dict.ContainsKey("memoryIds"))
                MemoryIds = dict["memoryIds"] as List<string>;
            if (dict.ContainsKey("hardDriveIds"))
                HardDriveIds = dict["hardDriveIds"] as List<string>;
            if (dict.ContainsKey("graphicCardIds"))
                GraphicCardIds = dict["graphicCardIds"] as List<string>;
        }
        public override Dictionary<string, object> ToDict()
        {
            var deviceDict = base.ToDict();
            var dict = new Dictionary<string, object> 
            {
                { "ip", Ip },
                { "itemNo", ItemNo },
                { "employeeId", EmployeeId },
                { "diskDriveId", DiskDriveId },
                { "processorId", ProcessorId },
                { "motherboardId", MotherboardId },
                { "powerSupplyIds", PowerSupplyIds },
                { "memoryIds", MemoryIds },
                { "hardDriveIds", HardDriveIds },
                { "graphicCardIds", GraphicCardIds }
            };
            foreach (var deviceField in deviceDict)
            {
                dict.Add(deviceField.Key, deviceField.Value);
            }
            return dict;
        }
        public string Ip { get; set; }
        public string ItemNo { get; set; }

        public string EmployeeId { get; set; }
        public string DiskDriveId { get; set; }
        public string ProcessorId { get; set; }
        public string MotherboardId { get; set; }
        
        public List<String> PowerSupplyIds { get; set; }
        public List<String> MemoryIds { get; set; }
        public List<String> HardDriveIds { get; set; }
        public List<String> GraphicCardIds { get; set; }
    }
}
