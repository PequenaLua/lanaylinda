using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Usuario: Contato
    {
        private Contato[] contatos = new Contato[100];
        private Grupo[] grupos = new Grupo[50];
        private int k;//k = contatos
        private int l;//l = grupos
        public Usuario(string n, string f) : base(n, f) { }
        public void InserirContato(Contato c)
        {
            if (k < 100 && Array.IndexOf(contatos, c) == -1) contatos[k++] = c;
        }
        public void InserirGrupo(Grupo g)
        {
            if (l < 50 && Array.IndexOf(grupos, g) == -1) grupos[l++] = g;
        }
        public Contato[] ListarContatos()
        {
            Contato[] novo = new Contato[k];
            Array.Copy(contatos, novo, k);
            return novo;
        }
        public Grupo[] ListarGrupos()
        {
            Grupo[] novo = new Grupo[l];
            Array.Copy(grupos, novo, l);
            return novo;
        }
        public override string ToString()
        {
            return base.ToString() + $" - {k} contatos - {l} grupos";
        }
    }
}
