using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Leaf1:ICompontent
    {
        private string name;

        public Leaf1(string name)
        {
            this.name = name;
        }

        public void add(ICompontent ob)
        {
            Console.WriteLine("null function"); 
        }

        public void remove(ICompontent ob)
        {
            Console.WriteLine("null function");
        }

        public ICompontent getchild(int ob)
        {
            Console.WriteLine("null function");
            return null;
        }

        public void function()
        {
            Console.WriteLine("Leaf1-"+name);
        }
    }

    public class Leaf2 : ICompontent
    {
        private string name;

        public Leaf2(string name)
        {
            this.name = name;
        }

        public void add(ICompontent ob)
        {
            Console.WriteLine("null function");
        }

        public void remove(ICompontent ob)
        {
            Console.WriteLine("null function");
        }

        public ICompontent getchild(int ob)
        {
            Console.WriteLine("null function");
            return null;
        }

        public void function()
        {
            Console.WriteLine("Leaf2-" + name);
        }
    }
}
