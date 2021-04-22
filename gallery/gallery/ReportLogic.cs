using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallery
{
    class ReportLogic
    {
        static public void downloadReport(DateTime d1, DateTime d2, Context C)
        {
            object Nothing = System.Reflection.Missing.Value;
            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook workBook = app.Workbooks.Add(Nothing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Sheets[1];
            worksheet.Name = "WorkSheet";

            worksheet.Cells[1, 1] = "Отчет от ";
            worksheet.Cells[1, 2] = d1 + " - " + d2;


            var query = from c in C.Journals
                        where c.Date > d1 && c.Date < d2
                        select new { ID = c.EmployeeId, ФИО = c.Employee.FullName, Должность = c.Employee.Position.Name, Дата = c.Date, Картина = c.Picture.Name, Автор = c.Picture.Artist.FullName, c.DepartmentFromId, c.DepartmentToId };

            var res = query.ToList();

            for (int i = 1; i <= res.Count(); i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    foreach (var r in res)
                    {
                        //worksheet.Cells[2, j] = res.;
                        worksheet.Cells[i + 2, j] = r;
                    }

                }
            }

        }

        static public IQueryable loadData(DateTime d1, DateTime d2, Context C)
        {
            var query = from c in C.Journals
                        where c.Date > d1 && c.Date < d2
                        select new { ID = c.EmployeeId, ФИО = c.Employee.FullName, Должность = c.Employee.Position.Name, Дата = c.Date, Картина = c.Picture.Name, Автор = c.Picture.Artist.FullName, c.DepartmentFromId, c.DepartmentToId };


            return query;
        }

    }
}
