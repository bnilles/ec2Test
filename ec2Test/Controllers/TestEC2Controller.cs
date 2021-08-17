using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ec2Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestEC2Controller : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TestEC2Controller> _logger;

        public TestEC2Controller(ILogger<TestEC2Controller> logger)
        {
            _logger = logger;
        }

        [Route("hello")]
        [HttpGet]
        public String Get()
        {
            var rng = new Random();
            return "here is a string with a random number added to the end: " + rng.Next();
        }
    }
}
