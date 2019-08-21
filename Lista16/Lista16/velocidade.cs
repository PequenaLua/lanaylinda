using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista16
{
    class velocidade
    {
        private double km;
        private double h;
        public void SetDis(double km) {this.km = km;}
        public void SetTempo(double h) {this.h = h;}
        public double GetDis() {return km;}
        public double GetTempo() {return h;}
        public double CalcVelovidade()
        {
            return km/h;
        }
    }
}