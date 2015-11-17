using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class ConcreteControlCenter : ControlCenter
    {
        public ConcreteControlCenter(string name )
        {
            Console.WriteLine("Team:"+name);
            base.teamname = name;
        }

        public override void notifyObserver(string name)
        {
            Console.WriteLine(name + " notifyObserver");

            foreach (var item in players)
            {
                if (item.name!=name)
                {
                    item.help();
                }
            }
        }
    }
}
