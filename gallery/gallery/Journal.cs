using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace gallery
{
    class Journal
    {
        [Key]
        public int JournalId { get; set; }
        public DateTime Date { get; set; }
        public Place From { get; set; } 
        public Place To { get; set; }

        [ForeignKey("PictureId")]
        public int PictureId { get; set; }
        public Picture Picture { get; set; }

        [ForeignKey("ExpoId")]
        public int ExpoId { get; set; }
        public Expo Expo { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
