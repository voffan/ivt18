using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class TransitionManagementLogic
    {
        internal object GetGroupList(Context context)
        {
            var groupList = context.Groups
                .Select(g => new { Id = g.GroupId, ClassName = g.Year + " " + g.Letter })
                .OrderBy(g => g.ClassName).ToList();
            return groupList;
        }
    }
}
