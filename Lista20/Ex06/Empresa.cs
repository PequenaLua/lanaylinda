using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Empresa
    {
        private List<Cliente> clientes = new List<Cliente>();
        public void Inserir(Cliente c)
        {
            clientes.Add(c);
        }
        public void Excluir(Cliente c)
        {
            clientes.Remove(c);
        }
        public void Socios(Cliente x, Cliente y)
        {
            x.Inserir(y);
            y.Inserir(x);
        }
        public List<Cliente> ListarNomes()
        {
            List<Cliente> ordenado = clientes.OrderBy(Cliente => Cliente.Nome).ToList();
            return ordenado;
        }
        public List<Cliente> ListarLimite()
        {
            List<Cliente> ordenado = clientes.OrderByDescending(Cliente => Cliente.LimiteTotal).ToList();
            return ordenado;
        }
        public List<Cliente> ListarNaoSocio()
        {
            List<Cliente> novo = new List<Cliente>();
            foreach (Cliente cl in clientes)
            {
                if (cl.NumSocios == 0) novo.Add(cl);
            }
            return novo;
        }
    }
}
