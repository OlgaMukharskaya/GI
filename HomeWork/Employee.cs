using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TaxID { get; set; }
        public Employee(string firstname, string lastname, int taxid)

        {
            FirstName = firstname;
            LastName = lastname;
            TaxID = taxid;
        }
    }
}
