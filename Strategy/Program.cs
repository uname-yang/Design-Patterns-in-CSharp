using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("策略模式：定义一系列算法类，将每一个算法封装起来，并让他们可以相互替换，策略模式让算法独立于使用它的客户而变化，也称为政策模式。策略模式是一种对象行为模式。");

            DiscountContext context = new DiscountContext();

            double price = 90;
            double discountprice;
            Console.WriteLine(price);

            context.setPrice(price);

            IDisCount discount = new StudentDiscount();

            context.setDiscount(discount);

            discountprice = context.getprice();
            Console.WriteLine(discountprice);
            Console.ReadLine();
        }
    }
}
