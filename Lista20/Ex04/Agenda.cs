using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Agenda
    {
        private List<Contato> cs = new List<Contato>();
        public void Inserir(Contato c)
        {
            cs.Add(c);
        }
        public List<Contato> Listar()
        {
            return cs;
        }
        public List<Contato> Pesquisar(string inicio)
        {
            List<Contato> novo = new List<Contato>();
            foreach (Contato i in cs)
            {
                string priLetra = i.Nome.Substring(0, 1);
                novo.Add(i);
            }
            return novo;
        }
    }
}
