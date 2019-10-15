using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Contato
    {
        private string nome;
        private string fone;
        public Contato(string n, string f)
        {
            nome = n;
            fone = f;
        }
        public override string ToString()
        {
            return $"{nome} - {fone}";
        }
    }
}
