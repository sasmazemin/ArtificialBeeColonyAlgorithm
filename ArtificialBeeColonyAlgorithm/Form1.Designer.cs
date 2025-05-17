
namespace ArtificialBeeColonyAlgorithm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelGiris = new System.Windows.Forms.Panel();
            this.lblKoloni = new System.Windows.Forms.Label();
            this.nudKoloni = new System.Windows.Forms.NumericUpDown();
            this.lblAlt = new System.Windows.Forms.Label();
            this.nudAlt = new System.Windows.Forms.NumericUpDown();
            this.lblUst = new System.Windows.Forms.Label();
            this.nudUst = new System.Windows.Forms.NumericUpDown();
            this.lblDeneme = new System.Windows.Forms.Label();
            this.nudDeneme = new System.Windows.Forms.NumericUpDown();
            this.lblCevrim = new System.Windows.Forms.Label();
            this.nudCevrim = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.panelGrafik = new System.Windows.Forms.Panel();
            this.chartEniyi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelSonuclar = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoloni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeneme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCevrim)).BeginInit();
            this.panelGrafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEniyi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).BeginInit();
            this.panelSonuclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGiris
            // 
            this.panelGiris.BackColor = System.Drawing.Color.RosyBrown;
            this.panelGiris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGiris.Controls.Add(this.btnHesapla);
            this.panelGiris.Controls.Add(this.nudCevrim);
            this.panelGiris.Controls.Add(this.lblCevrim);
            this.panelGiris.Controls.Add(this.nudDeneme);
            this.panelGiris.Controls.Add(this.lblDeneme);
            this.panelGiris.Controls.Add(this.nudUst);
            this.panelGiris.Controls.Add(this.lblUst);
            this.panelGiris.Controls.Add(this.nudAlt);
            this.panelGiris.Controls.Add(this.lblAlt);
            this.panelGiris.Controls.Add(this.nudKoloni);
            this.panelGiris.Controls.Add(this.lblKoloni);
            this.panelGiris.Location = new System.Drawing.Point(10, 10);
            this.panelGiris.Name = "panelGiris";
            this.panelGiris.Size = new System.Drawing.Size(480, 160);
            this.panelGiris.TabIndex = 0;
            // 
            // lblKoloni
            // 
            this.lblKoloni.AutoSize = true;
            this.lblKoloni.Location = new System.Drawing.Point(20, 20);
            this.lblKoloni.Name = "lblKoloni";
            this.lblKoloni.Size = new System.Drawing.Size(95, 17);
            this.lblKoloni.TabIndex = 0;
            this.lblKoloni.Text = "Koloni Boyutu";
            // 
            // nudKoloni
            // 
            this.nudKoloni.Location = new System.Drawing.Point(130, 15);
            this.nudKoloni.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKoloni.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKoloni.Name = "nudKoloni";
            this.nudKoloni.Size = new System.Drawing.Size(80, 22);
            this.nudKoloni.TabIndex = 1;
            this.nudKoloni.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Location = new System.Drawing.Point(20, 60);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(56, 17);
            this.lblAlt.TabIndex = 2;
            this.lblAlt.Text = "Alt Sınır";
            // 
            // nudAlt
            // 
            this.nudAlt.Location = new System.Drawing.Point(130, 55);
            this.nudAlt.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAlt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudAlt.Name = "nudAlt";
            this.nudAlt.Size = new System.Drawing.Size(80, 22);
            this.nudAlt.TabIndex = 3;
            this.nudAlt.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // lblUst
            // 
            this.lblUst.AutoSize = true;
            this.lblUst.Location = new System.Drawing.Point(20, 100);
            this.lblUst.Name = "lblUst";
            this.lblUst.Size = new System.Drawing.Size(61, 17);
            this.lblUst.TabIndex = 4;
            this.lblUst.Text = "Üst Sınır";
            // 
            // nudUst
            // 
            this.nudUst.Location = new System.Drawing.Point(130, 95);
            this.nudUst.Name = "nudUst";
            this.nudUst.Size = new System.Drawing.Size(80, 22);
            this.nudUst.TabIndex = 5;
            this.nudUst.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblDeneme
            // 
            this.lblDeneme.AutoSize = true;
            this.lblDeneme.Location = new System.Drawing.Point(250, 20);
            this.lblDeneme.Name = "lblDeneme";
            this.lblDeneme.Size = new System.Drawing.Size(102, 17);
            this.lblDeneme.TabIndex = 6;
            this.lblDeneme.Text = "Deneme Sayısı";
            // 
            // nudDeneme
            // 
            this.nudDeneme.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDeneme.Location = new System.Drawing.Point(370, 15);
            this.nudDeneme.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDeneme.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeneme.Name = "nudDeneme";
            this.nudDeneme.Size = new System.Drawing.Size(80, 22);
            this.nudDeneme.TabIndex = 7;
            this.nudDeneme.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblCevrim
            // 
            this.lblCevrim.AutoSize = true;
            this.lblCevrim.Location = new System.Drawing.Point(250, 60);
            this.lblCevrim.Name = "lblCevrim";
            this.lblCevrim.Size = new System.Drawing.Size(92, 17);
            this.lblCevrim.TabIndex = 8;
            this.lblCevrim.Text = "Çevrim Sayısı";
            // 
            // nudCevrim
            // 
            this.nudCevrim.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCevrim.Location = new System.Drawing.Point(370, 55);
            this.nudCevrim.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCevrim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCevrim.Name = "nudCevrim";
            this.nudCevrim.Size = new System.Drawing.Size(80, 22);
            this.nudCevrim.TabIndex = 9;
            this.nudCevrim.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(250, 100);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(200, 35);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // panelGrafik
            // 
            this.panelGrafik.BackColor = System.Drawing.Color.RosyBrown;
            this.panelGrafik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrafik.Controls.Add(this.chartFx);
            this.panelGrafik.Controls.Add(this.chartEniyi);
            this.panelGrafik.Location = new System.Drawing.Point(500, 10);
            this.panelGrafik.Name = "panelGrafik";
            this.panelGrafik.Size = new System.Drawing.Size(660, 280);
            this.panelGrafik.TabIndex = 1;
            // 
            // chartEniyi
            // 
            chartArea5.Name = "ChartArea1";
            this.chartEniyi.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartEniyi.Legends.Add(legend5);
            this.chartEniyi.Location = new System.Drawing.Point(10, 10);
            this.chartEniyi.Name = "chartEniyi";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartEniyi.Series.Add(series5);
            this.chartEniyi.Size = new System.Drawing.Size(300, 250);
            this.chartEniyi.TabIndex = 0;
            // 
            // chartFx
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFx.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartFx.Legends.Add(legend6);
            this.chartFx.Location = new System.Drawing.Point(340, 10);
            this.chartFx.Name = "chartFx";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFx.Series.Add(series6);
            this.chartFx.Size = new System.Drawing.Size(300, 250);
            this.chartFx.TabIndex = 1;
            this.chartFx.Text = "chart1";
            // 
            // panelSonuclar
            // 
            this.panelSonuclar.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSonuclar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSonuclar.Controls.Add(this.textBox1);
            this.panelSonuclar.Location = new System.Drawing.Point(10, 300);
            this.panelSonuclar.Name = "panelSonuclar";
            this.panelSonuclar.Size = new System.Drawing.Size(1150, 350);
            this.panelSonuclar.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1120, 320);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panelSonuclar);
            this.Controls.Add(this.panelGrafik);
            this.Controls.Add(this.panelGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGiris.ResumeLayout(false);
            this.panelGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoloni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeneme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCevrim)).EndInit();
            this.panelGrafik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEniyi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).EndInit();
            this.panelSonuclar.ResumeLayout(false);
            this.panelSonuclar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGiris;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.NumericUpDown nudCevrim;
        private System.Windows.Forms.Label lblCevrim;
        private System.Windows.Forms.NumericUpDown nudDeneme;
        private System.Windows.Forms.Label lblDeneme;
        private System.Windows.Forms.NumericUpDown nudUst;
        private System.Windows.Forms.Label lblUst;
        private System.Windows.Forms.NumericUpDown nudAlt;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.NumericUpDown nudKoloni;
        private System.Windows.Forms.Label lblKoloni;
        private System.Windows.Forms.Panel panelGrafik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEniyi;
        private System.Windows.Forms.Panel panelSonuclar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

