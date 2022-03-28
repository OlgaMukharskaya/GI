using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Buyer Buyer1 = new BuyerDebitCard("Sondra", "Finchley");
            Buyer Buyer2 = new BuyerCreditCard("Hortense", "Briggs");
            Buyer Buyer3 = new BuyerCash("Samuel", "Griffiths");
            Buyer Buyer4 = new BuyerDebitCard("Gilbert", "Griffiths");
            Buyer Buyer5 = new BuyerCreditCard("Roberta", "Alden");
            Client[] Buyers = { Buyer1, Buyer2, Buyer3, Buyer4, Buyer5 };

            foreach (Buyer item in Buyers)
            {
                item.PaymentMethod();
            }
        }
/*
1. Создать абстрактный класс Покупатель, у которого есть абстрактный метод Оплатить.
2. Создать наследников от этого класса- Покупатель за наличные, покупатель с дебетовой картой, и покупатель с кредитной картой.
3. Реализовать в них метод Оплатить (пусть просто выводит на экран способ оплаты)
4. Создать массив из 5 покупателей разного типа, и в цикле вызвать метод Оплатить.Проверить что каждый оплатил своим способом (сообщения на экране)
*/
    }
}
