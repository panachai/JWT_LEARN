using Microsoft.AspNetCore.Mvc;

namespace JWT_LEARN.Controllers
{
    [Route("Health")]
    [ApiController]
    public class Health : ControllerBase
    {
        [Route("")]
        public string HealthCheck()
        {
            return "Up";
        }
    }
}