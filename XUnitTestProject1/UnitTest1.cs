using CoreWebEmptyApp.Controllers;
using CoreWebEmptyApp.Interfaces;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class HomeControllerTest
    {
        Mock<IPrimeFactor> primeFactorMock;
        HomeController homeController;
        public HomeControllerTest()
        {
            primeFactorMock = new Mock<IPrimeFactor>();
            homeController = new HomeController(primeFactorMock.Object);
        }

        [Fact]
        public async void GetPrimeFactor_ShouldReturnPrimeFactorList()
        {
            primeFactorMock.Setup(c => c.GetPrimeFactors(It.IsAny<int>())).Returns(new List<int>() { 2, 2, 2, 3 });
            var result = await homeController.GetPrimeFactor(24) as List<int>;
            Assert.NotNull(result);
            Assert.True(result.Count == 4);
        }
    }
}
