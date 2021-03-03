using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public AlunoController(){}
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Alunos: João e Mário");
        }
    }
}