﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class ClassGeneretionLogic
    {
        Context context;
        internal void AddClass ( int n)
        {
            for(int i = 0; i < n; i++)
            {
                Group g = new Group();

              context.Groups.Add(g);
            }
            context.SaveChanges();
            
        }
    }
}
