using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Comparers
{
    class TaxIDComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.TaxID > y.TaxID)
            {
                return 1;
            }

            else if (x.TaxID == y.TaxID)
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
