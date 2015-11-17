using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Facade
    {
        private SubSystemA reader;
        private SubSystemB doit;
        private SubSystemC writer;

        public Facade()
        {
            reader = new SubSystemA();
            doit = new SubSystemB();
            writer = new SubSystemC();
        }

        public void FileDo(string src)
        {
            string a = reader.Read(src);
            string b = doit.Encrypt(a);
            writer.Write(b);
        }
    }
}
