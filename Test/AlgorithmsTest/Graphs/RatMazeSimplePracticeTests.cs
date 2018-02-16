using System;
using System.Collections.Generic;
using System.Text;

using Algorithms.Graphs;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest.Graphs
{
    [TestClass]
    
    public class RatMazeSimplePracticeTests
    {
        private RatMazeSimplePractice target;
        /*
          {1, 0, 0, 0}
          {1, 1, 0, 1}
          {0, 1, 0, 0}
          {1, 1, 1, 1}
         *
         */
        [TestCategory("RatMaze Simple")]
        [TestMethod]
        public void RatMazeHasPath()
        {
            // arrange
            target = new RatMazeSimplePractice(4);
            target.AddOpenBlock(0, 0);
            target.AddOpenBlock(1, 0);
            target.AddOpenBlock(1, 1);
            target.AddOpenBlock(1, 3);
            target.AddOpenBlock(2, 1);
            target.AddOpenBlock(3, 0);
            target.AddOpenBlock(3, 1);
            target.AddOpenBlock(3, 2);
            target.AddOpenBlock(3, 3);

            // act 
            var result = target.FindPath();

            // Assert
            Assert.IsTrue(result);
        }

        /*
          {1, 0, 0, 0}
          {1, 0, 0, 1}
          {0, 1, 0, 0}
          {1, 1, 1, 1}
         *
         */
        [TestCategory("RatMaze Simple")]
        [TestMethod]
        public void RatMazeDoesNotHavePath()
        {
            // arrange
            target = new RatMazeSimplePractice(4);
            target.AddOpenBlock(0, 0);
            target.AddOpenBlock(1, 0);
            target.AddOpenBlock(1, 3);
            target.AddOpenBlock(2, 1);
            target.AddOpenBlock(3, 0);
            target.AddOpenBlock(3, 1);
            target.AddOpenBlock(3, 2);
            target.AddOpenBlock(3, 3);

            // act 
            var result = target.FindPath();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
