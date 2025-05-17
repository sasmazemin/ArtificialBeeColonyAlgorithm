using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialBeeColonyAlgorithm
{
    class AriBirey
    {
        public Pozisyon Konum { get; set; }
        public double Deger { get; set; }       // F(x,y)
        public double Uygunluk { get; set; }    // Fitness
        public double Olasilik { get; set; }    // Seçilme ihtimali
        public int EtkisizTur { get; set; }     // Kaç tur iyileşmedi?

        public AriBirey(Pozisyon konum)
        {
            Konum = konum;
            Deger = Fonksiyon(konum.X, konum.Y);
            Uygunluk = FitnessHesapla(Deger);
            EtkisizTur = 0;
        }

        public double Fonksiyon(double x, double y)
        {
            double t1 = Math.Pow(x + y + 1, 2);
            double t2 = 19 - 14 * x + 3 * x * x - 14 * y + 6 * x * y + 3 * y * y;
            double t3 = Math.Pow(2 * x - 3 * y, 2);
            double t4 = 18 - 32 * x + 12 * x * x + 48 * y - 36 * x * y + 27 * y * y;
            return (1 + t1 * t2) * (30 + t3 * t4);
        }

        public double FitnessHesapla(double fx)
        {
            return fx >= 0 ? 1 / (1 + fx) : 1 + Math.Abs(fx);
        }

        public void Guncelle(Pozisyon yeniKonum)
        {
            Konum = yeniKonum;
            Deger = Fonksiyon(Konum.X, Konum.Y);
            Uygunluk = FitnessHesapla(Deger);
        }
    }
}
