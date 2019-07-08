using NUnit.Framework;
using System;
namespace newbasicfact.test
{
    [TestFixture()]
    public class NUnitTestClass2
    {
        [Test()]
        public void Should_Add()
        {
            int number1 = 7;
            int number2 = 9;
            int reply3 = 0;
            Calculation.Plus_function(number1, number2, reply3);
            int Expecting = number1 + number2;
            Assert.AreEqual(16, Expecting);
        }

        [Test()]
        public void Should_Minus()
        {
            int number1 = 7;
            int number2 = 9;
            int reply3 = 0;
            Calculation.Plus_function(number1, number2, reply3);
            int Expecting = number2 - number1;
            Assert.AreEqual(2, Expecting);
        }

        [Test()]
        public void Should_Times()
        {
            int number1 = 7;
            int number2 = 9;
            int reply3 = 0;
            Calculation.Plus_function(number1, number2, reply3);
            int Expecting = number1 * number2;
            Assert.AreEqual(63, Expecting);
        }

        [Test()]
        public void Should_Divison()
        {
            int number1 = 7;
            int number2 = 9;
            int reply3 = 0;
            Calculation.Plus_function(number1, number2, reply3);
            int needs = number1 * number2;
            int Expecting = needs/number2;
            Assert.AreEqual(7, Expecting);
        }
    }
}
