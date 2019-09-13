using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Loja
    {
        private string nome;
        private Veiculo[] vcls = new Veiculo[15];
        private int n;
        public void SetNome(string nome) { this.nome = nome; }
        public void Inserir(Veiculo v)
        {
            if(n < 15)
            {
                vcls[n++] = v;
            }
        }
        public Veiculo[] Listar()
        {
            Veiculo[] vet = new Veiculo[n];
            Array.Copy(vcls, vet, n);
            return vet;
        }
        public Veiculo[] ListarValor(decimal precoMax)
        {
            int g = 0;
            Veiculo[] vet1 = new Veiculo[15];
            for(int i = 0; i < n; i++)
            {
                if(vcls[i].GetVendido() == false && vcls[i].GetPreco() <= precoMax)
                {
                    vet1[g] = vcls[i];
                    g++;
                }
            }
            Veiculo[] vet2 = new Veiculo[g];
            Array.Copy(vet1, vet2, g);
            return vet2;
        }
        public decimal Total()
        {
            decimal total = 0;
            for(int i = 0; i < n; i++)
            {
                if (vcls[i].GetVendido() == false)
                {
                    total += vcls[i].GetPreco();
                }
            }
            return total;
        }
    }
    class Veiculo
    {
        private string placa;
        private string fabricante;
        private string modelo;
        private int ano;
        private decimal preco;
        private bool vendido;
        public void SetPlaca(string p) { placa = p; }
        public void SetFabricante(string f) { fabricante = f; }
        public void SetModelo(string m) { modelo = m; }
        public void SetAno(int a) { ano = a; }
        public void SetPreco(decimal p) { preco = p; }
        public void SetVendido(bool v) { vendido = v; }
        public void Vender() {vendido = true;}
        public bool GetVendido(){return vendido;}
        public decimal GetPreco() { return preco; }
        public override string ToString()
        {
            if(vendido == true)
            return ($"{placa} | {fabricante} | {modelo} | {ano} | R$ {preco} | Vendido");
            else
            return ($"{placa} | {fabricante} | {modelo} | {ano} | R$ {preco} | Não vendido");
        }
    }
}
