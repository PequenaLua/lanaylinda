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
            la.Add(a);
            p.Save(la);
        }
        public void Update(Autor a)
        {
            List<Autor> la = p.Open();
            for(int i = 0; i < la.Count; i++)
            {
                if(a.Id == la[i].Id)
                {
                    la.RemoveAt(i);
                    break;
                }
            }
            la.Add(a);
            p.Save(la);
        }
        public void Delete(Autor a)
        {
            List<Autor> la = p.Open();
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
