using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        //alunos
        public Aluno[] GetAllAlunos(bool includeProfessor = false);
        public Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);
        public Aluno[] GetAlunoById(int alunoId, bool includeProfessor = false);

        //professores
        public Professor[] GetAllProfessor(bool includeAluno = false);
        public Professor[] GetAllProfessorByDisciplinaId(int disciplinaId, bool includeAluno = false);
        public Professor[] GetProfessorByID(int professorId, bool includeAluno = false);

    }
}
