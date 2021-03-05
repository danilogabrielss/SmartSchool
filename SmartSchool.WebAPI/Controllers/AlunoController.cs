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
                Id = 1,
                Nome = "Joao",
                Sobrenome = "Abreu e Lima",
                Telefone = "151515166"
            },
            new Aluno () {
                Id = 2,
                Nome = "Marta",
                Sobrenome = "Alves",
                Telefone = "145265897"
            },
            new Aluno () {
                Id = 3,
                Nome = "Carlos",
                Sobrenome = "Nobrega",
                Telefone = "559952854"
            },
        };
        
        public AlunoController(){}
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (Aluno == null) return BadRequest("O aluno não foi encontrado.");

            return Ok(Aluno);
        }
    }
}