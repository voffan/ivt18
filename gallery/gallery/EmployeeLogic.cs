using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallery
{
    class EmployeeLogic
    {
     

        public static void addEmoployee(Context C, String[] emparr)
        {
            Employee emp = new Employee();
            //emp.EmployeeId = id;
            if (emparr[0].Length != 0)
            {
                emp.FullName = emparr[0];
            }
            if (emparr[1].Length != 0)
            {
                emp.Login = emparr[1];
            }
            if (emparr[2].Length != 0)
            {
                emp.Password = emparr[2];
            }
            if (emparr[3].Length != 0)
            {
                emp.Phone = Int32.Parse(emparr[3]);
            }
            if (emparr[4].Length != 0)
            {
                emp.EmployeeId = Int32.Parse(emparr[4]);
            }

            if (emparr[5].Length != 0)
            {
                emp.PositionId = Int32.Parse(emparr[5]);
            }
            if (emparr[6].Length != 0)
            {
                emp.GalleryId = Int32.Parse(emparr[6]);
            }
      

            //int employeeId = getEmployeeById(fullname, C);

            C.Employees.Add(emp);
            C.SaveChanges();
        }

        public static void deleteEmployee(Context C, int id)
        {
       
            C.Employees.Attach(C.Employees.Find(id));
            C.Employees.Remove(C.Employees.Find(id));
            C.SaveChanges();
        }

        public static void updateEmployee(Context C, String[] emparr)
        {
            Employee emp = new Employee();


            var fmd = C.Employees.Find(Int32.Parse(emparr[0]));
            if (emparr[0].Length != 0)
            {
                emp.FullName = emparr[0];
            }
            if (emparr[1].Length != 0)
            {
                emp.Login = emparr[1];
            }
            if (emparr[2].Length != 0)
            {
                emp.Password = emparr[2];
            }
            if (emparr[3].Length != 0)
            {
                emp.Phone = Int32.Parse(emparr[3]);
            }
            if (emparr[4].Length != 0)
            {
                emp.EmployeeId = Int32.Parse(emparr[4]);
            }

            if (emparr[5].Length != 0)
            {
                emp.PositionId = Int32.Parse(emparr[5]);
            }
            if (emparr[6].Length != 0)
            {
                emp.GalleryId = Int32.Parse(emparr[6]);
            }
           
            C.SaveChanges();

        }
    }
}