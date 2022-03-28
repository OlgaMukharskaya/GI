using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class BuyerCreditCard : Buyer
    {
        public BuyerCreditCard(string firstname, string lastname) : base(firstname, lastname)
        {

        }
        public override void PaymentMethod()
        {
            Console.WriteLine("{0} {1} paid by Credit Card", GetFirstName(), GetLastName());
        }
    }
}
