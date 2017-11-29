using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class NQueensProblem
    {
        public static void FillQueens(int n)
        {
            int[] xpos = new int[n];
            int[] ypos = new int[n];
            for (int i = 0; i < n; i++) xpos[i] = ypos[i] = -1;


        }

        private static bool PlaceQueen(int n, int column, int[] xpos, int[] ypos, int q)
        {
            if (q == n - 1) return true;
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
            for(int i = 0; i< n; i++)
            {
                if(row)
            }
            return true;
        }
    }
}
