using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class ITOffice
    {
        List<Employee> _employees;

        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }

        }


        public ITOffice()
        {
            _employees = new List<Employee>();
        }
    }
}
