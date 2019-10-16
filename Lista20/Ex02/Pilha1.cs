using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Pilha1<T>
    {
        private List<T> lista = new List<T>();
        public int Count()
        {
            return lista.Count;
        }
        public void Pop(T ele)
        {
            lista.Remove(ele);
        }
        public void Push(T ele)
        {
            lista.Add(ele);
        }
        public T Top()
        {
            return lista[0];
        }
    }
}
