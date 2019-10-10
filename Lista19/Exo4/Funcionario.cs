using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4
{
    class Funcionario
    {
        private string nome;
        private string email;
        private string fone;
        public void SetNome(string n) { nome = n; }
        public string GetNome() { return nome; }
        public void SetEmail(string e) { email = e; }
        public string GetEmail() { return email; }
        public void SetFone(string f) { fone = f; }
        public string GetFone() { return fone; }
        public override string ToString()
        {
            return $"{nome} - {email} - {fone}";
        }
    }
}
