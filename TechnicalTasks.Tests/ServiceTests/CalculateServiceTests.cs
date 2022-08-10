namespace TechnicalTasks.Tests.ServiceTests
{
    using Domain.Services;
    using Domain.Services.Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CalculateServiceTests
    {
        private readonly ICalculateService _calculateService = new CalculateService();

        public CalculateServiceTests() {}

        [TestMethod]
        public void When_TypeIsOne_MoreThanFiveYears_NewMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountNew(100, 1, 10);
            Assert.AreEqual(result, 100m);
        }

        [TestMethod]
        public void When_TypeIsTwo_MoreThanFiveYears_NewMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountNew(100, 2, 10);
            Assert.AreEqual(result, 85.500m);
        }

        [TestMethod]
        public void When_TypeIsThree_MoreThanFiveYears_NewMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountNew(100, 3, 10);
            Assert.AreEqual(result, 66.500m);
        }

        [TestMethod]
        public void When_TypeIsFour_MoreThanFiveYears_NewMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountNew(100, 4, 10);
            Assert.AreEqual(result, 47.500m);
        }

        [TestMethod]
        public void When_TypeIsOne_LessThanFiveYears_NewMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountNew(100, 1, 4);
            Assert.AreEqual(result, 100m);
        }

        [TestMethod]
        public void When_TypeIsTwo_LessThanFiveYears_NewMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountNew(100, 2, 4);
            Assert.AreEqual(result, 86.400m);
        }

        [TestMethod]
        public void When_TypeIsThree_LessThanFiveYears_NewMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountNew(100, 3, 4);
            Assert.AreEqual(result, 67.200m);
        }

        [TestMethod]
        public void When_TypeIsFour_LessThanFiveYears_NewMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountNew(100, 4, 4);
            Assert.AreEqual(result, 48m);
        }

        [TestMethod]
        public void When_TypeIsOne_MoreThanFiveYears_OldMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountOld(100, 1, 10);
            Assert.AreEqual(result, 100m);
        }

        [TestMethod]
        public void When_TypeIsTwo_MoreThanFiveYears_OldMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountOld(100, 2, 10);
            Assert.AreEqual(result, 85.500m);
        }

        [TestMethod]
        public void When_TypeIsThree_MoreThanFiveYears_OldMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountOld(100, 3, 10);
            Assert.AreEqual(result, 66.500m);
        }

        [TestMethod]
        public void When_TypeIsFour_MoreThanFiveYears_OldMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountOld(100, 4, 10);
            Assert.AreEqual(result, 47.500m);
        }

        [TestMethod]
        public void When_TypeIsOne_LessThanFiveYears_OldMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountOld(100, 1, 4);
            Assert.AreEqual(result, 100m);
        }

        [TestMethod]
        public void When_TypeIsTwo_LessThanFiveYears_OldMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountOld(100, 2, 4);
            Assert.AreEqual(result, 86.400m);
        }

        [TestMethod]
        public void When_TypeIsThree_LessThanFiveYears_OldMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountOld(100, 3, 4);
            Assert.AreEqual(result, 67.200m);
        }

        [TestMethod]
        public void When_TypeIsFour_LessThanFiveYears_OldMethod_ShouldBeCorrect()
        {
            var result = _calculateService.CalculateDiscountOld(100, 4, 4);
            Assert.AreEqual(result, 48m);
        }
    }
}