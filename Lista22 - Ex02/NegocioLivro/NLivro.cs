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
            int id = 1;
            if(la.Count > 1) id = la.Max(x => x.Id) + 1;
            a.Id = id;
            la.Add(a);
            p.Save(la);
        }
        public void Update(Livro a)
        {
            List<Livro> la = p.Open();
            Livro l = la.Where(x => x.Id == a.Id).Single();
            la.Remove(l);
            la.Add(a);
            p.Save(la);
        }
        public void Delete(Livro a)
        {
            List<Livro> la = p.Open();
            Livro l = la.Where(x => x.Id == a.Id).Single();
            la.Remove(l);
            p.Save(la);
        }
    }
}
