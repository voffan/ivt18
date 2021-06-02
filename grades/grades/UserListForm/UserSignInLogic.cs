using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
    class UserSignInLogic
    {

        internal List<dynamic> GetPeopleList(Context context,string login, string password)
        {

            var groups = context.Persons 
                .Where(g => g.Login == login && g.Password == password)
                .Select(g => new { Id = g.Login, Name = g.Password})
                .ToList<dynamic>();

            if (groups == null)
                return null;
            else
                return groups;
        }
    }
}
