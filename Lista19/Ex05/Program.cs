using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario("Paulo", "988989587");
            Usuario u1 = new Usuario("Daniel", "987949979");
            u.InserirContato(u1);
            u1.InserirContato(u);
            foreach (Contato i in u.ListarContatos()) Console.WriteLine(i);
            Grupo g = new Grupo("Grupo não sei");
            u.InserirGrupo(g);
            g.Adicionar(u);
            g.Adicionar(u1);
            u1.InserirGrupo(g);
            foreach (Grupo i in u.ListarGrupos()) Console.WriteLine(i);
            foreach (Grupo i in u1.ListarGrupos()) Console.WriteLine(i);
            foreach (Contato i in g.ListarContatos()) Console.WriteLine(i);
            g.Excluir(u1);
            g.Adicionar(u);
            Console.WriteLine();
            foreach (Grupo i in u.ListarGrupos()) Console.WriteLine(i);
            foreach (Contato i in g.ListarContatos()) Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
