using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace carton
{
    public class EmployeeLogic
    {
    	public static bool LoginEmployee(Context c, string login, string password)
    	{
    		if (login.Equals("sysadmin") and password.Equals("1234")) return true;
    		else false;
    	}
	}
}