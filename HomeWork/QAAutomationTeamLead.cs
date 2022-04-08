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

        public void AssignTasks()
        {
            Console.WriteLine("The QA-Automation Team Lead can Assign Tasks: {0} {1} ", FirstName, LastName);
        }

    }
}
