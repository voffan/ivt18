//using WindowsFormsApp1.Classes;
using System;
using System.Data.Entity;
using MySql.Data.Entity;


namespace WindowsFormsApp1
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context : DbContext
    {
        
        public Context() : base("SampleContext") { }
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<News> Newss { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<SportCategory> SportCategorys { get; set; }
        public DbSet<SportType> SportTypes { get; set; }

    }
}