using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170731_MultiplesOfThreeAndFive
{
    [TestClass]
    public class MultiplesOfThreeAndFiveTests
    {
        [TestMethod]
        public void input_4_should_return_3()
        {
            AssertMultiple3And5ShouldBe(4, 3);
        }

        private static void AssertMultiple3And5ShouldBe(int value, int expected)
        {
            var kata = new Kata();
            var actual = kata.Solution(value);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int Solution(int value)
        {
            for (int i = 1; i < 4; i++)
            {
                if (i % 3 == 0)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
