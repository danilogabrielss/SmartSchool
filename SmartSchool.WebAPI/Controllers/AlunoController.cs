using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SmartSchool.WebAPI.Models;
using System.Linq;

namespace SmartSchool.WebAPI.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno>Alunos = new  List<Aluno>(){
            new Aluno () {
                id = 1,
                nome = "Joao",
                sobrenome = "Abreu e Lima",
                telefone = "151515166"
            },
            new Aluno () {
                id = 2,
                nome = "Marta",
                sobrenome = "Alves",
                telefone = "145265897"
            },
            new Aluno () {
                id = 3,
                nome = "Carlos",
                sobrenome = "Nobrega",
                telefone = "559952854"
            },
        };
        
        public AlunoController(){}
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }
        
        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var Aluno = Alunos.FirstOrDefault(a => a.id == Id);
            if (Aluno == null) return BadRequest("O aluno não foi encontrado.");

            return Ok(Aluno);
        }
    }
}