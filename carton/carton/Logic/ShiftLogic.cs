using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carton
{
    public class ShiftLogic
    {
        public void Add(Context context, Shift shift, string boxA, string boxB, string boxC)
        {
            int a = 0;
            for(int i = 0; i<boxA.Length; i++)
            {
                a = a * 10 + boxA[i] - '0';
            }
            int b = 0;
            for (int i = 0; i < boxB.Length; i++)
            {
                b = b * 10 + boxB[i] - '0';
            }
            int c = 0;
            for (int i = 0; i < boxC.Length; i++)
            {
                c = c * 10 + boxC[i] - '0';
            }

            DailyProd dailyProdA = new DailyProd();
            dailyProdA.Production = a;
            dailyProdA.ProductId = 1;
            dailyProdA.ShiftId = shift.Id;

            DailyProd dailyProdB = new DailyProd();
            dailyProdB.Production = b;
            dailyProdB.ProductId = 2;
            dailyProdB.ShiftId = shift.Id;

            DailyProd dailyProdC = new DailyProd();
            dailyProdC.Production = c;
            dailyProdC.ProductId = 3;
            dailyProdC.ShiftId = shift.Id;

            context.DailyProds.Add(dailyProdA);
            context.DailyProds.Add(dailyProdB);
            context.DailyProds.Add(dailyProdC);

            context.SaveChanges();
        }

        public void Change(Context context, string boxA, int columnRow)
        {
            int a = 0;
            for (int i = 0; i < boxA.Length; i++)
            {
                a = a * 10 + boxA[i] - '0';
            }

            DailyProd dailyProdA = new DailyProd();
            dailyProdA.Production = a;
            context.SaveChanges();
        }
    }
}
