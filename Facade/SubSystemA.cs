using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class SubSystemA
    {
        public string Read(string filepath)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(filepath);
            return Math.Exp(filepath.Length).ToString();
        }
    }
}
