using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class BubbleSort : ISort
    {
        public void Sort(int[] elements)
        {
            // Keep checking the immediate elements

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length - 1; j++)
                {
                    if (elements[j + 1] < elements[j])
                    {
                        Util.Swap(elements, j, j + 1);
                    }
                }
            }
        }
    }
}
