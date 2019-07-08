using NUnit.Framework;
using System;
namespace basicfact.test
{
    [TestFixture()]
    public class CalculationTests
    {

        [Test()]
        public void Should_Add()
        {
            int number1 = 5;
            int number2 = 6;

            int function1 = 1;

            int reply3 = 0;

            Calculation.Calculate_function(number1, number2, function1, reply3);
            int Expectedresult = number1 + number2;
            Assert.AreEqual(11, Expectedresult);
        }

        [Test()]
        public void Should_Minus()
        {
            int number1 = 5;
            int number2 = 6;

            int function2 = 2;
   
            int reply3 = 0;

            Calculation.Calculate_function(number1, number2, function2, reply3);
            int Expectedresult = number2 - number1;
            Assert.AreEqual(1, Expectedresult);
        }

        [Test()]
        public void Should_Times()
        {
            int number1 = 5;
            int number2 = 6;

            int function3 = 3;

            int reply3 = 0;

            Calculation.Calculate_function(number1, number2, function3, reply3);
            int Expectedresult = number1 * number2;
            Assert.AreEqual(30,Expectedresult);
        }

        [Test()]
        public void Should_Division()
        {
            int number1 = 5;
            int number2 = 6;

            int function4 = 4;

            int reply3 = 0;

            Calculation.Calculate_function(number1, number2, function4, reply3);

            int needs = number1 * number2;
            int Expectedresult = needs / number2;
            Assert.AreEqual(5, Expectedresult);
        }
    }
}

