using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Livraria
    {
        private string nome;
        private Livro[] livros = new Livro[100];
        private int k;
        public int Qtd { get => k; }
        public Livraria(string n)
        {
            nome = n;
        }
        public void Inserir(Livro l)
        {
             if(k < 100)livros[k++] = l;
        }
        public void Remover(Livro l)
        {
            int p = Array.IndexOf(livros, l);
            for(int i = p;i < k-1; i++)
            {
                livros[i] = livros[i + 1];
            }
            k--;
        }
        public Livro[] Listar()
        {
            Livro[] novo = new Livro[k];
            Array.Copy(livros, novo, k);
            Array.Sort(novo, new TituloComp());
            return novo;
        }
        public Livro[] ListarGenero()
        {
            Livro[] novo = new Livro[k];
            Array.Copy(livros, novo, k);
            Array.Sort(novo, new GeneroComp());
            return novo;
        }
        public Livro[] Top10Vendidos()
        {
            Livro[] novo = new Livro[k];
            Array.Copy(livros, novo, k);
            Array.Sort(novo);
            if(k > 10)
            {
                Livro[] novo2 = new Livro[k];
                Array.Copy(novo, novo2, 10);
                return novo2;
            }
            return novo;
        }
    }
}
