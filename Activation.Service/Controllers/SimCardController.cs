using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Activation.Microservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimCardController : ControllerBase
    {
        private readonly ILogger<SimCardController> _logger;

        public SimCardController(ILogger<SimCardController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<int> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5)
                .Select(_=>_)
                .ToArray();
        }

        [HttpPost]
      //  [Route("Activate/{cardNumber}")]
        public IEnumerable<int> Activate(string cardNumber)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5)
                .Select(_ => _)
                .ToArray();
        }
    }
}
