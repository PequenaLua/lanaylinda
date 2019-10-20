using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Jogo
    {
        private string nome;
        private List<Jogador> jogs = new List<Jogador>();
        public Jogo(string n)
        {
            nome = n;
        }
        public void Inserir(Jogador j)
        {
            foreach (Jogador i in jogs) if (j.Email == i.Email) throw new EmailExistenteException("Email inválido");
            jogs.Add(j);
            jogs.Sort();
        }
        public List<Jogador> Listar()
        {
            return jogs;
        }
        
    }
}
