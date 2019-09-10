using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista17
{
    class DisciplinaSemestral : IMedia
    {
        private string nome;
        private int nota1, nota2, notaF;
        public DisciplinaSemestral(string n, int n1, int n2, int nF)
        {
            nome = n;
            nota1 = n1;
            nota2 = n2;
            notaF = nF;
        }
        public override string ToString()
        {
            return $"{nome} {nota1} {nota2} {notaF}";
        }
        public int GetMedia()
        {
            int m = (nota1 * 2 + nota2 * 3) / 5;
            if (m < 60) m = (m + notaF) / 2;
            return m;
        }
    }
}
