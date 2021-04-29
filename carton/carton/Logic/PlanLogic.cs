using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Xml;
using System.Drawing;
using System.IO;

namespace carton
{
    public class PlanLogic
    {
        public void ExportPlan(Context context)
        {

        }

        public void CreatePlan(Context context, Dictionary<int,int> data)
        {
            Plan plan = new Plan();

            //plan.Name = ss[0];
            //plan.Date = ss[1];
            //plan.Status = PlanStatus.New;
            //plan.Planneds = null;
            //plan.ProdLineId = SomeProdLineId;

            context.Plans.Add(plan);
            context.SaveChanges();
        }

        public void EditPlan(Context context, Plan plan)
        {
            //some edits

            //plan.Id = nextID();
            //plan.Name = nameBox.Text;
            //plan.Date = dateBox.Text;
            //plan.Status = PlanStatus.New;
            //plan.Planneds = null;
            //plan.ProdLineId = SomeProdLineId;

            context.Plans.Add(plan);
        }

        public void GetPlansList(Context context)
        {
            //get list of ids of new plans
            IQueryable<int> idList = context.Plans.Where(x => x.Status == PlanStatus.New).Select(x => x.Id);
        }

        public void ExportPlan(Plan plan, Context context)
        {
            String filename = plan.Id.ToString() + "-" + plan.Name + "-" + plan.Date.ToString("dd.MM.yyyy") + ".xlsx";
            FileInfo fileinfo = new FileInfo(filename);
            ExcelPackage excel = new ExcelPackage(fileinfo);
            ExcelWorksheet workSheet = excel.Workbook.Worksheets.Add("Plan");

            //Set column width
            workSheet.Column(1).Width = 40 / 7.5;
            workSheet.Column(2).Width = 120 / 7.5;
            workSheet.Column(3).Width = 80 / 7.5;
            workSheet.Column(4).Width = 80 / 7.5;
            workSheet.Column(5).Width = 19.29;
            workSheet.Column(6).Width = 20 / 7.5;
            workSheet.Column(7).Width = 120 / 7.5;
            workSheet.Column(8).Width = 85 / 7.5;
            workSheet.Column(9).Width = 110 / 7.5;
            workSheet.Column(10).Width = 130 / 7.5;
            workSheet.Column(11).Width = 80 / 7.5;

            //Headers
            workSheet.Cells["A1"].Value = "ID";
            workSheet.Cells["B1"].Value = "NAME";
            workSheet.Cells["C1"].Value = "DATE";
            workSheet.Cells["D1"].Value = "STATUS";
            workSheet.Cells["E1"].Value = "PRODUCTION LINE ID";
            workSheet.Cells["G1"].Value = "PRODUCT ID";
            workSheet.Cells["H1"].Value = "PRODUCT NAME";
            workSheet.Cells["I1"].Value = "PRODUCT AMOUNT";
            workSheet.Cells["J1"].Value = "COMPLETED";

            //Plan
            workSheet.Cells["A2"].Value = plan.Id;
            workSheet.Cells["B2"].Value = plan.Name;
            workSheet.Cells["C2"].Value = plan.Date.ToString("dd.MM.yyyy");
            workSheet.Cells["D2"].Value = plan.Status;
            workSheet.Cells["E2"].Value = plan.ProdLineId;
            

            int i = 0;
            List<Planned> planneds = context.Planneds.ToList();
            List<Planned> exactPlanneds = new List<Planned>();
            
            foreach (Planned p in planneds)
            {
                if (plan.Id == p.PlanId)
                {
                    exactPlanneds.Add(p);
                    workSheet.Cells["G" + (i + 2).ToString()].Value = p.ProductId;
                    workSheet.Cells["H" + (i + 2).ToString()].Value = context.Products.Find(p.ProductId).Name;
                    workSheet.Cells["I" + (i + 2).ToString()].Value = p.PlanProduction;
                    workSheet.Cells["J" + (i + 2).ToString()].Value = p.Complete;
                    i++;
                }
            }

            // set some core property values
            excel.Workbook.Properties.Title = "Plan export table";
            excel.Workbook.Properties.Author = "tribute to John Tunnicliffe";
            excel.Workbook.Properties.Subject = "ExcelPackage Samples";
            excel.Workbook.Properties.Keywords = "Office Open XML";
            excel.Workbook.Properties.Category = "ExcelPackage Samples";
            excel.Workbook.Properties.Comments = "This sample demonstrates how to create an Excel 2007 file from scratch using the Packaging API and Office Open XML";

            
            excel.Save();
        }
        
        public void ApproveCompletion(Plan plan, Context context)
        {
            plan.Status = PlanStatus.Completed;

            setPlannedComplete(context, plan.Id, true);
            
            context.SaveChanges();
        }

        public void ApplyPlan(Plan plan, Context context)
        {
            plan.Status = PlanStatus.InProgress;

            setPlannedComplete(context, plan.Id, false);

            context.SaveChanges();
        }

        public void resetToNew(Plan plan, Context context)
        {
            plan.Status = PlanStatus.New;

            setPlannedComplete(context, plan.Id, false);

            context.SaveChanges();
        }

        public void MarkToDelete(Plan plan, Context context)
        {
            plan.Status = PlanStatus.ToDelete;

            setPlannedComplete(context, plan.Id, false);

            context.SaveChanges();
        }

        public void DeleteMarkedPlans(Context context)
        {
            foreach (Plan p in context.Plans)
            {
                if (p.Status == PlanStatus.ToDelete)
                {
                    context.Plans.Remove(p);
                }
            }
        }

        public void setPlannedComplete(Context context, int id, bool flag)
        {
            List<Planned> planneds = context.Planneds.ToList();

            foreach (Planned p in planneds)
            {
                if (id == p.PlanId)
                {
                    p.Complete = flag;
                }
            }
        }
    }
}
