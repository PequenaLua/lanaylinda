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
            Frete f = new Frete(40, 5);
            Console.WriteLine(f.CalcFrete() + " R$");
            Console.WriteLine(f.ToString());
            Console.WriteLine();
            FreteExpresso fe = new FreteExpresso(40, 5, 20);
            Console.WriteLine(fe.CalcFrete() + " R$");
            Console.WriteLine(fe.ToString());
            Console.ReadKey();
        }
    }
}
