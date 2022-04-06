using System;

namespace HomeWork
{
    class BuyerCash : Buyer
    {
        public BuyerCash(string firstname, string lastname) : base(firstname, lastname)
        {
        }

        public override void PaymentMethod()
        {
            Console.WriteLine("{0} {1} paid by Cash", this.FirstName, this.LastName);
        }
    }
}

