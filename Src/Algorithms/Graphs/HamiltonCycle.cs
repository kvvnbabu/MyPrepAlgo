
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class HamiltonCycleWithUndirectedGraph : IHamiltonCycle
    {
        private int _vertices;
        private int[][] _edges;

        public HamiltonCycleWithUndirectedGraph(int vertices)
        {
            Init(vertices);
        }

        public void AddUndirectedEdge(int from, int to)
        {
            _edges[from][to] = 1;
            _edges[to][from] = 1;
        }

        public bool IsHamiltonCycle()
        {
            int[] path = new int[_vertices];
            for (int i = 0; i < _vertices; i++)
            {
                path[i] = -1;
            }

            path[0] = 0;
            if (HamiltonCycleUtil(path, 1))
            {
                Console.WriteLine("Hamilton Cycle is possible");
                return true;
            }
            Console.WriteLine("Hamilton Cycle is not possible");
            return false;
        }

        private bool HamiltonCycleUtil(int[] path, int position)
        {
            if (position == _vertices)
            {
                if (_edges[path[position - 1]][path[0]] == 1)
                    return true;
                return false;
            }

            for (int v = 1; v < _vertices; v++)
            {
                if (IsSafe(v, path, position))
                {
                    path[position] = v;
                    if (HamiltonCycleUtil(path, position + 1))
                        return true;
                    path[position] = -1;
                }
            }
            return false;
        }


        private bool IsSafe(int vertex, int[] path, int position)
        {
            if (_edges[vertex][path[position - 1]] == 0)
                return false;

            for (int i = 0; i < _vertices; i++)
            {
                if (path[i] == vertex)
                {
                    return false;
                }
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
