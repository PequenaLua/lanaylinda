using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Pais: IComparable
    {
        private string nome;
        private int ouro, prata, bronze;
        public Pais(string nome, int ouro, int prata, int bronze)
        {
            this.nome = nome;
            this.ouro = ouro;
            this.prata = prata;
            this.bronze = bronze;
        }
        public override string ToString()
        {
            return $"{nome} - Ouro: {ouro} - Prata: {prata} - Bronze: {bronze}";
        }
        public int CompareTo(object obj)
        {
            Pais f = obj as Pais;
            if (this.ouro > f.ouro) return -1;
            if (this.ouro < f.ouro) return 1;
            if (this.prata > f.prata) return -1;
            if (this.prata < f.prata) return 1;
            if (this.bronze > f.bronze) return -1;
            if (this.bronze < f.bronze) return 1;
            else return this.nome.CompareTo(f.nome);
        }
    }
}
