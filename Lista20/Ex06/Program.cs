using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa emp = new Empresa();
            Cliente c = new Cliente("Paulo", "7023502451", 3000m);
            Cliente c1 = new Cliente("Daniel", "7023502451", 2000m);
            emp.Inserir(c);
            emp.Inserir(c1);
            foreach (Cliente i in emp.ListarNomes()) Console.WriteLine(i);
            Console.WriteLine();
            foreach (Cliente i in emp.ListarLimite()) Console.WriteLine(i);

            // emp.Socios(c, c1);
            Console.WriteLine();
            foreach (Cliente i in emp.ListarNaoSocio()) Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
