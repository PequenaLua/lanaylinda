using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Engenheiro: Funcionario
    {
        private string crea;
        public void SetCrea(string c) { crea = c; }
        public string GetCrea() { return crea; }
        public override string ToString()
        {
            return $"{GetNome()} - {GetEmail()} - {GetFone()} - {crea}";
        }
    }
}
