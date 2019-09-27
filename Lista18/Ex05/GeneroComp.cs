using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class GeneroComp: IComparer
    {
        public int Compare(object x, object y)
        {
            Livro a = x as Livro;
            Livro b = y as Livro;
            if (a.GetGenero().CompareTo(b.GetGenero()) != 0)
                return a.GetGenero().CompareTo(b.GetGenero());
            else
                return a.Titulo.CompareTo(b.Titulo);
        }
    }
}
