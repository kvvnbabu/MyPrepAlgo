using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Common
{
    public static class Util
    {
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
