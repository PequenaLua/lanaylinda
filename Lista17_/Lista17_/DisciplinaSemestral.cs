using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class DisciplinaSemestral : IMedia
    {
        private string nome;
        private int nota1, nota2, notaF;
        public DisciplinaSemestral(string n, int n1, int n2, int nf)
        {
            nome = n;
            nota1 = n1;
            nota2 = n2;
            notaF = nf;
        }
        public override string ToString()
        {
            return $"{nome} {nota1} {nota2} {notaF}";
        }
        public int GetMedia()
        {
            int m = (2 * nota1 + 3 * nota2) / 5;
            if (m < 60) m = (m + notaF) / 2;
            return m;
        }
    }
}