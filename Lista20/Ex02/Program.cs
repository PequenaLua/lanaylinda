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
            Pilha1<int> v = new Pilha1<int>();
            v.Push(11);
            v.Push(5);
            v.Push(15);
            v.Push(18);
            v.Push(9);
            v.Push(52);
            Console.WriteLine(v.Top());
            Console.WriteLine(v.Count());
            Console.ReadKey();
        }
    }
}
