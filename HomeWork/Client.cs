using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Client
    {
        string FirstName;
        string LastName;

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public Client(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
