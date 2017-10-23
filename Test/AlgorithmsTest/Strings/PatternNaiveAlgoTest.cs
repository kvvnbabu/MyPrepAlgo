using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algos.Strings;

namespace AlgorithmsTest.Strings
{
    [TestClass]
    public class PatternNaiveAlgoTest
    {
        PatternNaiveAlgo target = new PatternNaiveAlgo();

        [TestMethod]
        public void String_ExactMatch_Naive_StringContainsThePattern()
        {
            string str = "testmtestmtesttes";
            string pattern = "test";
            int[] expected = new[] { 0, 5, 10 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_PatternMatchesExactlyOnce()
        {
            string str = "testmtestmtesttes";
            string pattern = "testtes";
            int[] expected = new[] { 10 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_PatternDoesNotMatch()
        {
            string str = "testmtestmtesttesb";
            string pattern = "tesa";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_PatternMatchesExactlyWithEntireString()
        {
            string str = "testmtestmtesttesb";
            string pattern = "testmtestmtesttesb";
            int[] expected = new[] { 0 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_PatternOfSameLengthButDoesNotMatch()
        {
            string str = "testmtestmtesttesb";
            string pattern = "testmtesmttesttesb";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_PatternSizeIsBiggerThanString()
        {
            string str = "testmtestmtesttesb";
            string pattern = "testmtestmtesttesbas";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_HasAllSameChars()
        {
            string str = "aaaaaaaaaaaaaaaaaa";
            string pattern = "aaaaa";
            int[] expected = new[] { 0,1,2,3,4,5,6,7,8,9,10,11,12,13 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_PatternAndStringAreEmpty()
        {
            string str = "";
            string pattern = "";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);

        }

        [TestMethod]
        public void String_ExactMatch_Naive_PatternAndStringAreNull()
        {
            string str = null;
            string pattern = null;
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_PatternIsNull()
        {
            string str = "abcdefghijklmnop";
            string pattern = null;
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_StringIsNull()
        {
            string str = null;
            string pattern = "abc";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_StringIsNullAndPatternIsEmpty()
        {
            string str = null;
            string pattern = "";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_Naive_StringIsEmptyAndPatternIsNull()
        {
            string str = "";
            string pattern = null;
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
