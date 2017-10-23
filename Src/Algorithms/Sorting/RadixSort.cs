using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class RadixSort : ISort
    {
        public void Sort(int[] elements)
        {
            if (elements == null || elements.Length == 0) return;
            //radixsort(elements, elements.Length);
            int max = GetMax(elements);
            int digitPlace = 1;

            while (max / digitPlace > 0)
            {
                CountSort(elements, digitPlace);
                digitPlace *= 10;
            }
        }

       

        private void CountSort(int[] elements, int digitPlace)
        {
            int singleDigitsCount = 10;
            int[] count = new int[singleDigitsCount];
            for (int i = 0; i < elements.Length; i++)
            {
                count[GetRadix(elements[i], digitPlace)]++;
            }

            for (int i = 1; i < singleDigitsCount; i++)
            {
                count[i] += count[i - 1];
            }

            int[] result = new int[elements.Length];

            for (int i = elements.Length-1; i >= 0; i--)
            {
                int e = elements[i];
                result[count[GetRadix(e, digitPlace)] - 1] = e;
                count[GetRadix(e, digitPlace)]--;
            }
            Copy(result, elements);
            //Console.WriteLine($"{String.Join(", ", elements)}");
        }
        
        private void Copy(int[] source, int[] dest)
        {
            for (int i = 0; i < source.Length; i++)
            {
                dest[i] = source[i];
            }
        }

        private int GetRadix(int actulaNumber, int digit)
        {
            return (actulaNumber / digit) % 10;
        }

        private int GetMax(int[] elements)
        {
            int max = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                    max = elements[i];
            }
            return max;
        }

        #region geeksforgeeks
        //static int getMax(int[] arr, int n)
        //{
        //    int mx = arr[0];
        //    for (int i = 1; i < n; i++)
        //        if (arr[i] > mx)
        //            mx = arr[i];
        //    return mx;
        //}

        //// A function to do counting sort of arr[] according to
        //// the digit represented by exp.
        //static void countSort(int[] arr, int n, int exp)
        //{
        //    int[] output = new int[n]; // output array
        //    int i;
        //    int[] count = new int[10];

        //    // Store count of occurrences in count[]
        //    for (i = 0; i < n; i++)
        //        count[(arr[i] / exp) % 10]++;

        //    // Change count[i] so that count[i] now contains
        //    // actual position of this digit in output[]
        //    for (i = 1; i < 10; i++)
        //        count[i] += count[i - 1];

        //    // Build the output array
        //    for (i = n - 1; i >= 0; i--)
        //    {
        //        output[count[(arr[i] / exp) % 10] - 1] = arr[i];
        //        count[(arr[i] / exp) % 10]--;
        //    }

        //    // Copy the output array to arr[], so that arr[] now
        //    // contains sorted numbers according to curent digit
        //    for (i = 0; i < n; i++)
        //        arr[i] = output[i];
        //}

        //// The main function to that sorts arr[] of size n using
        //// Radix Sort
        //static void radixsort(int[] arr, int n)
        //{
        //    // Find the maximum number to know number of digits
        //    int m = getMax(arr, n);

        //    // Do counting sort for every digit. Note that instead
        //    // of passing digit number, exp is passed. exp is 10^i
        //    // where i is current digit number
        //    for (int exp = 1; m / exp > 0; exp *= 10)
        //        countSort(arr, n, exp);
        //}
        #endregion
    }
}
