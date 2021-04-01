using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallery
{
    class ExpoLogic
    {
        static List<int> oldExpoPictures = new List<int>();
        static List<int> newExpoPictures = new List<int>();
        static List<string> oldInfo;

        static public void addExpo(string name, DateTime start, DateTime end, string place, int eId, Context C)
        {
            var ex = C.Expos.Where(c => c.Name == name).FirstOrDefault();
            if (ex != null)
            {
                throw new Exception("Exposition already exists!");
            }

            Expo expo = new Expo
            {
                Name = name,
                StartDate = start,
                EndDate = end,
                Place = place
            };

            C.Expos.Add(expo);

            for (int i = 0; i < newExpoPictures.Count(); i++)
            {
                C.ExpoPictures.Add(new ExpoPicture
                {
                    ExpoId = expo.ExpoId,
                    PictureId = newExpoPictures[i]
                });

                C.Journals.Add(new Journal
                {
                    EmployeeId = 1,  
                    PlaceFromId = 1,
                    PlaceToId = 1,
                    PictureId = newExpoPictures[i],
                    ExpoId = expo.ExpoId
                });
            }

            C.SaveChanges();

        }

        static public void deleteExpo(int id, Context C)
        {
            var ex = C.Expos.Where(c => c.ExpoId == id).FirstOrDefault();

            C.Expos.Remove(ex);

            var jour = C.Journals.Where(c => c.ExpoId == id);
            C.Journals.RemoveRange(jour);
            C.SaveChanges();

        }

        static public int getId(string s, Context C)
        {
            return C.Expos.Where(c => c.Name == s)
                .Select(c => c.ExpoId).FirstOrDefault();
        }

        static public List<string> oldData(int id, Context C)
        {
            var oldData = C.Expos.Where(c => c.ExpoId == id)
                .FirstOrDefault();

            oldExpoPictures = C.ExpoPictures.Where(c => c.ExpoId == id).Select(c => c.PictureId).ToList<int>();
            newExpoPictures = C.ExpoPictures.Where(c => c.ExpoId == id).Select(c => c.PictureId).ToList<int>();

            oldInfo = new List<string>{oldData.Name, oldData.Place, oldData.StartDate.ToString(), oldData.EndDate.ToString()};

            return oldInfo;
        }

        static public string[] returnExpoPicturesList(int id, Context C)
        {
            var expoPictures = C.ExpoPictures.Where(c => c.ExpoId == id)
                .Select(c => c.Picture.Name + ", автор - " + c.Picture.Artist.FullName);

            newExpoPictures.Clear();
            newExpoPictures = C.ExpoPictures.Where(c => c.ExpoId == id).Select(c => c.PictureId).ToList<int>();
            return expoPictures.ToArray();
        }

        static public string[] getExpoPicturesList(Context C)
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

        static public void sendToExpo(string p1, Context C)
        {
            int pId = C.ExpoPictures.Where(c => c.Picture.Name + ", автор - " + c.Picture.Artist.FullName == p1).FirstOrDefault().PictureId;          

            if (!newExpoPictures.Contains(pId))
            {
                newExpoPictures.Add(pId);
            }     
        }

        static public void sendToStorage(string p1, Context C)
        {
            int pId = C.Pictures.Where(c => c.Name + ", автор - " + c.Artist.FullName == p1)
               .Select(c => c.PictureId).FirstOrDefault();
            newExpoPictures.Remove(pId);
        }

        static public void apply(string name, string place, DateTime start, DateTime end, int id, int eId, Context C)
        {
            var ex = C.ExpoPictures.Where(c => c.ExpoId == id);
            C.ExpoPictures.RemoveRange(ex);

            var jour = C.Journals.Where(c => c.ExpoId == id);
            C.Journals.RemoveRange(jour);

            List<ExpoPicture> exp = new List<ExpoPicture>(newExpoPictures.Count());
            List<Journal> journ = new List<Journal>(newExpoPictures.Count());

            for (int i = 0; i < newExpoPictures.Count(); i++)
            {
                exp.Add(new ExpoPicture
                {
                    ExpoId = id,
                    PictureId = newExpoPictures[i]
                }
                );

                journ.Add(new Journal
                {
                    ExpoId = id,
                    PictureId = newExpoPictures[i],
                    PlaceFromId = 1,
                    PlaceToId = 1,
                    EmployeeId = 1
                }
                );

            }

            C.ExpoPictures.AddRange(exp);
            C.Journals.AddRange(journ);


            var expo = C.Expos.Where(c => c.ExpoId == id)
                .FirstOrDefault();
            expo.Name = name;
            expo.Place = place;
            expo.StartDate = start;
            expo.EndDate = end;

            C.SaveChanges();
        }

        static public void updateJournal(Context C)
        {
            
        }
    }
}
