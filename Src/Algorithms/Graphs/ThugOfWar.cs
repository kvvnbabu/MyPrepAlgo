using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public  class ThugOfWar
    {
        public static Tuple<int[], int[]> DevideTeams(int[] members)
        {
            int count = 0;
            int n = members.Length;
            int min = Int32.MaxValue;
            bool[] include = new bool[n];
            int size = n % 2 == 0 ? n / 2 : (n - 1) / 2;
            Tuple<int[], int[]> res = new Tuple<int[], int[]>(new int[size], new int[n - size]);
            DevideTeams(n, members, size, include, ref min, res,  ref count);
            PrintTeams(n, count, min, res);
            return res;
        }

        private static void PrintTeams(int n, int count, int diff, Tuple<int[], int[]> teams)
        {
            Console.WriteLine("{0} (in {3} iterations of size {4})\n {1} \n {2}", diff, String.Join(", ", teams.Item1), String.Join(", ", teams.Item2), n, count);
        }

        private static void DevideTeams(int n, int[] members, int size, bool[] include, ref int minDiff, Tuple<int[], int[]> result, ref int count)
        {
            if(size == 0)
            {
                int sum = 0;
                for(int i = 0; i<n; i++)
                {
                    if (include[i]) sum += members[i];
                    else sum -= members[i];
                }
                int diff = Math.Abs(sum);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    int t1 = 0, t2 = 0;
                    for(int i = 0; i < n; i++)
                    {
                        if (include[i]) result.Item1[t1++] = members[i];
                        else result.Item2[t2++] = members[i];
                    }
                }
                return;
            }
            count++;
            for(int i = 0; i < n; i++)
            {
                if(!include[i])
                {
                    include[i] = true;
                    DevideTeams(n, members, size - 1, include, ref minDiff, result, ref count);
                    include[i] = false;
                }
            }
        } 
    
    }
}
