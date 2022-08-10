namespace TechnicalTasks.Tests.ServiceTests
{
    using Domain.Services;
    using Domain.Services.Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AlgorithmServiceTests
    {
        private readonly IAlgorithmService _algorithmService = new AlgorithmService();

        public AlgorithmServiceTests() {}

        [TestMethod]
        public void When_IsDivisibleBySeven_ShouldReturnJazz()
        {
            var result = _algorithmService.DivisibleNumber(14);
            Assert.AreEqual(result, "Jazz");
        }

        [TestMethod]
        public void When_IsDivisibleByThree_ShouldReturnSalsa()
        {
            var result = _algorithmService.DivisibleNumber(9);
            Assert.AreEqual(result, "Salsa");
        }

        [TestMethod]
        public void When_IsDivisibleByThreeAndFive_ShouldReturnJazzSalsa()
        {
            var result = _algorithmService.DivisibleNumber(15);
            Assert.AreEqual(result, "JazzSalsa");
        }

        [TestMethod]
        public void When_IsNotDivisible_ShouldThrowAnErrorMessage()
        {
            var result = _algorithmService.DivisibleNumber(17);
            Assert.AreEqual(result, "The number is not divisible according to the exercise");
        }
    }
}