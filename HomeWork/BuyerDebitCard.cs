using System;

namespace HomeWork
{
    class BuyerDebitCard : Buyer
    {
        public BuyerDebitCard(string firstname, string lastname) : base(firstname, lastname)
        {
        }

        public override void PaymentMethod()
        {
            Console.WriteLine("{0} {1} paid by DebitCard", this.FirstName, this.LastName);
        }
    }
}

