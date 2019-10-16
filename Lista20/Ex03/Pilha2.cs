using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Pilha2<T>
    {
        private Queue<T> q1 = new Queue<T>();
        private Queue<T> q2 = new Queue<T>();
        public int Count()
        {
            return q1.Count;
        }
        public T Top()
        {
            for (int i = 0; i < q1.Count - 1; i++)
            {
                q2.Enqueue(q1.Dequeue());
            }
            T r = q1.Peek();
            q2.Enqueue(q1.Dequeue());
            for (int i = 0; i < q2.Count; i++)
            {
                q1.Enqueue(q2.Dequeue());
            }
            return r;
        }

        public T Pop()
        {
            for (int i = 0; i < q1.Count - 1; i++)
            {
                q2.Enqueue(q1.Dequeue());
            }
            T r = q1.Peek();
            q1.Dequeue();
            for (int i = 0; i < q2.Count; i++)
            {
                q1.Enqueue(q2.Dequeue());
            }
            return r;
        }
        public void Push(T obj)
        {
            q1.Enqueue(obj);
        }
    }
}
