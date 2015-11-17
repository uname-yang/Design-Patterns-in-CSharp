using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public class PurchaseRequest
    {
        private double amount;
        private int numbers;
        private string purpose;

        public PurchaseRequest(double amount, int numbers, string purpose)
        {
            this.amount=amount;
            this.numbers=numbers;
            this.purpose=purpose;
        }

        public void setAmount(double amount)
        {
            this.amount=amount;
        }
        public double getAmount()
        {
            return this.amount;
        }

        public void setNumbers(int numbers)
        {
            this.numbers = numbers;
        }
        public int getNumbers()
        {
            return this.numbers;
        }

        public void setPurpose(string purpose)
        {
            this.purpose = purpose;
        }
        public string getPurpose()
        {
            return this.purpose;
        }

    }
}
