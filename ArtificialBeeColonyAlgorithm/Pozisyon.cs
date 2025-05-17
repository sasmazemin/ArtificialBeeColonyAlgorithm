using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialBeeColonyAlgorithm
{
    class Pozisyon
    {
        public double X;
        public double Y;

        public Pozisyon(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X:0.000}, {Y:0.000})";
        }

        // İki pozisyon arasındaki farkı veren metot
        public Pozisyon Fark(Pozisyon diger)
        {
            return new Pozisyon(this.X - diger.X, this.Y - diger.Y);
        }
    }
}
