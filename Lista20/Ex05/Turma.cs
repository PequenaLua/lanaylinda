using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Turma: IComparable
    {
        private string semestre;
        private string disciplina;
        public Turma(string d, string s)
        {
            semestre = s;
            disciplina = d;
        }
        private List<Aluno> alunos = new List<Aluno>();
        public int NumAlunos { get => alunos.Count; }
        public void AdicionarAluno(Aluno a)
        {
            alunos.Add(a);
        }
        public Aluno[] ListarAlunos()
        {
            Aluno[] novo = alunos.ToArray();
            Array.Sort(novo);
            return novo;
        }
        public override string ToString()
        {
            return $"{disciplina} - {semestre}° semestre";
        }
        public int CompareTo(object c)
        {
            Turma novo = c as Turma;
            return this.disciplina.CompareTo(novo.disciplina);
        }
    }
}
