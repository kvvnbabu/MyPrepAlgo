using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class MinSpannigTreePrims : GraphAdjMatrixWeighted
    {
        public MinSpannigTreePrims(int size) : base(size)
        {
        }


        public void Get()
        {
            bool[] include = new bool[n];
            int[] dist = new int[n];
            int[] parent = new int[n];

            for (int i = 0; i < n; i++)
            {
                dist[i] = Int32.MaxValue;
            }

            dist[0] = 0;
            parent[0] = -1;

            for (int count = 0; count < n - 1; count++)
            {
                int nearest = GetNearest(dist, include);
                include[nearest] = true;

                for(int tvx = 0; tvx < n; tvx++)
                {
                    if (edges[nearest][tvx] != 0 && !include[tvx] && dist[tvx] > edges[nearest][tvx])
                    {
                        parent[tvx] = nearest;
                        dist[tvx] = edges[nearest][tvx];
                    }
                }
            }

            Print(parent);
            

        }

        private void Print(int[] parent)
        {
            int weight = 0;
            Console.WriteLine("Prims MST");
            for(int i = 1; i< n; i++)
            {
                Console.WriteLine("{0} -> {1} ({2})", parent[i], i, edges[i][parent[i]]);
                weight += edges[i][parent[i]];
            }
            Console.WriteLine("Total Weight : {0}", weight);
        }

        private int GetNearest(int[] dist, bool[] included)
        {
            int res = -1;
            int min = Int32.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (!included[i] && dist[i] < min)
                {
                    min = dist[i];
                    res = i;
                }
            }
            return res;
        }
    }
}
