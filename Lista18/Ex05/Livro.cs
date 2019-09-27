using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Livro: IComparable
    {
        private string titulo, genero;
        private double preco;
        private int vendidos;
        public string Titulo { get => titulo; }
        public int Vendidos { get { return vendidos; } }
        public Livro(string t, string g, int p)
        {
            titulo = t;
            genero = g;
            preco = p;
        }
        public void Vender()
        {
            vendidos++;
        }
        public override string ToString()
        {
            return $"{titulo} - {genero} - {preco} - {vendidos} vendidos";
        }
        public string GetGenero() { return genero; }
        public int CompareTo(object obj)
        {
            Livro outro = obj as Livro;
            if (this.vendidos > outro.vendidos) return -1;
            if (this.vendidos < outro.vendidos) return 1;
            return this.titulo.CompareTo(outro.titulo);
        }

    }
}
