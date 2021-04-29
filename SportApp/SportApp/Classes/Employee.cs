using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
    public enum EmployeePosition { Admin, Organizator, Judge }
    [Table("Employee")]
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
