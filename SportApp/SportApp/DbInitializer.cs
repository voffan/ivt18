using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace SportApp
{
	public class DbInitializer : CreateDatabaseIfNotExists<Context>
	{
		protected override void Seed(Context context)
		{
			base.Seed(context);
		}
	}
}
