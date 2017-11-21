using Algorithms.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest.Strings
{
    /// <summary>
    /// Summary description for FiniteAutometaTest
    /// </summary>
    [TestClass]
    public class FiniteAutomataAlgoTest
    {
        FiniteAutomataAlgo target = new FiniteAutomataAlgo();

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_RandomText()
        {
            string str = "abacadaadabacadaabcaabaacabacadaab";
            string pattern = "abacadaabc";
            int[] expected = new[] { 9 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }


        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_StringContainsThePattern()
        {
            string str = "testmtestmtesttes";
            string pattern = "test";
            int[] expected = new[] { 0, 5, 10 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_PatternMatchesExactlyOnce()
        {
            string str = "testmtestmtesttes";
            string pattern = "testtes";
            int[] expected = new[] { 10 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_PatternDoesNotMatch()
        {
            string str = "testmtestmtesttesb";
            string pattern = "tesa";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_PatternMatchesExactlyWithEntireString()
        {
            string str = "testmtestmtesttesb";
            string pattern = "testmtestmtesttesb";
            int[] expected = new[] { 0 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_PatternOfSameLengthButDoesNotMatch()
        {
            string str = "testmtestmtesttesb";
            string pattern = "testmtesmttesttesb";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_PatternSizeIsBiggerThanString()
        {
            string str = "testmtestmtesttesb";
            string pattern = "testmtestmtesttesbas";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_HasAllSameChars()
        {
            string str = "aaaaaaaaaaaaaaaaaa";
            string pattern = "aaaaa";
            int[] expected = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_PatternAndStringAreEmpty()
        {
            string str = "";
            string pattern = "";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);

        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_PatternAndStringAreNull()
        {
            string str = null;
            string pattern = null;
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_PatternIsNull()
        {
            string str = "abcdefghijklmnop";
            string pattern = null;
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_StringIsNull()
        {
            string str = null;
            string pattern = "abc";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_StringIsNullAndPatternIsEmpty()
        {
            string str = null;
            string pattern = "";
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void String_ExactMatch_FiniteAutomataAlgo_StringIsEmptyAndPatternIsNull()
        {
            string str = "";
            string pattern = null;
            int[] expected = new int[0];

            int[] actual = target.SearchPattern(str, pattern);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
