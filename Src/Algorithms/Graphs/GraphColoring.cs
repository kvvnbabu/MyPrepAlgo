using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class GraphColoring
    {
        private int _vertices;

        private int[][] _edges;

        public GraphColoring(int vertices)
        {
            this._vertices = vertices;
            _edges = new int[vertices][];
            for (int i = 0; i < vertices; i++)
            {
                _edges[i] = new int[vertices];
                for (int j = 0; j < _vertices; j++)
                    _edges[i][j] = -1;
            }
        }

        public void AddUndirectedEdge(int from, int to)
        {
            _edges[from][to] = 0;
            _edges[to][from] = 0;
        }
        
        public bool Color(int m)
        {
            var colors = new int[_vertices];

            if (ColorUtil(m, colors, 0))
            {
                Console.WriteLine($"Can color: { String.Join(",", colors)}");
                return true;
            }
            else
            {
                Console.WriteLine($"Graph cannot be colored with {m} colors");
                return false;
            }
        }

        private bool ColorUtil(int maxColors, int[] colors, int vertex)
        {
            if (vertex == _vertices) return true;

            for (var i = 1; i <= maxColors; i++)
            {
                if (IsSafe(vertex, i, colors))
                {
                    colors[vertex] = i;
                    if (ColorUtil(maxColors, colors, vertex + 1)) return true;
                    colors[vertex] = 0;
                }
            }
            
            return false;
        }

        private bool IsSafe(int vertex, int color, int[] colors)
        {
            var edges = _edges[vertex];
            for (var i = 0; i < _vertices; i++)
            {
                if (i != vertex && edges[i] != -1 && colors[i] == color) return false;
            }
            return true;
        }


    }
}
