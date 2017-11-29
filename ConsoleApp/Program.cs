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
            //var cug = new CycleInUnidirectedGraph(5);
            //cug.AddEdge(0, 1);
            //cug.AddEdge(0, 2);
            //cug.AddEdge(1, 3);
            //cug.AddEdge(1, 4);
            //cug.AddEdge(3, 4);
            //Console.WriteLine(cug.IsCyclic());

            // All Topology sorting
            //var g = new AllTopologicalSort(6);
            //g.AddEdge(5,2);
            //g.AddEdge(5,0);
            //g.AddEdge(4,0);
            //g.AddEdge(4,1);
            //g.AddEdge(2,3);
            //g.AddEdge(3,1);
            //g.GetAllTopologicalSorts();

            // MST 
            //var g = new MinSpannigTreePrims(9);
            //g.AddEdge(0, 1, 4);
            //g.AddEdge(0, 7, 8);
            //g.AddEdge(1, 7, 11);
            //g.AddEdge(1, 2, 8);
            //g.AddEdge(7, 8, 7);
            //g.AddEdge(6, 7, 1);
            //g.AddEdge(2, 8, 2);
            //g.AddEdge(6, 8, 6);
            //g.AddEdge(2, 3, 7);
            //g.AddEdge(2, 5, 4);
            //g.AddEdge(6, 5, 2);
            //g.AddEdge(3, 5, 14);
            //g.AddEdge(3, 4, 9);
            //g.AddEdge(4, 5, 10);
            //g.Get();

            //var gk = new MSTKruskals(9);
            //gk.AddEdge(0, 1, 4);
            //gk.AddEdge(0, 7, 8);
            //gk.AddEdge(1, 7, 11);
            //gk.AddEdge(1, 2, 8);
            //gk.AddEdge(7, 8, 7);
            //gk.AddEdge(6, 7, 1);
            //gk.AddEdge(2, 8, 2);
            //gk.AddEdge(6, 8, 6);
            //gk.AddEdge(2, 3, 7);
            //gk.AddEdge(2, 5, 4);
            //gk.AddEdge(6, 5, 2);
            //gk.AddEdge(3, 5, 14);
            //gk.AddEdge(3, 4, 9);
            //gk.AddEdge(4, 5, 10);
            //gk.Get();

            //var pathKLength = new PathWithKLength(9);
            //pathKLength.AddEdge(0, 1, 4);
            //pathKLength.AddEdge(0, 7, 8);
            //pathKLength.AddEdge(1, 2, 8);
            //pathKLength.AddEdge(1, 7, 11);
            //pathKLength.AddEdge(2, 3, 7);
            //pathKLength.AddEdge(2, 5, 4);
            //pathKLength.AddEdge(2, 8, 2);
            //pathKLength.AddEdge(3, 4, 9);
            //pathKLength.AddEdge(3, 5, 14);
            //pathKLength.AddEdge(4, 5, 10);
            //pathKLength.AddEdge(5, 6, 2);
            //pathKLength.AddEdge(6, 8, 6);
            //pathKLength.AddEdge(6, 7, 1);
            //pathKLength.AddEdge(7, 8, 7);

            //Console.WriteLine(pathKLength.HasPathWithLength(0, 60));
            //Console.WriteLine(pathKLength.HasPathWithLength(0, 62));

            // ThugOfWar
            //ThugOfWar.DevideTeams(new[] { 3, 4, 5, -3, 100, 1, 89, 54, 23, 20 });
            //ThugOfWar.DevideTeams(new[] { 23, 45, -34, 12, 0, 98, -99, 4, 189, -1, 4 });

            // Knights problem
            //KnightsTourProblem.GetRoute(8);

            // Rats maze problem
            int[,] maze = new[,] {
                { 1, 0, 0, 0 },
                { 1, 1, 0, 1 },
                { 0, 1, 1, 1 },
                { 1, 1, 0, 1 }
            };
            RatsMazeProblem rp = new RatsMazeProblem(4, maze);
            rp.ConstructPath();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}