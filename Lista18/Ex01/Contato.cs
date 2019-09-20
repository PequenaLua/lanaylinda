using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Contato
    {
        private string nome, email;
        private DateTime nascimento;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }
        public int Idade
        {
            get
            {
                DateTime x = DateTime.Now;
                if ((x.Month > nascimento.Month) || (x.Month == nascimento.Month && x.Day > nascimento.Day)) return x.Year - nascimento.Year;
                return x.Year - nascimento.Year - 1;
            }
        }
        public override string ToString()
        {
            return $"{nome} - {email} - {nascimento:dd/MM/yyyy} - {Idade}";
        }
    }
}
