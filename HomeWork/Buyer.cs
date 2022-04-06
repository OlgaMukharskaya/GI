using System;

namespace HomeWork
{
    abstract class Buyer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Buyer(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public abstract void PaymentMethod();
    }
}
