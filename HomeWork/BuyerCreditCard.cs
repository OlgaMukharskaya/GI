using System;

namespace HomeWork
{
    class BuyerCreditCard : Buyer
    {
        public BuyerCreditCard(string firstname, string lastname) : base(firstname, lastname)
        {
        }

        public override void PaymentMethod()
        {
            Console.WriteLine("{0} {1} paid by CreditCard", this.FirstName, this.LastName);
        }
    }
}

