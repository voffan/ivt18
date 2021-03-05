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
    public class SportCategory
    {
		[ForeignKey("SportCategoryID")]
		public int SportCategoryID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; } 
		public string Regulation { get; set; }
		
    }
}
