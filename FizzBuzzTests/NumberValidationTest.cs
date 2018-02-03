using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class NumberValidationTest
    {
        private NumberValidation numberValidation;

        [TestInitialize]
        public void Init()
        {
            numberValidation = new NumberValidation();
        }


        [TestMethod]
        public void ShouldPrintFizz()
        {
            EnumPrintedText result = numberValidation.ValidateNumber(18);
            Assert.AreEqual(result, EnumPrintedText.Fizz);
        }

        [TestMethod]
        public void ShouldPrintBuzz()
        {
            EnumPrintedText result = numberValidation.ValidateNumber(15);
            Assert.AreEqual(result, EnumPrintedText.Buzz);
        }

        [TestMethod]
        public void ShouldPrintFizzBuzz()
        {
            EnumPrintedText result = numberValidation.ValidateNumber(30);
            Assert.AreEqual(result, EnumPrintedText.FizzBuzz);
        }
    }
}