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
            Conversor c = new Conversor();            
            c.SetNum(int.Parse(Console.ReadLine()));
            Console.WriteLine(c.Binario());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
