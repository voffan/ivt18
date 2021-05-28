using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class AddSubjectLogic
    {
        Subject _subject;

        public void setSubject(Subject subject)
        {
            _subject = subject;
        }

        public void createSubject()
        {
            _subject = new Subject();
        }

        public void setSubjectName(Context context, string name)
        {
            name.Replace(" ", string.Empty);

            if (name != "")
            {
                _subject.Name = name;
            }
        }

        public Subject GetSubject()
        {
            return _subject;
        }
    }
}
