using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallery
{
    class ExpoLogic
    {
        static List<int> oldExpoPictures;
        static List<int> newExpoPictures;
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

            //for (int i = 0; i < expoPictures.Count(); i++)
            // C.ExpoPictures.Add( new ExpoPicture 
            //{ 
            //  ExpoId = expo.ExpoId, PictureId = expoPictures[i]
            //}
            //);

            C.SaveChanges();

        }

        static public int getId(string s, Context C)
        {
            return C.Expos.Where(c => c.Name == s)
                .Select(c => c.ExpoId).FirstOrDefault();
        }

        static public Expo oldData(int id, Context C)
        {
            var oldData = C.Expos.Where(c => c.ExpoId == id)
                .FirstOrDefault();
            oldExpoPictures = C.ExpoPictures.Where(c => c.ExpoId == id).Select(c => c.PictureId).ToList<int>();
            newExpoPictures = C.ExpoPictures.Where(c => c.ExpoId == id).Select(c => c.PictureId).ToList<int>();

            return oldData;
        }

        static public string[] returnExpoPicturesList(int id, Context C)
        {
            var expoPictures = C.ExpoPictures.Where(c => c.ExpoId == id)
                .Select(c => c.Picture.Name + ", автор - " + c.Picture.Artist.FullName);

            newExpoPictures.Clear();
            newExpoPictures = C.ExpoPictures.Where(c => c.ExpoId == id).Select(c => c.PictureId).ToList<int>();
            return expoPictures.ToArray();
        }

        static public string[] getExpoPicturesList(int id, Context C)
        {
            string[] s = new string[newExpoPictures.Count()];
            for (int i = 0; i < newExpoPictures.Count(); i++)
            {
                int k = newExpoPictures[i];
                s[i] = C.Pictures.Where(c => c.PictureId == k)
                    .Select(c => c.Name + ", автор - " + c.Artist.FullName).FirstOrDefault();
            }

            return s;
        }

        static public string[] updatePicturesList(Context C)
        {
            var pictures = C.Pictures.Select(c => c.Name + ", автор - " + c.Artist.FullName);

            return pictures.ToArray();
        }

        static public void sendToExpo(string p1, int id, Context C)
        {
            int pId = C.ExpoPictures.Where(c => c.Picture.Name + ", автор - " + c.Picture.Artist.FullName == p1).FirstOrDefault().PictureId;          

            if (!newExpoPictures.Contains(pId))
            {
                newExpoPictures.Add(pId);
            }     
        }

        static public void sendToStorage(string p1, int id, Context C)
        {
            int pId = C.Pictures.Where(c => c.Name + ", автор - " + c.Artist.FullName == p1)
               .Select(c => c.PictureId).FirstOrDefault();
            newExpoPictures.Remove(pId);
        }

        static public void Apply(int id, Context C)
        {
            var ex = C.ExpoPictures.Where(c => c.ExpoId == id).ToArray();
            C.ExpoPictures.RemoveRange(ex);

            List<ExpoPicture> exp = new List<ExpoPicture>(newExpoPictures.Count());

            for (int i = 0; i < newExpoPictures.Count(); i++)
            {
                exp.Add(new ExpoPicture
                {
                    ExpoId = id,
                    PictureId = newExpoPictures[i]
                }
                );

            }

            C.ExpoPictures.AddRange(exp);
            C.SaveChanges();
        }
    }
}
