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

        // мб неправильно
        public int? PlaceId { get; set; }  
        [ForeignKey("PlaceId")]
        public Place From { get; set; }
        public Place To { get; set; }
        // ---

        public int PictureId { get; set; }
        [ForeignKey("PictureId")]
        public Picture Picture { get; set; }

        public int? ExpoId { get; set; }
        [ForeignKey("ExpoId")]
        public Expo Expo { get; set; }
   
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
