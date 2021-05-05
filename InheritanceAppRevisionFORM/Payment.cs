using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAppRevisionFORM
{
    //parent class
    public abstract class Payment
    {
        public Payment(int orderID, DateTime date, double amount, string reference)
        {
            OrderID = orderID;
            Date = date;
            Amount = amount;
            Reference = reference;
        }

        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Reference { get; set; }

    }
}
