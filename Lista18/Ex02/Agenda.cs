using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Agenda
    {
        Compromisso[] compromissos = new Compromisso[30];
        private int k;
        public int Qtd { get => k; }
        public void Inserir(Compromisso c)
        {
            compromissos[k++] = c;
        }
        public void Excluir(Compromisso c)
        {
            int p = Array.IndexOf(compromissos, c);
            for(int i = p; i < k; i++)
            {
                compromissos[i] = compromissos[i + 1];
            }
            compromissos[k] = null;
            k--;
        }
        public Compromisso[] Listar()
        {
            Compromisso[] novo = new Compromisso[k];
            Array.Copy(compromissos, novo, k);
            return novo;
        }
        public Compromisso[] Pesquisar(int m, int a)
        {
            int cont = 0;
            Compromisso[] vt1 = new Compromisso[k];
            for (int i = 0; i < k; i++)
            {
                if (compromissos[i].data.Month == m && compromissos[i].data.Year == a)
                    vt1[cont++] = compromissos[i];
            }
            Compromisso[] novo = new Compromisso[k];
            Array.Copy(vt1, novo, cont);
            return novo;
        }
    }
}
