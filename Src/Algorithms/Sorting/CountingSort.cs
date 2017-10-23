using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class CountingSort : ISort
    {
        public void Sort(int[] elements)
        {
            if (elements == null || elements.Length == 0) return;// throw new Exception("Sort not supported");
            int max = elements[0], min = max;
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                    max = elements[i];
                if (elements[i] < min)
                    min = elements[i];
            }

            int parity = 0;
            if (min < 0) parity = 0 - min;

            int[] indexA = new int[max + parity + 1];
            //for (int i = 0; i < indexA.Length; i++)
            //{
            //    indexA[i] = 0;
            //}

            for (int i = 0; i < elements.Length; i++)
            {
                indexA[elements[i] + parity]++;
            }

            for (int i = 1; i < indexA.Length; i++)
            {
                indexA[i] += indexA[i - 1];
            }

            int[] result = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                int element = elements[i];
                int index = indexA[element + parity] - 1;
                FillItem(result, element, index);
            }

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = result[i];
            }
        }

        private void FillItem(int[] array, int element, int index)
        {
            while (array[index] == element && index != 0)
            {
                index--;
            }
            array[index] = element;
        }
    }
}
