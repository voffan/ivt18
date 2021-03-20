using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallery
{
    class ExpoLogic
    {
        static List<ExpoPicture> expPics;
        static public Expo ViewExpo(int id,Context C)
        {
            var expo = C.Expos.Where(c => c.ExpoId == id).FirstOrDefault();
            return expo;
        }

        static public void AddExpo(string name, DateTime start, DateTime end, string place, Context C)
        {
            var e = C.Expos.Where(c => c.Name == name).FirstOrDefault();
            if (e != null)
            {
                throw new InvalidOperationException("Exposition already exists!");
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

        static public string[] updateExpoPicturesList(int id, Context C)
        {
            var expoPictures = C.ExpoPictures.Where(c => c.ExpoId == id)
                .Select(c => c.Picture.Name + ", автор - " + c.Picture.Artist.FullName);

           return expoPictures.ToArray();
        }

        static public string[] updatePicturesList(Context C)
        {
            var pictures = C.Pictures.Select(c => c.Name + ", автор - " + c.Artist.FullName);

            return pictures.ToArray();
        }

        static public void sendToExpo(string p1, int id, Context C)
        {

            var ex = C.ExpoPictures.Where(c => c.Picture.Name + ", автор - " + c.Picture.Artist.FullName == p1 && c.ExpoId == id).FirstOrDefault();           

            if (ex == null)
            {
                expPics.Add(new ExpoPicture // i dont know what to do
                {
                    ExpoId = id,
                    PictureId = ex.PictureId
                }
                );
                
            }     
        }

        static public void sendToStorage(string p1, int id, Context C)
        {
            int picId = C.Pictures.Where(c => c.Name == p1)
               .Select(c => c.PictureId).FirstOrDefault();

            var ex = C.ExpoPictures.Where(c => c.Picture.Name == p1 && c.ExpoId == id).FirstOrDefault();

            C.ExpoPictures.Remove(ex);
            C.SaveChanges();
           

        }

        static void Apply(Context C)
        {
            C.ExpoPictures.AddRange(expPics);
            expPics.Clear();
            C.SaveChanges();
        }
    }
}
