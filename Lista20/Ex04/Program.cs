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
            Agenda a = new Agenda();
            for(int i = 0; i < 5; i++)
            {
                Contato x = new Contato();
                x.Nome = Console.ReadLine();
                x.Email = Console.ReadLine();
                x.Fone = Console.ReadLine();
                a.Inserir(x);
            }
            foreach (Contato i in a.Listar()) Console.WriteLine(i);
            Console.WriteLine();
            foreach (Contato i in a.Pesquisar(Console.ReadLine())) Console.WriteLine(i); ;
            Console.ReadKey();
        }
    }
}
