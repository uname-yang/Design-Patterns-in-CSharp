using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
public class Composite1:ICompontent
    {
        private string name;
        private List<ICompontent> list = new List<ICompontent>();

        public Composite1(string name)
        {
            this.name = name;
        }

        public void add(ICompontent ob)
        {
            list.Add(ob);
        }

        public void remove(ICompontent ob)
        {
            list.Remove(ob);
        }

        public ICompontent getchild(int ob)
        {
            return list[ob];
        }

        public void function()
        {
            Console.WriteLine("Composite1-" + name);
            foreach (var item in list)
            {
                item.function();
            }
        }
    }
}
