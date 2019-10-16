using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07___WPF
{
    class Veiculo
    {
        private string placa;
        private string fabricante;
        private string modelo;
        private int ano;
        private decimal preco;
        private bool vendido = false;
        public string Placa { get => placa; }
        public string Fabricante { get => fabricante; }
        public string Modelo { get => modelo; }
        public decimal Preco { get => preco; }
        public Veiculo(string p, string f, string m, int a, decimal pr)
        {
            placa = p;
            fabricante = f;
            modelo = m;
            ano = a;
            preco = pr;
        }
        public void Vender() { vendido = true; }
        public override string ToString()
        {
            return $"{placa} - {fabricante} - {modelo} - {ano} - {preco}";
        }
    }
}
