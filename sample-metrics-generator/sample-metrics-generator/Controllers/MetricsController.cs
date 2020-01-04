using Microsoft.AspNetCore.Mvc;

namespace sample_metrics_generator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetricsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "sample 42.0";
        }
    }
}
