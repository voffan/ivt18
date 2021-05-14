using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class ClassGeneretionLogic
    {
        public string words = "АБВГДЕЖЗИКЛМН";
        int b; // индекс следующей буквы класса 
        // word = 'A';
        //private Context _context;




        internal void AddClass(Context context, int n, string w, int year)
        {
            if (!string.IsNullOrEmpty(w))
                for (int i = 0; i < n; i++)
                {
                    if (words[i] == w[0])
                    {
                        w = Convert.ToString(words[i + 1]);
                        b = i + 1;
                        break;
                    }

                }
            else {
                w = Convert.ToString(words[0]);
                b = 0;
            }

            for (int i = 0; i < n; i++)
            {
                Group g = new Group();
                g.SchoolId = 1;
                g.Letter = w;
                g.Year = year;
                context.Groups.Add(g);
                w = Convert.ToString(words[b + 1]);
            }
            context.SaveChanges();
            
        }

        internal static List<string> GetLetters(Context c, int year)
        {
            if (c == null || c.Groups == null)
                return new List<string>();
            return (from g in c.Groups where g.Year == year select g.Letter).ToList<string>();
        }
    }
}
