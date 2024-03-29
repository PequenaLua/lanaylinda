﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Retangulo
    {
        private double b;
        private double h;
        public Retangulo(double b, double h)
        {
            if (b > 0) this.b = b;
            if (h > 0) this.h = h;
        }
        public double GetBase() { return b; }
        public double GetAltura() { return h; }
        public double CalcArea()
        {
            return b * h;
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt(b * b + h * h);
        }
        public override string ToString()
        {
            return $"{b} - {h}";
        }
    }
}
