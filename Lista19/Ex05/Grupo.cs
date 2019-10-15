using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Grupo
    {
        private string descricao;
        private Contato[] contatos = new Contato[100];
        private int k;
        public Grupo(string d) { descricao = d; }
        public void Adicionar(Contato c)
        {

            if (k < 100 && Array.IndexOf(contatos, c) == -1) contatos[k++] = c;
        }
        public void Excluir(Contato c)
        {
            int p = Array.IndexOf(contatos, c);
            for (int i = p + 1; i < k; i++)
            {
                contatos[i - 1] = contatos[i];
            }
            k--;
        }
        public Contato[] ListarContatos()
        {
            Contato[] novo = new Contato[k];
            Array.Copy(contatos, novo, k);
            return novo;
        }
        public override string ToString()
        {
            return $"{descricao} - {k} contatos";
        }
    }
}
