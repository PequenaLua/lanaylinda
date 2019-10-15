using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08___WPF
{
    class Estoque
    {
        List<Produto> produtos = new List<Produto>();
        public void Inserir(Produto p) { produtos.Add(p); }
        public void Excluir(Produto p) { produtos.Add(p); }
        public Produto[] ListarDescricao()
        {
            Produto[] novo = produtos.OrderBy(Produto => Produto.Descricao).ToArray();
            return novo;
        }
        public Produto[] ListarPreco()
        {
            Produto[] novo = produtos.OrderByDescending(Produto => Produto.Preco).ToArray();
            return novo;
        }
        public Produto[] Vencidos()
        {
            List<Produto> novo = new List<Produto>();
            foreach (Produto i in produtos) if (i.GetVencido() == true) novo.Add(i);
            Produto[] vet = novo.ToArray();
            return vet;
        }
        public Produto[] AVencer(int dias)
        {
            TimeSpan ts = new TimeSpan(dias, 0, 0, 0);
            DateTime dt = DateTime.Now;
            dt += ts;
            List<Produto> novo = new List<Produto>();
            foreach (Produto i in produtos)
            {
                if (i.Validade <= dt.Date) novo.Add(i);
            }
            Produto[] vet = novo.ToArray();
            return vet;
        }
        public Produto[] EstoqueBaixo(int min)
        {
            List<Produto> novo = new List<Produto>();
            foreach (Produto i in produtos) if (i.Qtd <= min) novo.Add(i);
            Produto[] vet = novo.ToArray();
            return vet;
        }
        public decimal Total()
        {
            decimal total = 0;
            foreach (Produto i in produtos) total += i.Total;
            return total;
        }
    }
}
