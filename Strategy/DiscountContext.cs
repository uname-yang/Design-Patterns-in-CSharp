using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class DiscountContext
    {
        private double price;
        private IDisCount dicount;

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setDiscount(IDisCount discount)
        {
            this.dicount = discount;
        }

        public double getprice()
        {
            return this.dicount.calculate(this.price);
        }
    }
}
