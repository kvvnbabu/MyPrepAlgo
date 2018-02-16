using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class SnakesAndLadders
    {
        int size;

        public SnakesAndLadders(int size)
        {
            this.size = size;
        }
        public int GetMinDiceRotations(Dictionary<int, int> laddersAndSnakes)
        {
            IGraph1 graph = new GraphAdjListUnWeighted(size);

            for(int i = 0; i < size; i++)
            {
                for(int j = 1; j <= 6 && i+j < size; j++)
                {
                    if (laddersAndSnakes.ContainsKey(i + j) && laddersAndSnakes[i + j] >= 0 && laddersAndSnakes[i + j] < size)
                    {
                        graph.AddEdge(i, laddersAndSnakes[i + j]);
                    }
                    else graph.AddEdge(i, i + j);
                }
            }

            graph.Display();

            graph.BFS();
            graph.DFS();

            return 1;

        }

        public int GetMinDiceRolesWithoutGraph(Dictionary<int, int> snakesAndLadders)
        {
            Queue<int> toProcess = new Queue<int>();
            bool[] visited = new bool[size + 1];
            int[] dist = new int[size +1];

            toProcess.Enqueue(1);
            visited[1] = true;

            while(toProcess.Count > 0)
            {
                int cLocation = toProcess.Dequeue();
                for(int i = 1; i < 7; i++)
                {
                    int nLocation = cLocation + i;
                    if (snakesAndLadders.ContainsKey(nLocation)) nLocation = snakesAndLadders[nLocation];
                    if (!visited[nLocation])
                    {
                        visited[nLocation] = true;
                        dist[nLocation] = dist[cLocation] + 1;
                        if (nLocation == size) return dist[nLocation];
                        toProcess.Enqueue(nLocation);
                    }
                }
            }
            return -1;
        }

        

        public int[,] GetGraph(int n, Dictionary<int, int> snakesAndLadders)
        {
            int[,] g = new int[n, n+1];

            for(int i= 1; i<n; i++)
            {
                for(int d = 1; d<= 6; d++)
                {
                    if(i+6 <= n)
                    g[i, i + d] = 1;
                }
            }

            foreach(int s  in snakesAndLadders.Keys)
            {
                g[s, snakesAndLadders[s]] = 1;
            }

            return g;
        }

        public string PrintGraph(int[,] g, int n)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("     ");
            for (int i = 0; i < n; i++) sb.AppendFormat("{0:00} ", i + 1);
            sb.AppendLine();
            sb.Append("_____");
            for (int i = 0; i < n; i++) sb.Append("___");
            sb.AppendLine();
            for (int i= 1; i<n; i++)
            {
                sb.AppendFormat("{0:00} | ", i);
                for (int j = 1; j <= n; j++)
                {
                    sb.AppendFormat("{0: 0} ", g[i, j]);
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
