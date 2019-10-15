using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
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
                if(i.Validade <= dt.Date)novo.Add(i);
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
    class Produto
    {
        private string descricao;
        private decimal preco;
        private int qtd;
        private DateTime validade;
        public string Descricao{ get => descricao; }
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
    class Program
    {
        static void Main(string[] args)
        {
            Estoque e = new Estoque();
            Produto p = new Produto("Bis", 5, 50, DateTime.Parse("5/11/2019"));
            Produto p1 = new Produto("Arroz", 3, 100, DateTime.Parse("10/09/2019"));
            Produto p2 = new Produto("Nutella", 9, 75, DateTime.Parse("04/03/2020"));
            Produto p3 = new Produto("Feijao", 6, 90, DateTime.Parse("14/10/2019"));
            e.Inserir(p);
            e.Inserir(p1);
            e.Inserir(p2);
            e.Inserir(p3);
            foreach (Produto i in e.ListarDescricao()) Console.WriteLine(i);
            Console.WriteLine();
            foreach (Produto i in e.ListarPreco()) Console.WriteLine(i);
            Console.WriteLine();
            foreach (Produto i in e.Vencidos()) Console.WriteLine(i);
            Console.WriteLine();
            foreach (Produto i in e.AVencer(30)) Console.WriteLine(i);
            Console.WriteLine();
            foreach (Produto i in e.EstoqueBaixo(80)) Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine($"{e.Total()} R$");
            Console.ReadKey();
        }
    }
}
