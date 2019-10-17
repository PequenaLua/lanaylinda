using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        public void Salvar(string arquivo)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Contato>));
            StreamWriter f = new System.IO.StreamWriter(arquivo, false, Encoding.Default);
            f.Close();
        }
    }
}
