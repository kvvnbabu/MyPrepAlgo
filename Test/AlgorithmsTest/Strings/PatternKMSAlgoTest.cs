using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algos.Strings;

namespace AlgorithmsTest.Strings
{
    [TestClass]
    public class PatternKMSAlgoTest
    {
        PatternKMSAlog target = new PatternKMSAlog();

        [TestMethod]
        public void String_ExactMatch_KMS_StringContainsThePattern()
        {
            string str = "testmtestmtesttes";
            string pattern = "test";
            int[] expected = new[] { 0, 5, 10 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_PatternMatchesExactlyOnce()
        {
            string str = "testmtestmtesttes";
            string pattern = "testtes";
            int[] expected = new[] { 10 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_PatternDoesNotMatch()
        {
            string str = "testmtestmtesttesb";
            string pattern = "tesa";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_PatternMatchesExactlyWithEntireString()
        {
            string str = "testmtestmtesttesb";
            string pattern = "testmtestmtesttesb";
            int[] expected = new[] { 0 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_PatternOfSameLengthButDoesNotMatch()
        {
            string str = "testmtestmtesttesb";
            string pattern = "testmtesmttesttesb";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_PatternSizeIsBiggerThanString()
        {
            string str = "testmtestmtesttesb";
            string pattern = "testmtestmtesttesbas";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_HasAllSameChars()
        {
            string str = "aaaaaaaaaaaaaaaaaa";
            string pattern = "aaaaa";
            int[] expected = new[] { 0,1,2,3,4,5,6,7,8,9,10,11,12,13 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_PatternAndStringAreEmpty()
        {
            string str = "";
            string pattern = "";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);

        }

        [TestMethod]
        public void String_ExactMatch_KMS_PatternAndStringAreNull()
        {
            string str = null;
            string pattern = null;
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_PatternIsNull()
        {
            string str = "abcdefghijklmnop";
            string pattern = null;
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_StringIsNull()
        {
            string str = null;
            string pattern = "abc";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_StringIsNullAndPatternIsEmpty()
        {
            string str = null;
            string pattern = "";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_KMS_StringIsEmptyAndPatternIsNull()
        {
            string str = "";
            string pattern = null;
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
