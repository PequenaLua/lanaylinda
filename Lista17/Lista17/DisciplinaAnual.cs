using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista17
{
    class DisciplinaAnual : IMedia
    {
        private string nome;
        private int nota1, nota2, nota3, nota4, notaF;
        public DisciplinaAnual(string n, int n1, int n2, int n3, int n4, int nF)
        {
            nome = n;
            nota1 = n1;
            nota2 = n2;
            nota3 = n3;
            nota4 = n4;
            notaF = nF;
        }
        public override string ToString()
        {
            return $"{nome} {nota1} {nota2} {nota3} {nota4} {notaF}";
        }
        public int GetMedia()
        {
            int m = (nota1 * 2 + nota2 * 2 + nota3 * 3 + nota4*3) / 10;
            if (m < 60) m = (m + notaF) / 2;
            return m;
        }
    }
}
