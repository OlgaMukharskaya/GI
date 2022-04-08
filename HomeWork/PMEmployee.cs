using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class PMEmployee : Employee, ITaskAssigner, IReviewer
    {
        public PMEmployee(string firstname, string lastname, int taxid) : base(firstname, lastname, taxid) { }

        public void AssignTasks()
        {
            Console.WriteLine("the Project Manager can Assign Tasks: {0} {1} ", FirstName, LastName);
        }

        public void ReviewCode()
        {
            Console.WriteLine("The Project Manage can Review Code: {0} {1} ", FirstName, LastName);
        }
    }
}
