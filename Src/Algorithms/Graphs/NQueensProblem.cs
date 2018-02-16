using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Algorithms.Graphs
{
    public class NQueensProblem
    {
        private const int BOARD_SIZE = 8;

        public static void FillQueens(int n)
        {
            int[] xpos = new int[n];
            int[] ypos = new int[n];
            for (int i = 0; i < n; i++)
                xpos[i] = ypos[i] = -1;

            if (PlaceQueen(n, 0, xpos, ypos, 0))
            {
                Console.WriteLine($"{n} Queens Possible!!");
                Console.WriteLine(GetQueensPositionString(n, xpos, ypos));
            }
            else
                Console.WriteLine($"{n} Queens Not possible!");
        }

        private static bool PlaceQueen(int n, int column, int[] xpos, int[] ypos, int q)
        {
            if (q == n)
                return true;
            for (int row = 0; row < n; row++)
            {
                if (IsSafe(n, row, column, xpos, ypos))
                {
                    xpos[q] = row;
                    ypos[q] = column;

                    if (PlaceQueen(n, column + 1, xpos, ypos, q + 1))
                        return true;

                    xpos[q] = ypos[q] = -1;
                }
            }
            return false;
        }

        private static bool IsSafe(int n, int row, int column, int[] xpos, int[] ypos)
        {
            if (row < 0 || row >= BOARD_SIZE || column < 0 || column >= BOARD_SIZE)
                return false;
            for (var i = 0; i < n && xpos[i] != -1 && ypos[i] != -1; i++)
            {
                if (xpos[i] == row)
                    return false;
                if (ypos[i] == column)
                    return false;
                if ((xpos[i] - row == ypos[i] - column))
                    return false;
                if (xpos[i] + ypos[i] == row + column)
                    return false;
            }

            return true;
        }
        private static string GetQueensPositionString(int n, int[] xpos, int[] ypos)
        {
            StringBuilder res = new StringBuilder();

            int[][] positions = new int[8][];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                positions[i] = new int[BOARD_SIZE];
            }

            for (int i = 0; i < n; i++)
            {
                //if (xpos[i] != -1 && ypos[i] != -1)
                    positions[xpos[i]][ypos[i]] = i+1;
            }

            for (int i = 0; i < BOARD_SIZE; i++)
            {
                res.AppendLine(String.Join(" ", positions[i]));
            }

            return res.ToString();

        }
    }
}
