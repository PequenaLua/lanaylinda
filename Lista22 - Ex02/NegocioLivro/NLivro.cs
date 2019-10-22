using ModeloLivro;
using PersistenciaLivro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioLivro
{
    public class NLivro
    {
        private List<Livro> v = new List<Livro>();
        private PLivro p = new PLivro();
        public List<Livro> Select()
        {
            return p.Open().OrderBy(Livro => Livro.Id).ToList();
        }
        public void Insert(Livro a)
        {
            List<Livro> la = p.Open();
            int m = 0;
            foreach (Livro i in la) if (i.Id > m) m = i.Id;
            a.Id = m + 1;
            la.Add(a);
            p.Save(la);
        }
        public void Update(Livro a)
        {
            List<Livro> la = p.Open();
            for (int i = 0; i < la.Count; i++)
            {
                if (a.Id == la[i].Id)
                {
                    la.RemoveAt(i);
                    break;
                }
            }
            la.Add(a);
            p.Save(la);
        }
        public void Delete(Livro a)
        {
            List<Livro> la = p.Open();
            for (int i = 0; i < la.Count; i++)
            {
                if (a.Id == la[i].Id)
                {
                    la.RemoveAt(i);
                    break;
                }
            }
            p.Save(la);
        }
    }
}
