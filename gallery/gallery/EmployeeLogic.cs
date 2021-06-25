using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Data.Entity.Migrations;
namespace gallery
{
    class EmployeeLogic
    {

        static List<int> oldEmployeePictures = new List<int>();
        static List<int> newEmployeePictures = new List<int>();
        static List<string> oldInfo;
        public static int LoginEmployee(Context С, string login, string password)
        {
            if (login.Equals("123") && password.Equals("123"))
                return 1;
            return -1;
        }


            public static void addEmoployee(Context context, String[] emparr)
        {
          
            Employee emp = new Employee();
     
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
            context.Employees.Add(emp);
            context.SaveChanges();
        }

        public static void deleteEmployee(Context context, int id)
        {
            var ex = context.Employees.Where(c => c.EmployeeId == id).FirstOrDefault();
            context.Employees.Remove(ex);
            context.SaveChanges();
        }


        static public int getId(string s, Context C)
        {
            return C.Employees.Where(c => c.FullName == s)
                .Select(c => c.EmployeeId).FirstOrDefault();
        }

        public static void editEmployee(Context C, String[] emparr)
        {
            Employee emp = new Employee();
            var fmd = C.Employees.Find(Int32.Parse(emparr[0]));
            if (emparr[1].Length != 0)
            {
                fmd.FullName = emparr[1];
            }
            if (emparr[2].Length != 0)
            {
                fmd.Login = emparr[2];
            }
            if (emparr[3].Length != 0)
            {
                fmd.Password = emparr[3];
            }
            if (emparr[4].Length != 0)
            {
                fmd.Phone = Int32.Parse(emparr[4]);
            }
            if (emparr[5].Length != 0)
            {
                fmd.GalleryId = Int32.Parse(emparr[5]);
            }

            if (emparr[6].Length != 0)
            {
                fmd.PositionId = Int32.Parse(emparr[6]);
            }

            C.Employees.AddOrUpdate(fmd);
            C.SaveChanges();

        }

        static public List<string> oldData(int id, Context C)
        {
            var oldData = C.Employees.Where(c => c.EmployeeId == id)
                .FirstOrDefault();

            oldEmployeePictures = C.Employees.Where(c => c.EmployeeId == id).Select(c => c.PositionId).ToList<int>();
            newEmployeePictures = C.Employees.Where(c => c.EmployeeId == id).Select(c => c.PositionId).ToList<int>();

            oldInfo = new List<string> { oldData.FullName, oldData.Login, oldData.Password, oldData.GalleryId.ToString(), oldData.PositionId.ToString()  };

            return oldInfo;
        }


    }
}