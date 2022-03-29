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
