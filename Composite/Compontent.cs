using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public interface  ICompontent  //or abstract
    {
         void add(ICompontent one);
         void remove(ICompontent one);
         ICompontent getchild(int i);
        void function();
    }
}
