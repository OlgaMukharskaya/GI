using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class QAAutomationEmployee : Employee, IWriter, IReviewer
    {
        public QAAutomationEmployee(string firstname, string lastname, int taxid) : base(firstname, lastname, taxid) { }

        public void WriteCode()
        {
            Console.WriteLine("The QA-Automation Engineer can Wirte Code: {0} {1} ", FirstName, LastName); 
        }

        public void ReviewCode()
        {
            Console.WriteLine("The QA-Automation Engineer can Review Code: {0} {1} ", FirstName, LastName);
        }

    }
}
