using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    public class Result
    {
        public SportType Sport { get; set; } 
        public SportCategory category { get; set; } 
		[ForeignKey("SportCategoryID")]
		public double points { get; set; } 
		public int place { get; set; } 

		public int CompetitionId { get; set; }
		[ForeignKey("CompetitionId")]
		public Competition Competition { get; set; }
    }
}
