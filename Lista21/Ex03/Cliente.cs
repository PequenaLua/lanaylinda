using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Cliente
    {
        private string nome, email, fone;
        private List<Conta> contas = new List<Conta>();
        public Cliente(string n, string e, string f)
        {
            nome = n;
            email = e;
            fone = f;
        }
        public void Inserir(Conta c)
        {
            contas.Add(c);
        }
        public void Excluir(Conta c)
        {
            contas.Remove(c);
        }
        public Conta[] Listar()
        {
            return contas.ToArray();
        }
    }
}
