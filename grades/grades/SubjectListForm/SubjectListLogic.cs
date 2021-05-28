using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class SubjectListLogic
    {
        public List<dynamic> GetSubjectList(Context context, string searchTerm)
        {
            String[] searchTerms = searchTerm.Trim().Split(' ');

            var subjectList = (from usr in context.Subjects
                               select new
                               {
                                   usr.SubjectId,
                                   Название = usr.Name
                               });

            foreach (string term in searchTerms)
            {
                var subjects = (from usr in subjectList
                               where usr.Название.Contains(term)
                               select new
                               {
                                   usr.SubjectId,
                                   usr.Название
                               });

                subjectList = subjects;
            }


            return subjectList.ToList<dynamic>();
        }

        internal void DeleteSubject(Context context, int subjectId)
        {
            Subject subjectToDelete = context.Subjects.Where(x => x.SubjectId == subjectId).Select(x => x).Single();
            context.Subjects.Remove(subjectToDelete);
            context.SaveChanges();
        }

        internal Subject GetSubjectById(Context context, int subjectId)
        {
            Subject subjectToReturn = (from subj in context.Subjects
                                       where subj.SubjectId == subjectId
                                       select subj).Single();

            return subjectToReturn;
        }
    }
}