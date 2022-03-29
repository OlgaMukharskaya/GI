using System;

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



            foreach (Employee employee in ISSoft.Employees)
            {
                if (employee is ITaskAssigner)
                {
                    Console.WriteLine($"The emplyee can Assign Tasks: {employee.FirstName} {employee.LastName} (TaxID: {employee.TaxID})");
                }
            }

            foreach (Employee employee in ISSoft.Employees)
            {
                if (employee is IWriter)
                {
                    Console.WriteLine($"The emplyee can Write Code: {employee.FirstName} {employee.LastName} (TaxID: {employee.TaxID})");
                }
            }

            foreach (Employee employee in ISSoft.Employees)
            {
                if (employee is IReviewer)
                {
                    Console.WriteLine($"The emplyee can Review Code: {employee.FirstName} {employee.LastName} (TaxID: {employee.TaxID})");
                }
            }

           /* Разработать классы для программы управления ИТ офисом.
            1.Класс Office содержит список Employee, сотрудники бывают QAEmployee, DevEmployee, BAEmployee, PMEmployee, QAAutomationEmployee, QAAutomationTeamLead, DevTEamLead, QATeamLead. 
            2.Ассайнить таски могут тимлиды и PMEmployee, 
            делать ревью кода тимлиды QAAutomation и Dev.
            3.Писать код могут Dev, QAAuto и их тимлиды. 
            4.Заполнить список Employee специалистами разного профиля, и вывести подробную информацию о специлистах, которые могут
            4.1 писать код
            4.2 ассайнить таски
            4.3 делать ревью кода
           */


        }
    }
}
