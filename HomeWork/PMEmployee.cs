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

        public string AssignTasks()
        {
            return "Task is assigned by MP";
        }

        public string ReviewCode()
        {
            return "PMs can't review code";
        }
    }
}
