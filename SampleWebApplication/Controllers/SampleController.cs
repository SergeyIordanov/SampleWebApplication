using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Models;

namespace SampleWebApplication.Controllers
{
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<SampleModel> Get()
        {
            var sampleModels = new List<SampleModel>
            {
                new SampleModel { Id = 0, Name = "test-name" },
                new SampleModel { Id = 0, Name = "test-name" },
                new SampleModel { Id = 0, Name = "test-name" }
            };

            return sampleModels;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public SampleModel Get(int id)
        {
            return new SampleModel { Id = id, Name = "test-name" };
        }
    }
}