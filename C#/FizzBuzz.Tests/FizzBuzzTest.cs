using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void NotMultipleOf3Or5IsSameNumber()
        {
            const int Input = 4;
            var result = FizzBuzzHelper.GetFizzBuzz(Input);
            Assert.IsTrue(result == Input.ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void MultiplesOf3AreFizz()
        {
            const int Input = 3;
            var result = FizzBuzzHelper.GetFizzBuzz(Input);
            Assert.IsTrue(result == "Fizz");
        }

        [TestMethod]
        public void MultiplesOf5AreBuzz()
        {
            const int Input = 5;
            var result = FizzBuzzHelper.GetFizzBuzz(Input);
            Assert.IsTrue(result == "Buzz");
        }

        [TestMethod]
        public void MultiplesOf3And5AreFizzBuzz()
        {
            const int Input = 15;
            var result = FizzBuzzHelper.GetFizzBuzz(Input);
            Assert.IsTrue(result == "FizzBuzz");
        }
    }
}
