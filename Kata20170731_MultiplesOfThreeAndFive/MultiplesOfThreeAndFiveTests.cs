using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void input_6_should_return_8()
        {
            AssertMultiple3And5ShouldBe(6, 8);
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
            var result = new List<int>();
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result.Add(i);
                }
            }

            return result.Sum();
        }
    }
}
