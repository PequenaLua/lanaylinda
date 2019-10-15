using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Cliente
    {
        private string nome;
        private string cpf;
        private decimal limite;
        public string Nome { get => nome; }
        private List<Cliente> socios = new List<Cliente>();
        public decimal LimiteTotal { get => limite; }
        public int NumSocios { get => socios.Count; }
        public Cliente(string n, string c, decimal l)
        {
            nome = n;
            cpf = c;
            limite = l;
        }
        public void Inserir(Cliente c)
        {
            socios.Add(c);
        }
        public void Excluir(Cliente c)
        {
            socios.Remove(c);
        }
        public override string ToString()
        {
            return $"{nome} - {cpf} - {limite} R$";
        }
    }
}
