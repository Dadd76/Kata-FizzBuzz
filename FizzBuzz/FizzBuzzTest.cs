using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;


namespace Fizz
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void TestThatCommonNumberReturnNumber(int i)
        {
            
            string message = string.Empty;

            FizzBuzz.GetMessage(i);
            Assert.AreEqual(message, i.ToString());

        }

        [TestCase(3)]
        [TestCase(9)]
        public void TestThatNumberMutipleOf3ReturnFizz(int i)
        {
            string message = string.Empty;       
            message = FizzBuzz.GetMessage(i);
            Assert.AreEqual(message,"Fizz");
        }

        [TestCase(5)]
        [TestCase(10)]
        public void TestThatNumberMutipleOf5ReturnFizz(int i)
        {
            string message = string.Empty;
            message = FizzBuzz.GetMessage(i);
            Assert.AreEqual(message, "Buzz");
        }

        [TestCase(15)]
        [TestCase(30)]
        public void TestThatNumberMutipleOf3and5ReturnFizz(int i)
        {
            string message = string.Empty;

            message = FizzBuzz.GetMessage(i);
            Assert.AreEqual(message, "FizzBuzz");
        }

    }
}
