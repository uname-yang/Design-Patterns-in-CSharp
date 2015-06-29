using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("适配器模式：将于个接口转换成客户希望的另一个接口，使接口不兼容的那些类可以一起工作，其别名为包装器。适配器模式既可以作为类结构模式，也可以作为对象结构模式。");

            int[] score = { 85, 66, 99, 445, 45, 18, 48749, 4645, 1, 1456, 4, 164, 747 };
            ITarget tar=new Adapter();
            tar.sort(score);
            foreach (var item in score)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();

        }
    }
}
