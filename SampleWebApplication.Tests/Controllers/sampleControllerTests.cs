using System.Collections.Generic;
using SampleWebApplication.Controllers;
using SampleWebApplication.Models;
using Xunit;

namespace SampleWebApplication.Tests.Controllers
{
    public class SampleControllerTests
    {
        private readonly SampleController _controller;

        public SampleControllerTests()
        {
            _controller = new SampleController();
        }

        [Fact]
        public void Get_ReturnsSampleModels()
        {
            var result = _controller.Get();

            Assert.IsAssignableFrom<IEnumerable<SampleModel>>(result);
        }

        [Fact]
        public void GetById_returnsSampleModelWithPropperId()
        {
            const int testId = 12;
            var result = _controller.Get(testId);

            Assert.Equal(testId, result?.Id);
        }
    }
}