using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAppRevisionFORM
{
    public class CardPayment : Payment
    {
        public CardPayment(int orderID, DateTime date, double amount, string reference,
            string holder, string lastHour, string provider) : base(orderID, date, amount, reference)
        {

            Holder = holder;
            LastHour = lastHour;
            Provider = provider;
        }

        public string Holder { get; set; }
        public string LastHour { get; set; }
        public string Provider { get; set; }


    }
}
