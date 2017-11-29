using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class MSTKruskals
    {
        class WEdge
        {
            public int From;
            public int To;
            public int Weight;
        }

        class WeightComparer : IComparer<WEdge>
        {
            public int Compare(WEdge x, WEdge y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return y.Weight;
                if (y == null) return x.Weight;
                return x.Weight - y.Weight;
            }
        }

        class FromComparer : IComparer<WEdge>
        {
            public int Compare(WEdge x, WEdge y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return y.From;
                if (y == null) return x.From;
                if (x.From == y.From) return x.To - y.To;
                return x.From - y.From;
            }
        }

        int v;
        List<WEdge> edges;

        public MSTKruskals(int size)
        {
            v = size;
            edges = new List<WEdge>();
        }

        public void AddEdge(int src, int dest, int weight)
        {
            edges.Add(new WEdge {From = src, To = dest, Weight = weight });
        }

        public void Get()
        {
            edges.Sort(new WeightComparer());

            WEdge[] result = new WEdge[v - 1];

            int[] rep = new int[v];
            int idx = 0;
            for (int i = 0; i < v; i++) rep[i] = -1;

            foreach(WEdge edge in edges)
            {
                int rf = FindRep(edge.From, rep);
                int rt = FindRep(edge.To, rep);

                if(rf != rt)
                {
                    result[idx++] = edge;
                    Union(edge.From, edge.To, rep);
                }
            }
            Console.WriteLine("Kruskals MST:");
            int weight = 0;

            Array.Sort(result, new FromComparer());
            foreach(WEdge edge in result)
            {
                Console.WriteLine("{0} -> {1} ({2}) ", edge.From, edge.To, edge.Weight);
                weight += edge.Weight;
            }
            Console.WriteLine("Total Weight : {0}", weight);
        }

        private int FindRep(int vx, int[] rep)
        {
            if (rep[vx] == -1) return vx;
            return FindRep(rep[vx], rep);
        }

        private void Union(int s, int d, int[] rep)
        {
            int sRep = FindRep(s, rep);
            int dRep = FindRep(d, rep);

            rep[sRep] = dRep; 
        }
    }
}
