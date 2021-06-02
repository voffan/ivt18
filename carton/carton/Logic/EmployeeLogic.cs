using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Data.Entity.Migrations;

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
            if (userArray[0].Length != 0)
            {
                employee.Surname = userArray[0];
            }
            if (userArray[1].Length != 0)
            {
                employee.Name = userArray[1];
            }
            if (userArray[2].Length != 0)
            {
                employee.Fathername = userArray[2];
            }
            if (userArray[3].Length != 0)
            {
                employee.Login = userArray[3];
            }
            if (userArray[4].Length != 0)
            {
                employee.Password = userArray[4];
            }
            if (userArray[5].Length != 0)
            {
                employee.PositionId = Int32.Parse(userArray[5]);
            }
            if (userArray[6].Length != 0)
            {
                employee.StatusId = Int32.Parse(userArray[6]);
            }
            if (userArray[7].Length != 0)
            {
                employee.ContactPhone = userArray[7];
            }
            if (userArray[8].Length != 0)
            {
                employee.Address = userArray[8];
            }
            if (userArray[9].Length != 0)
            {
                employee.StorageId = Int32.Parse(userArray[9]);
            }
            if (userArray[10].Length != 0)
            {
                employee.FactoryId = Int32.Parse(userArray[10]);
            }
            if (userArray[11].Length != 0)
            {
                employee.FactoryDirectorId = Int32.Parse(userArray[11]);
            }
            context.Employees.Add(employee);

            context.SaveChanges();
        }

        public void editUser(Context context, String[] userArray)
        {
            var entity = context.Employees.Find(Int32.Parse(userArray[0]));
            if (userArray[1].Length != 0)
            {
                entity.Surname = userArray[1];
            }
            if (userArray[2].Length != 0)
            {
                entity.Name = userArray[2];
            }
            if (userArray[3].Length != 0)
            {
                entity.Fathername = userArray[3];
            }
            if (userArray[4].Length != 0)
            {
                entity.Login = userArray[4];
            }
            if (userArray[5].Length != 0)
            {
                entity.Password = userArray[5];
            }
            if (userArray[6].Length != 0)
            {
                entity.PositionId = Int32.Parse(userArray[6]);
            }
            if (userArray[7].Length != 0)
            {
                entity.StatusId = Int32.Parse(userArray[7]);
            }
            if (userArray[8].Length != 0)
            {
                entity.ContactPhone = userArray[8];
            }
            if (userArray[9].Length != 0)
            {
                entity.Address = userArray[9];
            }
            if (userArray[10].Length != 0)
            {
                entity.StorageId = Int32.Parse(userArray[10]);
            }
            if (userArray[11].Length != 0)
            {
                entity.FactoryId = Int32.Parse(userArray[11]);
            }
            if (userArray[12].Length != 0)
            {
                entity.FactoryDirectorId = Int32.Parse(userArray[12]);
            }

            context.Employees.AddOrUpdate(entity);
            context.SaveChanges();

        }

        public void deleteUser(Context context, int userId)
        {
            var entity = context.Employees.Find(userId);
            context.Employees.Attach(entity);
            context.Employees.Remove(entity);
            context.SaveChanges();
        }

        //edit login
    }
}