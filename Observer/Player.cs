using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Player:Observer
    {
        public string name { get; set; }

        public void help()
        {
            Console.WriteLine(name+" help you");
        }

        public void beAttacked(ControlCenter acc)
        {
             Console.WriteLine(name+" beAttacked");
             acc.notifyObserver(name);
        }
    }
}
