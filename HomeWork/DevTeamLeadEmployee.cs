using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class DevTeamLeadEmployee : DevEmployee, IReviewer, IWriter, ITaskAssigner
    {
        public DevTeamLeadEmployee(string firstname, string lastname, int taxid) : base(firstname, lastname, taxid) { }

        public string AssignTasks()
        {
            return "Task is assigned";
        }
    }
}
