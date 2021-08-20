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
        public readonly SmartContext _context1;
        public ProfessorController(SmartContext context1)
        {
            _context1 = context1;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context1.Professores);
        }
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _context1.Professores.FirstOrDefault(a => a.Id == id);
            if (professor == null) return BadRequest("Aluno não encontrado");
            return Ok(professor);
        }
        [HttpGet("byName")]
        public IActionResult GetByName(string nome)
        {
            var professor = _context1.Professores.FirstOrDefault(a => a.Nome.Contains(nome));
            if (professor == null) return BadRequest("Aluno não encontrado");
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _context1.Add(professor);
            _context1.SaveChanges();
            return Ok(professor);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _context1.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (prof == null) return BadRequest("Professor não encontrado");
            _context1.Update(professor);
            _context1.SaveChanges();
            return Ok(prof);
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _context1.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (prof == null) return BadRequest("Professor não encontrado");
            _context1.Update(professor);
            _context1.SaveChanges();
            return Ok(prof);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var prof = _context1.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (prof == null) return BadRequest("Professor não encontrado");
            _context1.Remove(prof);
            _context1.SaveChanges();
            return Ok(prof);
        }
    }
}