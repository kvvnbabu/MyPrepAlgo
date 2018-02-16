using System;
using System.Collections.Generic;
using System.Text;

using Algorithms.Graphs;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest.Graphs
{
    [TestClass]
    public class HamiltonCycleTests
    {
        private IHamiltonCycle target;


        /* Let us create the following graph
           (0)--(1)--(2)
            |   / \   |
            |  /   \  |
            | /     \ |
           (3)-------(4)    */
        [TestMethod]
        [TestCategory("Hamilton Cycle")]
        public void HamiltonCycleExistsForTheGraph()
        {
            // arrange
            target = new HamiltonCycleWithUndirectedGraph(5);
            target.AddUndirectedEdge(0, 1);
            target.AddUndirectedEdge(0, 3);
            target.AddUndirectedEdge(1, 2);
            target.AddUndirectedEdge(1, 3);
            target.AddUndirectedEdge(1, 4);
            target.AddUndirectedEdge(2, 4);
            target.AddUndirectedEdge(3, 4);

            // act 
            var result = target.IsHamiltonCycle();

            // assert
            Assert.IsTrue(result);
        }


        /* Let us create the following graph
           (0)--(1)--(2)
            |   / \   |
            |  /   \  |
            | /     \ |
           (3)       (4)    */
        [TestMethod]
        [TestCategory("Hamilton Cycle")]
        public void HamiltonCycleDoesNotExistForTheGraph()
        {
            // arrange
            target = new HamiltonCycleWithUndirectedGraph(5);
            target.AddUndirectedEdge(0, 1);
            target.AddUndirectedEdge(0, 3);
            target.AddUndirectedEdge(1, 2);
            target.AddUndirectedEdge(1, 3);
            target.AddUndirectedEdge(1, 4);
            target.AddUndirectedEdge(2, 4);

            // act 
            var result = target.IsHamiltonCycle();

            // assert
            Assert.IsFalse(result);
        }
    }
}
