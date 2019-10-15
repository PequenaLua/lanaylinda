using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Construtota
    {
        private List<Funcionario> funcs = new List<Funcionario>();
        public void Inserir(Funcionario f)
        {
            funcs.Add(f);
        }
        public List<Funcionario> Funcionarios() { return funcs; }
        public List<Motorista> Motoristas()
        {
            List<Motorista> nova = new List<Motorista>();
            foreach (Funcionario i in funcs)
            {
                if (i != null && i is Motorista) nova.Add(i as Motorista);
            }
            return nova;
        }
        public List<Engenheiro> Engenheiros()
        {
            List<Engenheiro> nova = new List<Engenheiro>();
            foreach (Funcionario i in funcs)
            {
                if (i != null && i is Engenheiro) nova.Add(i as Engenheiro);
            }
            return nova;
        }
    }
}
