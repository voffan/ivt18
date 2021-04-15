﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carton
{
    public class PlanLogic
    {
        public void ExportPlan(Context context)
        {

        }

        public void CreatePlan(Context context, List<string> ss)
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
