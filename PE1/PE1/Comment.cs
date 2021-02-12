using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PE1
{
    class Comment
    {
        [Key]
        public int CommentsId { get; set; }
        public DateTime Date { get; set; }
        public string Annotations { get; set; }
        public string User { get; set; }

        public int? BugId { get; set; }
        [ForeignKey("BugId")]
        public ICollection<Bug> Bugs { get; set; }
    }
}
