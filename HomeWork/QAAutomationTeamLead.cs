using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class QAAutomationTeamLead : QAAutomationEmployee, IReviewer, IWriter, ITaskAssigner
    {
        public QAAutomationTeamLead(string firstname, string lastname, int taxid) : base(firstname, lastname, taxid) { }

        public string AssignTasks()
        {
            return "Task is assigned";
        }

    }
}
