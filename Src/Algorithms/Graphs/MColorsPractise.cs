using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class MColorsPractise : IGraph
    {
        private int _vertices;

        private int[][] _edges;

        public MColorsPractise(int vertices)
        {
            Init(vertices);
        }
        public void AddUndirectedEdge(int @from, int to)
        {
            _edges[from][to] = _edges[to][from] = 1;
        }

        public bool IsColorable(int mColors)
        {
            int[] colors = new int[_vertices];
            colors[0] = 1;
            if (ColorUtil(1, mColors, colors))
            {
                Console.WriteLine($"Graph can be colored with {mColors}");
                return true;
            }
            Console.WriteLine($"Graph cannot be colored with {mColors}");
            return false;
        }

        private bool ColorUtil(int vertex, int m, int[] colors)
        {
            if (vertex == _vertices)
            {
                return true;
            }

            for (int c = 1; c <= m; c++)
            {
                if (IsSafe(vertex, c, colors))
                {
                    colors[vertex] = c;
                    if (ColorUtil(vertex + 1, m, colors))
                        return true;
                    colors[vertex] = 0;
                }
            }

            return false;
        }

        private bool IsSafe(int vertex, int c, int[] colors)
        {
            for (int i = 0; i < _vertices; i++)
            {
                if (_edges[vertex][i] == 1 && colors[i] == c) return false;
            }

            return true;
        }

        private void Init(int vertices)
        {
            _vertices = vertices;
            _edges = new int[vertices][];
            for (int i = 0; i < vertices; i++)
            {
                _edges[i] = new int[vertices];
            }
        }


    }
}
