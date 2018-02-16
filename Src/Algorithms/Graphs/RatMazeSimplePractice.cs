using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Graphs
{
    public class RatMazeSimplePractice
    {
        private int[][] maze;

        private int size;

        private Tuple<int, int>[] allowedMoves = new[] { new Tuple<int, int>(0, 1), new Tuple<int, int>(1, 0), };

        public RatMazeSimplePractice(int n)
        {
            size = n;
            maze = new int[n][];
            for (int i = 0; i < n; i++)
            {
                maze[i] = new int[n];
            }
        }

        public RatMazeSimplePractice AddOpenBlock(int x, int y)
        {
            maze[x][y] = 1;
            return this;
        }

        public bool FindPath()
        {
            Stack<Tuple<int, int>> path = new Stack<Tuple<int, int>>();
            if (FindPath(0, 0, path))
            {
                Console.WriteLine($"Path {DisplayPath(path)}");
                return true;
            }
            Console.WriteLine($"Cannot find a path :{DisplayPath(path)}");
            return false;
        }

        private bool FindPath(int cx, int cy, Stack<Tuple<int, int>> path)
        {
            if (cx == size - 1 && cy == size - 1)
                return true;
            for (int i = 0; i < allowedMoves.Length; i++)
            {
                int nxtX = cx + allowedMoves[i].Item1;
                int nxtY = cy + allowedMoves[i].Item2;

                if (IsSafe(nxtX, nxtY))
                {
                    if (FindPath(nxtX, nxtY, path))
                    {
                        path.Push(new Tuple<int, int>(nxtX, nxtY));
                        return true;
                    }
                }
            }
            return false;
        }

        private string DisplayPath(Stack<Tuple<int, int>> path)
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in path)
            {
                result.AppendFormat("({0}, {1}) -> ", item.Item1, item.Item2);
            }
            return result.ToString();
        }

        private bool IsSafe(int px, int py)
        {
            if (px < 0 || px >= size || py < 0 || py >= size || maze[px][py] == 0)
                return false;
            return true;
        }
    }
}
