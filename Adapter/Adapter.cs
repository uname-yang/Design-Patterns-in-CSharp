using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class Adapter:ITarget
    {
        private QuickSort sortOb;
        public Adapter()
        {
            sortOb = new QuickSort();
        }

        public int[] sort(int[] array)
        {
            return sortOb.quicksort(array);
        }

    }
}
