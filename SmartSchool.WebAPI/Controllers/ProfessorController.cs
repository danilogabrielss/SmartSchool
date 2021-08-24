using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using System.Linq;

namespace SmartSchool.WebAPI.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public IRepository _repo;
        public ProfessorController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetAllProfessor(true));
        }
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var prof = _repo.GetProfessorByID(id, false);
            if (prof == null) return BadRequest("Aluno n�o encontrado");
            return Ok(prof);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repo.Add(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }
            return BadRequest("Aluno não cadastrado");
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _repo.GetProfessorByID(id, false);
            if (prof == null) return BadRequest("Professor n�o encontrado");
            _repo.Update(professor);
            _repo.SaveChanges();
            return Ok(prof);
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _repo.GetProfessorByID(id, true);
            if (prof == null) return BadRequest("Professor n�o encontrado");
            _repo.Update(professor);
            _repo.SaveChanges();
            return Ok(prof);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var prof = _repo.GetProfessorByID(id, false);
            if (prof == null) return BadRequest("Professor n�o encontrado");
            _repo.Delete(prof);
            _repo.SaveChanges();
            return Ok(prof);
        }
    }
}