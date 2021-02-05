using System.Collections.Generic;

namespace Computers.Models
{
    public class Operation
    {
        public Operation()
        {
            this.Logs = new HashSet<Log>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}
