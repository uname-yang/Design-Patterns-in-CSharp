using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("单例模式：确保某一个类只有一个实例，而且自行实例化并向整个系统提供这个实例，这个类称为单例类，它提供全局访问的方法。单例模式是一种对象创建型模式");
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            Singleton s3 = Singleton.Instance();

            if (s1 == s2 && s1 == s3 && s2 == s3)
            {
                Console.WriteLine("Same");
            }
            s1.addlist("s1");
            s2.addlist("s2");
            s3.addlist("s3");

            for (int i = 0; i < 10; i++)
            {
                string s = s1.getlistone();
                Console.WriteLine(s);
            }
                Console.ReadKey();
        }
    }

    public class Singleton
    {
        private static Singleton instance = null;

        private List<string> list = null;

        private Singleton()
        {
            list = new List<string>();
        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void addlist(string s)
        {
            list.Add(s);
        }

        public void removelist(string s)
        {
            list.Remove(s);
        }

        public string getlistone()
        {
            Random r = new Random();
            int i = r.Next(list.Count);
            return list[i];
        }

    }
}
