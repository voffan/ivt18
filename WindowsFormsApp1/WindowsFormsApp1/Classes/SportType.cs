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
    public class SportType
    {	
		[ForeignKey("SportTypeID")]
		public int SportTypeID { get; set; }
        public string SportType { get; set; }
		
    }
}
