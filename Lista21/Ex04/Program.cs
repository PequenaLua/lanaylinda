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
            try
            {
                Jogo jg = new Jogo("Fut");
                Jogador j = new Jogador("Paulo", "paulo@email.com");
                j.SetPontos(12, DateTime.Parse("16/10/2019"));
                Jogador j1 = new Jogador("Daniel", "daniel@email.com");
                j1.SetPontos(12, DateTime.Parse("17/10/2019"));
                jg.Inserir(j);
                jg.Inserir(j1);
                foreach (Jogador i in jg.Listar()) Console.WriteLine(i);
                Console.ReadKey();
            }
            catch(ArgumentOutOfRangeException erro)
            {
                Console.WriteLine(erro.Message);
                Console.ReadKey();
            }
            catch(EmailExistenteException erro)
            {
                Console.WriteLine(erro.Message);
                Console.ReadKey();
            }
        }
    }
}
