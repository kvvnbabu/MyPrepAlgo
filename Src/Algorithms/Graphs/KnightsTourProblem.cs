using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithms.Graphs
{
    public class KnightsTourProblem
    {
        private static int count = 0;
        public static void GetRoute(int n)
        {
            int[,] res = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++) res[i, j] = -1;

            res[0, 0] = 0;
            int[] xmoves = new[] { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] ymoves = new[] { 1, 2, 2, 1, -1, -2, -2, -1 };
            CheckRoute(n, 0, 0, res, 1, xmoves, ymoves);

            PrintBoard(n, res);
        }

        private static void PrintBoard(int n, int[,] res, bool toFile = false)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=============================================");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.AppendFormat("{0,2} ", res[i, j]);
                }
                sb.AppendLine();
            }
            if (toFile)
                WriteToFile(sb);
            Console.WriteLine(sb.ToString());
        }

        private static void WriteToFile(StringBuilder sb)
        {
            using (FileStream file = new FileStream(@"C:\Nagendra\Personal\Git\AlgoPrep\Src\Algorithms\steps.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    sw.Write(sb);
                }
            }
        }


        private static bool CheckRoute(int n, int x, int y, int[,] res, int move, int[] xmoves, int[] ymoves)
        {
            if (move == n * n) return true;

            for (int i = 0; i < 8; i++)
            {
                if (IsSafe(n, x + xmoves[i], y + ymoves[i], res))
                {
                    res[x + xmoves[i], y + ymoves[i]] = move;
                    if (CheckRoute(n, x + xmoves[i], y + ymoves[i], res, move + 1, xmoves, ymoves))
                        return true;
                    res[x + xmoves[i], y + ymoves[i]] = -1;
                }
            }
            return false;
        }
        private static bool IsSafe(int n, int x, int y, int[,] moves)
        {
            return 0 <= x && x < n &&
                0 <= y && y < n &&
                moves[x, y] == -1;
        }

        private static bool CheckRoute(int n, Tuple<int, int> pos, int[,] res, int move)
        {
            Console.WriteLine("{0} of {1}", move, count++);
            if (move == n * n) return true;
            //if (res[pos.Item1, pos.Item2] == -1)
            //{
            //res[pos.Item1, pos.Item2] = move;
            Tuple<int, int>[] nextPositions = GetNextPositions(n, pos, res);

            foreach (var nextPosition in nextPositions)
            {
                res[nextPosition.Item1, nextPosition.Item2] = move;
                if (CheckRoute(n, nextPosition, res, move + 1)) return true;
                res[nextPosition.Item1, nextPosition.Item2] = -1;
            }
            //for (int i = 0; i < nextPositions.Length; i++)
            //{
            //    res[nextPositions[i].Item1, nextPositions[i].Item2] = move;
            //    if (CheckRoute(n, nextPositions[i], res, move + 1))
            //        return true;
            //    else
            //    {
            //        //PrintBoard(n, res, true);
            //        res[nextPositions[i].Item1, nextPositions[i].Item2] = -1;
            //    }
            //}

            //}
            return false;
        }



        private static Tuple<int, int>[] GetNextPositions(int n, Tuple<int, int> pos, int[,] moves)
        {
            List<Tuple<int, int>> allowedMoves = new List<Tuple<int, int>>();
            allowedMoves.Add(new Tuple<int, int>(pos.Item1 + 2, pos.Item2 + 1));
            allowedMoves.Add(new Tuple<int, int>(pos.Item1 + 1, pos.Item2 + 2));
            allowedMoves.Add(new Tuple<int, int>(pos.Item1 - 1, pos.Item2 + 2));
            allowedMoves.Add(new Tuple<int, int>(pos.Item1 - 2, pos.Item2 + 1));
            allowedMoves.Add(new Tuple<int, int>(pos.Item1 - 2, pos.Item2 - 1));
            allowedMoves.Add(new Tuple<int, int>(pos.Item1 - 1, pos.Item2 - 2));
            allowedMoves.Add(new Tuple<int, int>(pos.Item1 + 1, pos.Item2 - 2));
            allowedMoves.Add(new Tuple<int, int>(pos.Item1 + 2, pos.Item2 - 1));

            List<Tuple<int, int>> res = new List<Tuple<int, int>>();
            foreach (Tuple<int, int> npos in allowedMoves)
            {
                if (0 <= npos.Item1 && npos.Item1 < n &&
                    0 <= npos.Item2 && npos.Item2 < n &&
                    moves[npos.Item1, npos.Item2] == -1)
                {
                    res.Add(npos);
                }
            }
            return res.ToArray();
        }
    }
}
