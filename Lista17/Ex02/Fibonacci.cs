using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Fibonacci
    {
        int x, y, z;
        public void Iniciar()
        {
            x = 0;
            y = 1;
            z = 0;
        }
        public int Proximo()
        {
            z = y + x;
            x = y;
            y = z;
            return z;
        }
    }
}
