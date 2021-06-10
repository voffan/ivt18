using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallery
{
    class EmployeeLogic
    {
     

        public static void addEmoployee(Context context, String[] emparr)
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
                emp.GalleryId = Int32.Parse(emparr[4]);
            }

            if (emparr[5].Length != 0)
            {
                emp.PositionId = Int32.Parse(emparr[5]);
            }
          
      

            //int employeeId = getEmployeeById(fullname, C);

            context.Employees.Add(emp);
            context.SaveChanges();
        }

        public static void deleteEmployee(Context context, int id)
        {
            //Employee emp = new Employee();
            //id = emp.EmployeeId;
           
           // var ex = context.Employees.Where(c => c.EmployeeId==id).FirstOrDefault();

           // context.Employees.Remove(ex);

            Employee p = context.Employees.Where(o => o.EmployeeId == id).FirstOrDefault();
            context.Employees.Remove(p);
                 context.SaveChanges();
            
               // context.Employees.Attach(context.Employees.Find(id));
          // context.Employees.Remove(context.Employees.Find(id));
           // context.SaveChanges();
        }


        static public int getId(string s, Context C)
        {
            return C.Employees.Where(c => c.FullName == s)
                .Select(c => c.EmployeeId).FirstOrDefault();
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
                emp.GalleryId = Int32.Parse(emparr[4]);
            }

            if (emparr[5].Length != 0)
            {
                emp.PositionId = Int32.Parse(emparr[5]);
            }
            
           
            C.SaveChanges();

        }
    }
}