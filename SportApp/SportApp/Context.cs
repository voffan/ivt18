using SportApp.Classes;

namespace SportApp
{
	using System.Data.Entity;

	[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
	public partial class Context : DbContext
	{
		public Context() : base("name=Sport")
		{
			Database.SetInitializer<Context>(new DbInitializer());
		}
		public virtual DbSet<City> Cities { get; set; }
		public virtual DbSet<Competition> Competitions { get; set; }
		public virtual DbSet<News> Newss { get; set; }
		public virtual DbSet<Participant> Participants { get; set; }
		public virtual DbSet<Person> Persons { get; set; }
		public virtual DbSet<Position> Positions { get; set; }
		public virtual DbSet<Result> Results { get; set; }
		public virtual DbSet<SportCategory> SportCategorys { get; set; }
		public virtual DbSet<SportType> SportTypes { get; set; }

	}
}
