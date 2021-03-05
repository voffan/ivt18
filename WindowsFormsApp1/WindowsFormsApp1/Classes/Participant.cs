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
    public class Participant
    {
        public string SportType { get; set; }
		[ForeignKey("SortType")]
    	[StringLength(250)]
		public string Category { get; set; }
		
    }
}
