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
                return 1; //Sysadmin
            if (login.Equals("vasya") && password.Equals("123321"))
                return 2; //Storage Employee
            if (login.Equals("dir") && password.Equals("0000"))
                return 3; //Director
            if (login.Equals("eco") && password.Equals("0000"))
                return 4; //Economy Employee
            if (login.Equals("rab") && password.Equals("0"))
                return 5; //Foreman
            return -1;
    	}

        //edit password
        public void addUser(Context context, String[] userArray)
        {
            Employee employee = new Employee();
            if (userArray[0] != "")
            {
                employee.Surname = userArray[0];
            }
            if (userArray[1] != "")
            {
                employee.Name = userArray[1];
            }
            if (userArray[2] != "")
            {
                employee.Fathername = userArray[2];
            }
            if (userArray[3] != "")
            {
                employee.Login = userArray[3];
            }
            if (userArray[4] != "")
            {
                employee.Password = userArray[4];
            }
            if (userArray[5] != "")
            {
                employee.PositionId = Int32.Parse(userArray[5]);
            }
            if (userArray[6] != "")
            {
                employee.StatusId = Int32.Parse(userArray[6]);
            }
            if (userArray[7] != "")
            {
                employee.ContactPhone = userArray[7];
            }
            if (userArray[8] != "")
            {
                employee.Address = userArray[8];
            }
            if (userArray[9] != "")
            {
                employee.StorageId = Int32.Parse(userArray[9]);
            }
            if (userArray[10] != "")
            {
                employee.FactoryId = Int32.Parse(userArray[10]);
            }
            if (userArray[11] != "")
            {
                employee.FactoryDirectorId = Int32.Parse(userArray[11]);
            }
            context.Employees.Add(employee);

            context.SaveChanges();
        }

        public void editUser(Employee employee, Context context)
        {

        }

        public void deleteUser(Employee employee, Context context)
        {

        }

        //edit login
    }
}