using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Jogador: IComparable
    {
        private string nome, email;
        private int pontuacaoMaxima;
        private DateTime data;
        public string Email { get => email; }
        public Jogador(string n, string e)
        {
            nome = n;
            email = e;
        }
        public void SetPontos(int p, DateTime d)
        {
            if (p < 0) throw new ArgumentOutOfRangeException("p", "A pontuação não pode ser negativa");
            else pontuacaoMaxima = p;
            DateTime dt = DateTime.Now;
            if (d > dt) throw new ArgumentOutOfRangeException("d", "Esta data não é válida");
            else data = d;
        }
        public override string ToString()
        {
            return $"{nome} - {email} - {pontuacaoMaxima} - {data: dd/MM/yyyy}";
        }
        public int CompareTo(object obj)
        {
            Jogador novo = obj as Jogador;
            if (pontuacaoMaxima < novo.pontuacaoMaxima) return 1;
            if (pontuacaoMaxima > novo.pontuacaoMaxima) return -1;
            return data.CompareTo(novo.data);
        }
    }
}
