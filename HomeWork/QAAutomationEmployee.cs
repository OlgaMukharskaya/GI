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

        public string WriteCode()
        {
            return "Code is witten";
        }

        public string ReviewCode()
        {
            return "Code is reviewed";
        }

    }
}
