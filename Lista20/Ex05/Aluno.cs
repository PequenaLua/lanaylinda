using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Aluno: IComparable
    {
        public string nome { get; set; }
        public string matricula { get; set; }
        public override string ToString()
        {
            return $"{nome} - {matricula}";
        }
        public int CompareTo(object c)
        {
            Aluno novo = c as Aluno;
            return this.nome.CompareTo(novo.nome);
        }
    }
}
