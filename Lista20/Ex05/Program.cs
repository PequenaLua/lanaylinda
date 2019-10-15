using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso c = new Curso("infoweb");
            Turma t = new Turma("PEOO", "1");
            c.AdicionarTurma(t);
            Turma t1 = new Turma("Banco de dados", "1");
            c.AdicionarTurma(t1);
            foreach (Turma tu in c.ListarTurmas()) Console.WriteLine(tu);
            Aluno a = new Aluno();
            a.nome = "PPL";
            a.matricula = "2018011110032";
            t.AdicionarAluno(a);
            Aluno a1 = new Aluno();
            a1.nome = "Luca";
            a1.matricula = "2018011110003";
            t.AdicionarAluno(a1);
            foreach (Aluno tu in t.ListarAlunos()) Console.WriteLine(tu);
            Console.ReadKey();
        }
    }
}
