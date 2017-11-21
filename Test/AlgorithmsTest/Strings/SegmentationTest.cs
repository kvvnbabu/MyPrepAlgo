using Algorithms.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest.Strings
{
    /// <summary>
    /// Summary description for FiniteAutometaTest
    /// </summary>
    [TestClass]
    public class SegmentationTest
    {
        StringSegmentation target = new StringSegmentation();

        [TestMethod]
        public void String_Segmentation_RandomText()
        {
            string str = "This is a good day";
            int k = 10;
            int expected = 4;

            int actual = target.GetMinSegmentCuts(str, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void String_Segmentation_LongText()
        {
            string str = "This is a good dayThis is a good dayThis is a good dayThis is a good dayThis is a good dayThis is a good dayThis is a good dayThis is a good dayThis is a good day";
            int k = 20;
            int expected = 12;

            int actual = target.GetMinSegmentCuts(str, k);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void String_Segmentation_SegmentLengthIsMoreThanText()
        {
            string str = "text";
            int k = 20;
            int expected = 1;

            int actual = target.GetMinSegmentCuts(str, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void String_Segmentation_SuffixSizeIsVerySmall()
        {
            string str = "text is this";
            int k = 5;
            int expected = 0;

            int actual = target.GetMinSegmentCuts(str, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
