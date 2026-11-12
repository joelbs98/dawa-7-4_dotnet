using Microsoft.AspNetCore.Mvc;

namespace TaskFlowApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                proyecto = "TaskFlow",
                materia = "Desarrollo de Aplicaciones Web Avanzado",
                backend = "ASP.NET Core"
            });
        }
    }
}