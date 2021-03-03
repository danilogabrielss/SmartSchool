using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController(){}
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professor: Alfredo e Jubileu");
        }
    }
}