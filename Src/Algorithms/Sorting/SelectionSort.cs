using Algorithms.Common;

namespace Algorithms.Sorting
{
    class SelectionSort : ISort
    {
        // for each position, find the element appropriate by scanning remaining elements
        public void Sort(int[] elements)
        {
            for (int i = 0; i < elements.Length - 1; i++)
            {
                int minInd = i;
                for (int j = i + 1; j<elements.Length; j++)
                {
                    if(elements[j] < elements[minInd])
                    {
                        minInd = j;
                    }
                }
                if(minInd != i)
                {
                    Util.Swap(elements, i, minInd);
                }
            }
        }
    }
}
