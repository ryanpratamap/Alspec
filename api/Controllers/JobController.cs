using api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        private IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var jobs = _jobService.GetAll();

            // Configure JsonSerializerOptions with ReferenceHandler.Preserve to handle cycles
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                MaxDepth = 32,
            };

            // Serialize your object using the custom options
            string json = JsonSerializer.Serialize(jobs, options);

            return Ok(json);
        }
    }
}
