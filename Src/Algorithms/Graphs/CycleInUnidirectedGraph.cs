using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class CycleInUnidirectedGraph : GraphAdjListUnWeighted
    {
        public CycleInUnidirectedGraph(int size) : base(size) { }
        
        public bool IsCyclic()
        {
            int[] reps = new int[n];
            for (int i = 0; i < n; i++) reps[i] = i;

            for(int vx =0; vx< n; vx++)
            {
                foreach(int toVx in edges[vx])
                {
                    if (reps[vx] == reps[toVx]) return true;
                    Union1(vx, toVx, reps);
                }
            }

            return false;
        }

        public void Union1(int x, int y, int[] reps)
        {
            int src = x <= y ? x : y;
            int dest = x >= y ? x : y;
            if(src != dest)
            {
                for(int i = 0; i< n; i++)
                {
                    if (reps[i] == src) reps[i] = dest;
                }
            }
        }

        public bool IsCyclic1()
        {
            int[] reps = new int[n];
            for (int i = 0; i < n; i++) reps[i] = -1;

            for (int i = 0; i < n; i++)
            {
                foreach (int tvx in edges[i])
                {
                    Console.WriteLine(String.Join(" ", reps));
                    int srcRep = FindRep(i, reps);
                    int destRep = FindRep(tvx, reps);

                    if (srcRep == destRep) return true;

                    Union(srcRep, destRep, reps);
                }
            }
            return false;
        }

        private int FindRep(int vx, int[] reps)
        {
            if (reps[vx] == -1) return vx;
            return FindRep(reps[vx], reps);
        }

        private void Union(int src, int dest, int[] reps)
        {
            //int srcEx = FindRep(src, reps);
            //int destEx = FindRep(dest, reps);

            //reps[srcEx] = destEx;
            reps[src] = dest;

        }
    }
}
