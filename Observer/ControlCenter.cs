using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
   public abstract  class ControlCenter
    {
       protected List<Observer> players = new List<Observer>();

       protected string teamname { get; set; }

       public void join(Observer ob)
       {
           Console.WriteLine(ob.name + " add to " + teamname);
           players.Add(ob);
       }

       public void quit(Observer ob)
       {
           Console.WriteLine(ob.name + " quit to " + teamname);
           players.Remove(ob);
       }

       public abstract void notifyObserver(string name );
    }
}
