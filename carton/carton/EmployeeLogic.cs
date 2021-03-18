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
    	public static int LoginEmployee(Context c, string login, string password)
    	{
    		if (login.Equals("sysadmin") && password.Equals("1234")) 
                return 1;
            if (login.Equals("vasya") && password.Equals("123321"))
                return 2;
    		return -1;
    	}

        //edit password

        //edit login
	}
}