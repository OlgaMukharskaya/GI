using System;
using HomeWork.Comparers;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ITOffice ISSoft = new ITOffice();
            ISSoft.Employees.Add(new PMEmployee("Anabel", "Neal", 147852365));
            ISSoft.Employees.Add(new QAAutomationTeamLead("Mathias", "Guerrero", 7391547));
            ISSoft.Employees.Add(new QATeamLeadEmployee("Haven", "Smith", 637445812));
            ISSoft.Employees.Add(new DevTeamLeadEmployee("Zane", "Morrow", 654125856));
            ISSoft.Employees.Add(new DevEmployee("Mathew", "Mcconnell", 658569871));
            ISSoft.Employees.Add(new QAEmployee("Francis", "Woods", 654785236));
            ISSoft.Employees.Add(new QAAutomationEmployee("Brooke", "Roth", 658594125));
            ISSoft.Employees.Add(new BAEmployee("Ricardo", "Walter", 147852365));
            ISSoft.Employees.Add(new DevEmployee("Eli", "Clayton", 125478520));
            ISSoft.Employees.Add(new QAEmployee("Allison", "Figueroa", 658502665));
            ISSoft.Employees.Add(new QAAutomationEmployee("Deshawn", "Beck", 658501477));
            ISSoft.Employees.Add(new BAEmployee("Colt", "Davenport", 458520012));



            ISSoft.Employees.Sort(new FirstNameComparer());
            Console.WriteLine($"By First Name (ascending)");
            foreach (Employee employee in ISSoft.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, TaxID: {employee.TaxID}");
            }
            Console.WriteLine("\n");

            ISSoft.Employees.Sort(new TaxIDComparer());
            Console.WriteLine($"By Tax ID (ascending)");
            foreach (Employee employee in ISSoft.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, TaxID: {employee.TaxID}");
            }
            Console.WriteLine("\n");

            ISSoft.Employees.Sort(new FullNameLengthComparer());
            Console.WriteLine($"By Full Name Length (ascending)");
            foreach (Employee employee in ISSoft.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, TaxID: {employee.TaxID}");
            }
            Console.WriteLine("\n");

            ISSoft.Employees.Sort(new TasksAssignComparer());
            Console.WriteLine($"By task assigning");
            foreach (Employee employee in ISSoft.Employees)
            {
                Console.WriteLine($"{employee.LastName}, {employee.FirstName}");
            }

            /*
             отсортируйте и выведите в консоль сотрудников по:
            1. Имени
            2. TaxID
            3. Общей длине имени и фамилии
            4* Умению ассанить таски- ITaskAssigner сначала (их допольнительно отсортировать по фамилии), потом все остальные
             */

        }
    }
}
