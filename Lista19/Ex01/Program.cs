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
            Retangulo r = new Retangulo(4, 5);
            Console.WriteLine(r.CalcArea());
            Console.WriteLine(r.CalcDiagonal());

            Console.WriteLine();

            Quadrado q = new Quadrado(8);
            Console.WriteLine(q.CalcArea());
            Console.WriteLine(q.CalcDiagonal());
            Console.ReadKey();
        }
    }
}
