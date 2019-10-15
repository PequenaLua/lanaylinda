using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Motorista: Funcionario
    {
        private string cnh;
        public void SetCnh(string c) { cnh = c; }
        public string GetCnh() { return cnh; }
        public override string ToString()
        {
            return $"{GetNome()} - {GetEmail()} - {GetFone()} - {cnh}";
        }
    }
}
