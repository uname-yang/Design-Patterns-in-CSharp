using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class QuickSort
    {
        public int[] quicksort(int[] array)
        {
           // sort(array,0,array.Length-1);
            return array;
        }

        public void sort(int[] array, int p, int r)
        {
            int q = 0;
            if (q < r)
            {
                q = partiton(array, p, r);
                sort(array, p, q - 1);
                sort(array, q + 1, r);

            }

        }

        public int partiton(int[] array, int p, int r)
        {
            int x = array[r];
            int j = p - 1;
            for (int i = p; i < r-1; i++)
            {
                if (array[i] <= x)
                {
                    j++;
                    swap(array, j, i);
                }
            }
            swap(array, j + 1, r);
            return j + 1;
        }

        public void swap(int[] a, int i, int j)
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
    }
}
