using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Dicionario<K,V>
    {
        private List<K> chaves = new List<K>();
        private List<V> valores = new List<V>();

        public List<K> Chaves { get => chaves; }
        public int Count { get => valores.Count; }

        public V this[K chave]
        {
            get
            {
                if (chaves.IndexOf(chave) == -1) throw new InvalidOperationException("Chave informada não existe");
                return valores[chaves.IndexOf(chave)];

            }
            set
            {
                if (chaves.Contains(chave)) valores[chaves.IndexOf(chave)] = value;
                else
                { chaves.Add(chave); valores.Add(value); }
            }
        }

        public void Add(K chave, V valor)
        {
            if (chave == null) throw new ArgumentNullException("A chave informada não pode ser nula");
            if (chaves.Contains(chave)) throw new InvalidOperationException("A chave já existe no dicionário");

            chaves.Add(chave);
            valores.Add(valor);
        }

        public void Clear()
        {
            chaves.Clear();
            valores.Clear();
        }

        public bool Contains(K chave)
        {
            return chaves.Contains(chave);
        }

        public bool Remove(K chave)
        {
            if (chaves.Contains(chave))
            {
                valores.RemoveAt(chaves.IndexOf(chave));
                chaves.Remove(chave);
                return true;
            }
            else return false;
        }
    }
}
