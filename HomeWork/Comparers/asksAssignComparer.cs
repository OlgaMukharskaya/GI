using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Comparers
{
    class TasksAssignComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x is ITaskAssigner && y is ITaskAssigner)
            {
                if (x.LastName[0] > y.LastName[0])
                {
                    return 1;
                }
            }

            if (x is not ITaskAssigner && y is not ITaskAssigner)
            {
                return 0;
            }

            else
            {
                return -1;
            }

        }
    }
}