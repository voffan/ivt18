using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallery
{
    class EmployeeLogic
    {
        static public string getEmployeeById(int empId, Context C)
        {
            return C.Employees.Where(c => c.EmployeeId == empId)
            .Select(c => c.FullName).FirstOrDefault();
        }

        public static void addEmoployee(Context C, String[] emparr)
        {
            Employee emp = new Employee();
            //emp.EmployeeId = id;
            emp.FullName = emparr[0];
            emp.Login = emparr[1];
            emp.Password = emparr[2];
            emp.Phone = Int32.Parse(emparr[3]);
            emp.EmployeeId = Int32.Parse(emparr[4]);
            emp.PositionId = Int32.Parse(emparr[5]);
            emp.GalleryId = Int32.Parse(emparr[6]);
      

            //int employeeId = getEmployeeById(fullname, C);

            C.Employees.Add(emp);
            C.SaveChanges();
        }

        public static void deleteEmployee(Context C, int id)
        {
            Employee emp = C.Employees
            .Where(o => o.EmployeeId == id)
            .FirstOrDefault();

            C.Employees.Remove(emp);
            C.SaveChanges();

        }

        public static void updateEmployee(Context C, string fullname, string login, string password, int number)
        {
            Employee emp = new Employee();


            if (emp != null)
            {
                emp.FullName = fullname;
                emp.Login = login;
                emp.Password = password;
                emp.Phone = number;
                C.SaveChanges();

            }



        }
    }
}