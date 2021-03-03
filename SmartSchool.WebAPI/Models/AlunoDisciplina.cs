namespace SmartSchool.WebAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }
        public AlunoDisciplina(int alunoId, Aluno aluno, int disciplinaId, Disciplina disciplina)
        {
            this.alunoId = alunoId;            
            this.disciplinaId = disciplinaId;
        }
        public int alunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int disciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}