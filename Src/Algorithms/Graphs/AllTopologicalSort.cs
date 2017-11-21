using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class AllTopologicalSort : GraphAdjListUnWeighted
    {
        public AllTopologicalSort(int size) : base(size)
        {

        }

        public void GetAllTopologicalSorts()
        {
            bool[] visited = new bool[n];
            int[] inDegree = GetInDegree();

            AllTopological(new List<int>(), inDegree, visited);
        }

        private void AllTopological(List<int> res, int[] inDegree, bool[] visited)
        {
            //var res = new List<int>();
            bool allTopologyTraversed = false;
            for (int vx = 0; vx < n; vx++)
            {
                if (inDegree[vx] == 0 && !visited[vx])
                {
                    res.Add(vx);
                    //Console.Write("{0} -> ", vx);
                    visited[vx] = true;
                    foreach (int tVx in edges[vx])
                    {
                        --inDegree[tVx];
                    }

                    AllTopological(res, inDegree, visited);

                    res.RemoveAt(res.Count - 1);
                    visited[vx] = false;
                    foreach (int tVx in edges[vx])
                    {
                        ++inDegree[tVx];
                    }
                    allTopologyTraversed = true;
                }
            }
            if (!allTopologyTraversed)
            {
                Console.WriteLine(String.Join(" -> ", res));
            }

        }

        private int[] GetInDegree()
        {
            int[] res = new int[n];

            for (int vx = 0; vx < n; vx++)
            {
                foreach (int tVx in edges[vx])
                {
                    res[tVx]++;
                }
            }

            return res;
        }
    }
}
