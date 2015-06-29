using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public abstract class Abstraction
    {
        protected Impementor imp;

        public void setImp(Impementor imp)
        {
            this.imp = imp;
        }

        public abstract void parseFile(string filename);
    }
}
