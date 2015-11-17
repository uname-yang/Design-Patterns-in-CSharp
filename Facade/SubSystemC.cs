using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class SubSystemC
    {
        public void Write(string text)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(text);
        }
    }
}
