using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Cliente c = new Cliente("Paulo", "paulo@email.com", "988989587");
            Conta ct = new Conta("31465", 15000);
            c.Inserir(ct);
            ct.Sacar(15500);
            Console.ReadKey();
            }
            catch(InversaoSaldoException erro)
            {
                Console.WriteLine(erro.Message);
                Console.ReadKey();
            }
            catch(ArgumentOutOfRangeException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}
