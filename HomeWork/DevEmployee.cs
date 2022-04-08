using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class DevEmployee : Employee, IWriter, IReviewer
    {
        public DevEmployee(string firstname, string lastname, int taxid) : base(firstname, lastname, taxid) { }


        public void ReviewCode()
        {
            Console.WriteLine("The Developer can Review Code: {0} {1} ", FirstName, LastName);
        }

        public void WriteCode()
        {
            Console.WriteLine("The Developer can Write Code: {0} {1} ", FirstName, LastName);
        }


    }
}
