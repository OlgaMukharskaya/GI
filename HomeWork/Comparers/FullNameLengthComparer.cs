using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Comparers
{
    class FullNameLengthComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            int xLenght = x.FirstName.Length + x.LastName.Length;
            int yLenght = y.FirstName.Length + y.LastName.Length;


            if (xLenght > yLenght)
            {
                return 1;
            }

            else if (xLenght == yLenght)
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