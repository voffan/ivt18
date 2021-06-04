using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class AddRoleLogic
    {
        public List<dynamic> GetRoleList(Context context, string searchTerm)
        {
            String[] searchTerms = searchTerm.Trim().Split(' ');

            var positionList = (from usr in context.Positions
                               select new
                               {
                                   usr.PositionId,
                                   Название = usr.Name
                               });

            foreach (string term in searchTerms)
            {
                var positions = (from usr in positionList
                                where usr.Название.Contains(term)
                                select new
                                {
                                    usr.PositionId,
                                    usr.Название
                                });

                positionList = positions;
            }


            return positionList.ToList<dynamic>();
        }

        internal void DeleteRole(Context context, int positionId)
        {
            Position positionToDelete = context.Positions.Where(x => x.PositionId == positionId).Select(x => x).Single();
            context.Positions.Remove(positionToDelete);
            context.SaveChanges();
        }

        internal Position GetPositionById(Context context, int positionId)
        {
            Position positionToReturn = (from subj in context.Positions
                                       where subj.PositionId == positionId
                                       select subj).Single();

            return positionToReturn;
        }
    }
}
