using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("代理模式：给某一个对象提供一个代理或占位符，并由代理对象来控制对原对象的访问。");
            ISearcher searcher = new ProxySearcher();
            Console.WriteLine(searcher.DoSearch("yuyang","You are ?"));
            Console.ReadLine();
        }
    }
}
