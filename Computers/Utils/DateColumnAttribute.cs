using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Utils
{
    public class DateColumnAttribute : ColumnAttribute
    {
        public DateColumnAttribute()
        {
            TypeName = "date";
        }
    }
}
