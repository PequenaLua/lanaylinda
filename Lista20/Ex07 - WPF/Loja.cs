using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07___WPF
{
    class Loja
    {
        private string nome;
        private List<Veiculo> veiculos = new List<Veiculo>();
        public Loja(string n) { nome = n; }
        public void Inserir(Veiculo v)
        {
            veiculos.Add(v);
        }
        public void Excluir(Veiculo v)
        {
            veiculos.Remove(v);
        }
        public Veiculo[] Listar()
        {
            Veiculo[] novo = veiculos.ToArray();
            return novo;
        }
        public Veiculo[] ListarPorFabricante()
        {
            Veiculo[] v = veiculos.OrderBy(Veiculo => Veiculo.Fabricante).ThenBy(Veiculo => Veiculo.Modelo).ToArray();
            return v;
        }
        public Veiculo[] ListarPorModelo()
        {
            Veiculo[] v = veiculos.OrderBy(Veiculo => Veiculo.Modelo).ThenByDescending(Veiculo => Veiculo.Preco).ToArray();
            return v;
        }
        public decimal Total()
        {
            decimal total = 0;
            foreach (Veiculo i in veiculos)
            {
                total += i.Preco;
            }
            return total;
        }
        public Veiculo BuscarPlaca(string p)
        {
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (veiculos[i].Placa == p) return veiculos[i];
            }
            return null;
        }
        public Veiculo[] BuscarValor(decimal pMax)
        {
            List<Veiculo> novo = new List<Veiculo>();
            foreach (Veiculo i in veiculos) if (i.Preco <= pMax) novo.Add(i);
            Veiculo[] vet = novo.ToArray();
            return vet;
        }
    }
}
