using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            ITeste t = new Teste();
            try
            {

                Console.WriteLine(t.Metodo1(int.Parse(Console.ReadLine())));
                Console.ReadKey();
            }
            catch (Erro)
            {
                Console.WriteLine("Valor negativo");
                Console.ReadKey();
            }
        }
    }
}
