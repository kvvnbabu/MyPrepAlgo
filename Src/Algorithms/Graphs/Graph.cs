using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{

    public interface IGraph
    {
        void AddEdge(int from, int to);

        void AddEdge(int from, int to, int weight);

        void Display();

        void BFS();

        void DFS();
    }

    public class GraphAdjListUnWeighted : IGraph
    {
        protected SortedSet<int>[] edges { get; }

        protected int n;

        public GraphAdjListUnWeighted(int size)
        {
            n = size;
            edges = new SortedSet<int>[n];
            for (int i = 0; i < n; i++)
                edges[i] = new SortedSet<int>();
        }

        public void AddEdge(int from, int to)
        {
            edges[from].Add(to);
        }

        public void AddEdge(int from, int to, int weight)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < edges.Length; i++)
            {
                sb.AppendFormat("{0:  0} -> ", i);
                if (edges[i] != null)
                {
                    foreach (int edge in edges[i])
                    {
                        sb.AppendFormat("{0}, ", edge);
                    }
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb);
        }

        public void BFS()
        {
            Queue<int> toProcess = new Queue<int>();
            bool[] visited = new bool[n];
            int[] dist = new int[n];

            toProcess.Enqueue(0);
            visited[0] = true;

            while (toProcess.Count > 0)
            {
                int node = toProcess.Dequeue();
                Console.Write("{0} -> ", node);
                if (edges[node] != null)
                {
                    foreach (int edge in edges[node])
                    {
                        if (!visited[edge])
                        {
                            visited[edge] = true;
                            toProcess.Enqueue(edge);
                            dist[edge] = dist[node] + 1;
                        }
                    }
                }
            }
            Console.WriteLine(dist[n-1]);
        }

        public void DFS()
        {
            Stack<int> toProcess = new Stack<int>();
            bool[] visited = new bool[n];

            toProcess.Push(0);
            visited[0] = true;

            while(toProcess.Count > 0)
            {
                int node = toProcess.Pop();
                Console.Write("{0} -> ", node);
                if(edges[node] != null)
                foreach(int edge in edges[node]){
                    if (!visited[edge])
                    {
                        toProcess.Push(edge);
                        visited[edge] = true;
                    }
                }
            }

            Console.WriteLine();
        }
    }

    public class GraphAdjListWeighted
    {
        public LinkedList<Tuple<int, int>>[] Edges { get; }
    }

    public class GraphAdjMatrixUnWeighted
    {
        public int[][] Edges { get; }
    }
}
