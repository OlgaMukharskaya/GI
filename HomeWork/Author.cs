using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public int AuthorID { get; set; }

        public Author(string firstname, string lastname, int dob, int authid)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dob;
            AuthorID = authid;
        }
    }
}
