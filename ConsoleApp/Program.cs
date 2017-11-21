using Algorithms.Graphs;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> sl = new Dictionary<int, int> {
                {12, 23 },
                {22, 3 },
                { 2, 7},
                {5, 15 },
                {11, 6 },
                { 13, 1 },
                { 9, 4}
            };

            //SnakesAndLadders slg = new SnakesAndLadders(25);
            // slg.GetMinDiceRotations(sl);
            //Console.WriteLine(slg.GetMinDiceRolesWithoutGraph(sl));
            //int size = 25;



            //int[,] g = slg.GetGraph(size, sl);

            //Console.WriteLine(slg.PrintGraph(g, size));

            // Cyclic Unidirected graph
            var cug = new CycleInUnidirectedGraph(5);
            cug.AddEdge(0, 1);
            cug.AddEdge(0, 2);
            cug.AddEdge(1, 3);
            cug.AddEdge(1, 4);
            cug.AddEdge(3, 4);
            Console.WriteLine(cug.IsCyclic());

            // All Topology sorting
            //var g = new AllTopologicalSort(6);
            //g.AddEdge(5,2);
            //g.AddEdge(5,0);
            //g.AddEdge(4,0);
            //g.AddEdge(4,1);
            //g.AddEdge(2,3);
            //g.AddEdge(3,1);
            //g.GetAllTopologicalSorts();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}