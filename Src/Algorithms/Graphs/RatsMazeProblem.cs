using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class RatsMazeProblem
    {
        int n;
        int[,] maze;
        public RatsMazeProblem(int size, int[,] maze)
        {
            n = size;
            this.maze = maze;
        }

        public void ConstructPath()
        {
            int[,] result = new int[n, n];
            int[] xmove = new[] { 0, 1 };
            int[] ymove = new[] { 1, 0 };
            result[0, 0] = 1;
            if (ConstructPath(0, 0, result, xmove, ymove))
            {
                Console.WriteLine(GetDisplayString(result));
            }
            else
            {
                Console.WriteLine("No Path exists");
            }
        }
        private bool ConstructPath(int x, int y, int[,] moves, int[] xmoves, int[] ymoves)
        {
            if (x == n - 1 && y == n - 1) return true;
            for (int i = 0; i < 2; i++)
            {
                if (IsSafe(x + xmoves[i], y + ymoves[i], moves))
                {
                    moves[x + xmoves[i], y + ymoves[i]] = 1;
                    if (ConstructPath(x + xmoves[i], y + ymoves[i], moves, xmoves, ymoves))
                        return true;
                    moves[x + xmoves[i], y + ymoves[i]] = 0;
                }
            }
            return false;
        }
        private bool IsSafe(int x, int y, int[,] moves)
        {
            return 0 <= x && x < n &&
                0 <= y && y < n &&
                maze[x, y] == 1 &&
                moves[x, y] == 0;
        }

        private string GetDisplayString(int[,] moves)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.AppendFormat("{0} ", moves[i, j]);
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
