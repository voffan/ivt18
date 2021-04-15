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
        // word = 'A';
        private Context context;
     /*   public List<dynamic> GetWords(Context context) {
            var classwords = (from usr in context.Groups
                              select new
                              {
                                  usr.GroupId,usr.Year,
                                  Буква = usr.Letter
                              });

            foreach (char term in words)
            {
                var grops = (from usr in classwords
                                where 
                                select new
                                {
                                    usr.GroupId,
                                    usr.Буква
                                });

            }
        }*/
        internal void AddClass (Context context, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Group g = new Group();
             //   var ClassLetter = (from contex.G in ClassLetter );
                context.Groups.Add(g);
            }
            context.SaveChanges();
            
        }

    }
}
