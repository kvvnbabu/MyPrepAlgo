using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class MergeSort : ISort
    {
        public void Sort(int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                Console.Write("Sort not supported!");//throw new InvalidOperationException();
                return;
            }
            int[] result = Merge(elements);
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = result[i];
            }
           // Console.WriteLine("Result: " + String.Join(", ", elements));
        }

        int[] Merge(int[] elements)
        {
            //Console.WriteLine("\t" + String.Join(", ", elements));
            if (elements.Length == 1) return elements;
            int mergePoint = elements.Length / 2;
            int[] left = Merge(getSubArray(elements, 0, mergePoint));
            int[] right = Merge(getSubArray(elements, mergePoint, elements.Length));
            int[] resultArray = new int[elements.Length];
            int index = 0;
            int lIndex = 0;
            int rIndex = 0;
            while (index < elements.Length)
            {
                if (lIndex >= left.Length)
                    resultArray[index++] = right[rIndex++];
                else if (rIndex >= right.Length)
                    resultArray[index++] = left[lIndex++];
                else if (left[lIndex] < right[rIndex])
                    resultArray[index++] = left[lIndex++];
                else
                    resultArray[index++] = right[rIndex++];
            }
            return resultArray;
        }
        int[] getSubArray(int[] elements, int start, int end)
        {
            int[] subArray = new int[end - start];
            int index = 0;
            for (int i = start; i < end; i++)
            {
                subArray[index++] = elements[i];
            }
            return subArray;
        }

        public void _MergeSort(int[] elements)
        {
            _MergeSort(elements, 0, elements.Length - 1);
        }
        public void _MergeSort(int[] elements, int start, int end)
        {
            if (start == end) return;
            int mid = (end - start) / 2;
            _MergeSort(elements, start, mid);
            _MergeSort(elements, mid + 1, end);

            // merge both the sorted arrays
            int[] result = new int[end - start + 1];
            int l = start, r = mid + 1;

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;

            }
        }



    }
}
