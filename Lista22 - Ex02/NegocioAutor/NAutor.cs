using System;
using System.Collections.Generic;
using System.Linq;
using ModeloAutor;
using PersistenciaAutor;
using System.Text;
using System.Threading.Tasks;

namespace NegocioAutor
{
    public class NAutor
    {
        private List<Autor> v = new List<Autor>();
        private PAutor p = new PAutor();
        public List<Autor> Select()
        {
            return p.Open().OrderBy(Autor => Autor.Id).ToList();
        }
        public void Insert(Autor a)
        {
            List<Autor> la = p.Open();
            int id = 1;
            if (la.Count > 0) id = la.Max(x => x.Id) + 1;
            a.Id = id;
            la.Add(a);
            p.Save(la);
        }
        public void Update(Autor a)
        {
            List<Autor> la = p.Open();
            Autor au = la.Where(x => x.Id == a.Id).Single();
            la.Remove(au);
            la.Add(a);
            p.Save(la);
        }
        public void Delete(Autor a)
        {
            List<Autor> la = p.Open();
            Autor au = la.Where(x => x.Id == a.Id).Single();
            la.Remove(au);
            p.Save(la);
        }
    }
}
