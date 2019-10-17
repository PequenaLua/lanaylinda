using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            try
            {
                r.SetBase(int.Parse(Console.ReadLine()));
                r.SetAltura(int.Parse(Console.ReadLine()));
                Console.WriteLine(r.CalcArea());
                Console.ReadKey();
            }
            catch(ArgumentOutOfRangeException erro)
            {
                Console.WriteLine(erro.Message);
                Console.ReadKey();
            }
        }
    }
}
