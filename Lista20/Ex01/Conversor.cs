using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Conversor
    {
        private int num;
        private Stack<int> pilha = new Stack<int>();
        public void SetNum(int n)
        {
            num = n;
        }
        public string Binario()
        {
            int s = num;
            pilha.Clear();
            string b = "";
            while (s > 0)
            {
                pilha.Push(s % 2);
                s /= 2;
            }
            foreach (int i in pilha) b += i;
            return b;
        }
    }
}
