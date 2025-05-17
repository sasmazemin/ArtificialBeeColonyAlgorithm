using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtificialBeeColonyAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // x1 - x2 grafiği
            chartEniyi.Series.Clear();
            chartEniyi.Series.Add("x1");
            chartEniyi.Series.Add("x2");

            chartEniyi.Series["x1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartEniyi.Series["x2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            // fx grafiği
            chartFx.Series.Clear();
            chartFx.Series.Add("fx");
            chartFx.Series["fx"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // 1. Kullanıcıdan değerleri al
            int koloniBoyutu = (int)nudKoloni.Value;
            int alt = (int)nudAlt.Value;
            int ust = (int)nudUst.Value;
            int cevrim = (int)nudCevrim.Value;
            int maxEtkisiz = (int)nudDeneme.Value;

            // 2. Önceki verileri temizle
            chartEniyi.Series["x1"].Points.Clear();
            chartEniyi.Series["x2"].Points.Clear();
            chartFx.Series["fx"].Points.Clear();
            textBox1.Clear();

            // 3. ABC algoritmasını başlat
            ABCAlgoritmasi abc = new ABCAlgoritmasi(koloniBoyutu, alt, ust, cevrim, maxEtkisiz);

            // 4. Grafik ve sonuçları yazdır
            for (int i = 0; i < abc.FxDegerleri.Count; i++)
            {
                double x = abc.XListesi[i];
                double y = abc.YListesi[i];
                double fx = abc.FxDegerleri[i];

                chartEniyi.Series["x1"].Points.AddY(x);
                chartEniyi.Series["x2"].Points.AddY(y);
                chartFx.Series["fx"].Points.AddY(fx);

                textBox1.AppendText($"Tur {i + 1,-2} → X: {x,8:0.000}, Y: {y,8:0.000}, F(x): {fx,8:0.000}\r\n");
            }
        }
    }
}
