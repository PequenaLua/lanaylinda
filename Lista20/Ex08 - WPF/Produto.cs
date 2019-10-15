using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08___WPF
{
    class Produto
    {
        private string descricao;
        private decimal preco;
        private int qtd;
        private DateTime validade;
        public string Descricao { get => descricao; }
        public decimal Preco { get => preco; }
        public DateTime Validade { get => validade; }
        public int Qtd { get => qtd; }
        public decimal Total { get => preco * qtd; }
        public Produto(string d, decimal p, int q, DateTime v)
        {
            descricao = d;
            preco = p;
            qtd = q;
            validade = v;
        }
        public bool GetVencido()
        {
            DateTime dt = DateTime.Now;
            if (validade < dt.Date) return true;
            return false;
        }
        public override string ToString()
        {
            return $"{descricao} - {preco} R$ - {qtd} - {validade: dd/MM/yyyy}";
        }
    }
}
