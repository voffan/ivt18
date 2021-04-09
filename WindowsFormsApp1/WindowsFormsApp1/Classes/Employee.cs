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
	public enum EmployeePosition {Admin, Organizator, Judge}
    public class Employee
    {	
		[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeePosition Position { get; set; }
		public string Email { get; set; }
		public int Phone { get; set; }
    }
}
