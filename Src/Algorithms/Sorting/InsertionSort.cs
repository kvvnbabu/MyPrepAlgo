using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class InsertionSort : ISort
    {
        public void Sort(int[] elements)
        {
            if (elements == null) throw new ArgumentNullException(nameof(elements));
            int iterations = 0;
            for (int i = 1; i < elements.Length; i++)
            {
                int picked = elements[i];
                int j = i - 1;
                while (j >= 0 && elements[j] > picked)
                {
                    elements[j + 1] = elements[j];
                    j--;
                    Console.WriteLine("\t\t" + String.Join(", ", elements));
                    iterations++;
                }
                elements[j + 1] = picked;
                Console.WriteLine("\t" + String.Join(", ", elements));
                iterations++;
            }
            Console.WriteLine($"Elements: {elements.Length} and Iterations: {iterations}");
        }
    }
}
