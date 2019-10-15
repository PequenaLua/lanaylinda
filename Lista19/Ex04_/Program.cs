using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Construtota c = new Construtota();
            Engenheiro e = new Engenheiro();
            e.SetNome("Paulo");
            e.SetEmail("pdanielcdo@gmail.com");
            e.SetFone("988989587");
            e.SetCrea("443467");
            c.Inserir(e);

            Motorista m = new Motorista();
            m.SetNome("Daniel");
            m.SetEmail("pdanielcdo@hotmail.com");
            m.SetFone("987949979");
            m.SetCnh("1316413");
            c.Inserir(m);

            foreach (Funcionario f in c.Funcionarios()) Console.WriteLine(f);
            Console.WriteLine();
            foreach (Funcionario f in c.Motoristas()) Console.WriteLine(f);
            Console.WriteLine();
            foreach (Funcionario f in c.Engenheiros()) Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
