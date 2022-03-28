using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    abstract class Buyer : Client
    {
        public Buyer(string FirstName, string LastName) : base(FirstName, LastName)
        {

        }
        public abstract void PaymentMethod();
    }
}
