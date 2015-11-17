using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public interface ITarget
    {
        int[] sort(int[] array);
        //int search(int[] array, int key);
    }
}
