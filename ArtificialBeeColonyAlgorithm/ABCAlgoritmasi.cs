using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialBeeColonyAlgorithm
{
    class ABCAlgoritmasi
    {
        private int koloniBoyutu;
        private int altSinir, ustSinir;
        private int maxCevrim;
        private int maxEtkisizTur;
        private Random rnd = new Random();

        private List<AriBirey> arilar;

        public List<double> FxDegerleri { get; private set; } = new List<double>();
        public List<double> XListesi { get; private set; } = new List<double>();
        public List<double> YListesi { get; private set; } = new List<double>();

        public ABCAlgoritmasi(int koloniBoyutu, int altSinir, int ustSinir, int cevrim, int maxEtkisiz)
        {
            this.koloniBoyutu = koloniBoyutu;
            this.altSinir = altSinir;
            this.ustSinir = ustSinir;
            this.maxCevrim = cevrim;
            this.maxEtkisizTur = maxEtkisiz;

            arilar = new List<AriBirey>();
            KoloniBaslat();
            AlgoritmayiCalistir();
        }

        private void KoloniBaslat()
        {
            for (int i = 0; i < koloniBoyutu; i++)
            {
                Pozisyon poz = new Pozisyon(RastgeleDeger(), RastgeleDeger());
                arilar.Add(new AriBirey(poz));
            }
        }

        private double RastgeleDeger()
        {
            return rnd.NextDouble() * (ustSinir - altSinir) + altSinir;
        }

        private void AlgoritmayiCalistir()
        {
            for (int tur = 0; tur < maxCevrim; tur++)
            {
                GozlemciArilar();
                IsciArilar();
                ScouterArilar();

                AriBirey enIyi = EnIyiAri();
                FxDegerleri.Add(enIyi.Deger);
                XListesi.Add(enIyi.Konum.X);
                YListesi.Add(enIyi.Konum.Y);
            }
        }

        private void IsciArilar()
        {
            foreach (var ari in arilar)
            {
                Pozisyon yeni = YeniPozisyonUret(ari);
                double yeniDeger = ari.Fonksiyon(yeni.X, yeni.Y);
                double yeniUygunluk = ari.FitnessHesapla(yeniDeger);

                if (yeniUygunluk > ari.Uygunluk)
                {
                    ari.Guncelle(yeni);
                    ari.EtkisizTur = 0;
                }
                else
                {
                    ari.EtkisizTur++;
                }
            }
        }

        private void GozlemciArilar()
        {
            double toplamFit = 0;
            foreach (var ari in arilar)
                toplamFit += ari.Uygunluk;

            foreach (var ari in arilar)
                ari.Olasilik = ari.Uygunluk / toplamFit;

            for (int i = 0; i < arilar.Count; i++)
            {
                if (rnd.NextDouble() < arilar[i].Olasilik)
                {
                    Pozisyon yeni = YeniPozisyonUret(arilar[i]);
                    double yeniDeger = arilar[i].Fonksiyon(yeni.X, yeni.Y);
                    double yeniUygunluk = arilar[i].FitnessHesapla(yeniDeger);

                    if (yeniUygunluk > arilar[i].Uygunluk)
                    {
                        arilar[i].Guncelle(yeni);
                        arilar[i].EtkisizTur = 0;
                    }
                    else
                    {
                        arilar[i].EtkisizTur++;
                    }
                }
            }
        }

        private void ScouterArilar()
        {
            for (int i = 0; i < arilar.Count; i++)
            {
                if (arilar[i].EtkisizTur > maxEtkisizTur)
                {
                    Pozisyon yeni = new Pozisyon(RastgeleDeger(), RastgeleDeger());
                    arilar[i] = new AriBirey(yeni);
                }
            }
        }

        private Pozisyon YeniPozisyonUret(AriBirey ari)
        {
            int j;
            do
            {
                j = rnd.Next(arilar.Count);
            } while (arilar[j] == ari);

            double phi = rnd.NextDouble() * 2 - 1; // -1 ile 1 arası
            double yeniX = ari.Konum.X + phi * (ari.Konum.X - arilar[j].Konum.X);
            double yeniY = ari.Konum.Y + phi * (ari.Konum.Y - arilar[j].Konum.Y);

            // Sınır kontrolü
            yeniX = Math.Max(altSinir, Math.Min(ustSinir, yeniX));
            yeniY = Math.Max(altSinir, Math.Min(ustSinir, yeniY));

            return new Pozisyon(yeniX, yeniY);
        }

        private AriBirey EnIyiAri()
        {
            AriBirey enIyi = arilar[0];
            foreach (var ari in arilar)
            {
                if (ari.Uygunluk > enIyi.Uygunluk)
                    enIyi = ari;
            }
            return enIyi;
        }
    }
}
