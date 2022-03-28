using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class BuyerCash : Buyer
    {
        public BuyerCash(string firstname, string lastname) : base(firstname, lastname)
        {

        }
        public override void PaymentMethod()
        {
            Console.WriteLine("{0} {1} paid in Cash", GetFirstName(), GetLastName());
        }
    }
}
