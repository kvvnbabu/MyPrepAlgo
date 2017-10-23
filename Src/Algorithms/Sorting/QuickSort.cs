using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class QuickSort : ISort
    {
        public void Sort(int[] elements)
        {
            // considering pivote as first element
            QSort(elements, 0, elements.Length - 1);
        }

        private void QSort(int[] elements, int s, int e)
        {
            //Console.WriteLine($"{String.Join(", ", elements)} s:{s} e:{e}");
            if (s >= e) return;
            int p = Partition(elements, s, e);
            QSort(elements, s, p - 1);
            QSort(elements, p + 1, e);
        }

        private int Partition(int[] elements, int s, int e)
        {
            int v = elements[s];
            int i = s;
            int j = e + 1;
            do
            {
                //Console.WriteLine($"{String.Join(", ", elements)}   i:{i}  j:{j} v:{v}");
                do
                {
                    i++;
                } while (i < elements.Length && elements[i] < v);

                do
                {
                    j--;
                } while (j >= 0 && elements[j] > v );

                if (i < j) Util.Swap(elements, i, j);

            } while (i < j);
            //Console.WriteLine($"{String.Join(", ", elements)}   i:{i}  j:{j} v:{v} pivot:{j}");
            elements[s] = elements[j];
            elements[j] = v;
            //Console.WriteLine($"{String.Join(", ", elements)}   i:{i}  j:{j} v:{v} pivot:{j}");
            return j;
        }
    }
}
