using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallery
{
    class ReportLogic
    {
     static public void downloadReport(int id, Context C)
        {
            var report = C.Journals.Where(c => c.EmployeeId == id);
            // .........
        }
  
    }
}
