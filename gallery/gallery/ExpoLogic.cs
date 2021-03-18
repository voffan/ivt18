using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gallery
{
    class ExpoLogic
    {
        static public bool ViewExpo(int id, Label elem, Context C)
        {
            var expo = C.Expos.Where(c => c.ExpoId == id).FirstOrDefault();

            elem.Text = expo.Name + "\n\nМесто проведения: " + expo.Place + "\n\nВремя проведения: " + expo.StartDate + "  -  " + expo.EndDate;

            if (elem != null) return true;
            return false;
        }

        static public void AddExpo(Form f, string name, DateTime start, DateTime end, string place, Context C)
        {
            var ex = C.Expos.Where(c => c.Name == name).FirstOrDefault();
            if (ex != null)
            {
                raise Exception("Expo already exists!");
            }

            Expo expo = new Expo
            {
                Name = name,
                StartDate = start,
                EndDate = end,
                Place = place
                
            };

            C.Expos.Add(expo);
            C.SaveChanges();

            f.Close();
        }

        static public int getId(string s, Context C)
        {
            return C.Expos.Where(c => c.Name == s)
                .Select(c => c.ExpoId).FirstOrDefault();
        }

        static public Expo oldData(int id, Context C)
        {
            return C.Expos.Where(c => c.ExpoId == id)
                .FirstOrDefault();

        }

        static public Array updatePicturesList(ListBox lb1, ListBox lb2, int id, Context C)
        {
            lb1.Items.Clear();
            lb1.Items.AddRange(C.Pictures.Select(c => c.Name).ToArray());
            var expoPictures =
                from pic in C.Pictures 
                join expPic in C.ExpoPictures on pic.PictureId equals expPic.PictureId
                where expPic.ExpoId == id
                select pic.Name;

            lb2.Items.Clear();
            lb2.Items.AddRange(expoPictures.ToArray());

           return true;
        }

        static public void sendToExpo(string p1, int id, Context C)
        {
            int picId = C.Pictures.Where(c => c.Name == p1)
               .Select(c => c.PictureId).FirstOrDefault();

            var ex = C.ExpoPictures.Where(c => c.PictureId == picId && c.ExpoId == id).FirstOrDefault();

            if (ex == null)
            {
                var expPic = new ExpoPicture // в обязанности кнопки
                {
                    ExpoId = id,
                    PictureId = picId
                };

                C.ExpoPictures.Add(expPic); 
                C.SaveChanges();
            }
          
        }
    }
}
