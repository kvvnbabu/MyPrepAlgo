using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class PathWithKLength
    {
        int v;
        List<Tuple<int, int>>[] edges;

        public PathWithKLength(int vertices)
        {
            v = vertices;
            edges = new List<Tuple<int, int>>[v];
            for (int i = 0; i < v; i++) edges[i] = new List<Tuple<int, int>>();
        }

        public void AddEdge(int f, int t, int w)
        {
            edges[f].Add(new Tuple<int, int>(t, w));
            edges[t].Add(new Tuple<int, int>(f, w));
        }

        public bool HasPathWithLength(int src, int k)
        {
            bool[] path = new bool[v];
            path[src] = true;

            return HasPathWithLength(src, k, path);

        }

        private bool HasPathWithLength(int s, int k, bool[] path)
        {
            if (k <= 0) return true;
            foreach(Tuple<int, int> toVx in edges[s])
            {
                int to = toVx.Item1;
                int w = toVx.Item2;
                if (path[to]) continue;
                if (w >= k) return true;
                path[to] = true;
                if (HasPathWithLength(to, k - w, path)) return true;
                path[to] = false;
            }
            return false;
        }
    }
}
