using System;
using System.Collections.Generic;
using System.Text;

using Algorithms.Graphs;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest.Graphs
{
    [TestClass]
    public class MColoringPracticeTests
    {
        private MColorsPractise _target;

        /* Create following graph and test whether it is 3 colorable
          (3)---(2)
           |   / |
           |  /  |
           | /   |
          (0)---(1)
        */

        [TestMethod]
        [TestCategory("mColoringPractice")]
        public void GraphIsColorableWith3Colors1()
        {
            // arrange
            _target = new MColorsPractise(4);
            _target.AddUndirectedEdge(0, 1);
            _target.AddUndirectedEdge(0, 2);
            _target.AddUndirectedEdge(0, 3);
            _target.AddUndirectedEdge(1, 2);
            _target.AddUndirectedEdge(2, 3);

            // act
            var result = _target.IsColorable(3);

            // assert
            Assert.IsTrue(result);
        }

        //https://upload.wikimedia.org/wikipedia/commons/thumb/9/90/Petersen_graph_3-coloring.svg/220px-Petersen_graph_3-coloring.svg.png
        // Coloring2.jpg
        [TestMethod]
        [TestCategory("mColoringPractice")]
        public void GraphIsColorableWith3Colors2()
        {
            // arrange
            _target = new MColorsPractise(10);
            _target.AddUndirectedEdge(0, 2);
            _target.AddUndirectedEdge(0, 1);
            _target.AddUndirectedEdge(0, 3);
            _target.AddUndirectedEdge(1, 4);
            _target.AddUndirectedEdge(1, 5);
            _target.AddUndirectedEdge(2, 4);
            _target.AddUndirectedEdge(2, 8);
            _target.AddUndirectedEdge(3, 5);
            _target.AddUndirectedEdge(3, 9);
            _target.AddUndirectedEdge(4, 6);
            _target.AddUndirectedEdge(5, 7);
            _target.AddUndirectedEdge(6, 7);
            _target.AddUndirectedEdge(6, 8);
            _target.AddUndirectedEdge(7, 9);
            _target.AddUndirectedEdge(8, 9);

            // act
            var result = _target.IsColorable(3);

            // assert
            Assert.IsTrue(result);
        }
        //https://upload.wikimedia.org/wikipedia/commons/thumb/9/90/Petersen_graph_3-coloring.svg/220px-Petersen_graph_3-coloring.svg.png
        // Coloring2.jpg
        [TestMethod]
        [TestCategory("mColoringPractice")]
        public void GraphIsNotColorableWith2Colors2()
        {
            // arrange
            _target = new MColorsPractise(10);
            _target.AddUndirectedEdge(0, 2);
            _target.AddUndirectedEdge(0, 1);
            _target.AddUndirectedEdge(0, 3);
            _target.AddUndirectedEdge(1, 4);
            _target.AddUndirectedEdge(1, 5);
            _target.AddUndirectedEdge(2, 4);
            _target.AddUndirectedEdge(2, 8);
            _target.AddUndirectedEdge(3, 5);
            _target.AddUndirectedEdge(3, 9);
            _target.AddUndirectedEdge(4, 6);
            _target.AddUndirectedEdge(5, 7);
            _target.AddUndirectedEdge(6, 7);
            _target.AddUndirectedEdge(6, 8);
            _target.AddUndirectedEdge(7, 9);
            _target.AddUndirectedEdge(8, 9);

            // act
            var result = _target.IsColorable(2);

            // assert
            Assert.IsFalse(result);
        }

        // Coloring3.jpg
        [TestMethod]
        [TestCategory("mColoringPractice")]
        public void GraphIsColorableWith3Colors3()
        {
            // arrange
            _target = new MColorsPractise(10);
            _target.AddUndirectedEdge(0, 1);
            _target.AddUndirectedEdge(0, 2);
            _target.AddUndirectedEdge(0, 3);
            _target.AddUndirectedEdge(1, 4);
            _target.AddUndirectedEdge(1, 5);
            _target.AddUndirectedEdge(2, 6);
            _target.AddUndirectedEdge(2, 7);
            _target.AddUndirectedEdge(3, 5);
            _target.AddUndirectedEdge(3, 9);
            _target.AddUndirectedEdge(4, 5);
            _target.AddUndirectedEdge(4, 7);
            _target.AddUndirectedEdge(5, 6);
            _target.AddUndirectedEdge(6, 8);
            _target.AddUndirectedEdge(7, 9);
            _target.AddUndirectedEdge(8, 9);

            // act
            var result = _target.IsColorable(3);

            // assert
            Assert.IsTrue(result);
        }
        
        // Coloring3.jpg
        [TestMethod]
        [TestCategory("mColoringPractice")]
        public void GraphIsColorableWith4Colors3()
        {
            // arrange
            _target = new MColorsPractise(10);
            _target.AddUndirectedEdge(0, 1);
            _target.AddUndirectedEdge(0, 2);
            _target.AddUndirectedEdge(0, 3);
            _target.AddUndirectedEdge(1, 4);
            _target.AddUndirectedEdge(1, 5);
            _target.AddUndirectedEdge(2, 6);
            _target.AddUndirectedEdge(2, 7);
            _target.AddUndirectedEdge(3, 5);
            _target.AddUndirectedEdge(3, 9);
            _target.AddUndirectedEdge(4, 5);
            _target.AddUndirectedEdge(4, 7);
            _target.AddUndirectedEdge(5, 6);
            _target.AddUndirectedEdge(6, 8);
            _target.AddUndirectedEdge(7, 9);
            _target.AddUndirectedEdge(8, 9);

            // act
            var result = _target.IsColorable(4);

            // assert
            Assert.IsTrue(result);
        }
    }
}
