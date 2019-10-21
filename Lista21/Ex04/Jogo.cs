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
        }
        public List<Jogador> Listar()
        {
            jogs.Sort();
            return jogs;
        }
        public Jogador Top1()
        {
            return jogs[0];
        }
        public List<Jogador> Top10()
        {
            jogs.Sort();
            List<Jogador> novo = new List<Jogador>();
            for(int i = 0; i < 10; i++)
            {
                novo.Add(jogs[i]);
            }
            return novo;
        }
        public override string ToString()
        {
            return $"{nome} - {jogs.Count} jogadores";
        }
    }
}
