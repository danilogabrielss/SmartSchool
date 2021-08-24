using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SmartSchool.WebAPI.Models;
using SmartSchool.WebAPI.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace SmartSchool.WebAPI.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public readonly IRepository _repo;

        public AlunoController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetAllAlunos(true));
        }

        //http://localhost:5000/api/Aluno/byId/1
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _repo.GetAlunoById(id, true);
            if (aluno == null) return BadRequest("O aluno não foi encontrado.");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _repo.Add(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }
            return BadRequest("Aluno não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alu = _repo.GetAlunoById(id, true);
            if (alu == null) return BadRequest("O aluno não foi encontrado.");

            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }
            return BadRequest("Aluno não modificado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var alu = _repo.GetAlunoById(id, true);
            if (alu == null) return BadRequest("O aluno não foi encontrado.");
            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }
            return BadRequest("Aluno não modificado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var alu = _repo.GetAlunoById(id, true);
            if (alu == null) return BadRequest("O aluno não foi encontrado.");

            _repo.Delete(alu);
            if (_repo.SaveChanges())
            {
                return Ok("Aluno removido");
            }
            return BadRequest("Aluno não deletado");
        }
    }
}