
namespace muhasebeUygulamasi
{
    partial class Grafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnBanka = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFatura
            // 
            this.btnFatura.BackColor = System.Drawing.Color.MediumBlue;
            this.btnFatura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFatura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.ForeColor = System.Drawing.Color.White;
            this.btnFatura.Location = new System.Drawing.Point(65, 16);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(120, 42);
            this.btnFatura.TabIndex = 1;
            this.btnFatura.Text = "Fatura";
            this.btnFatura.UseVisualStyleBackColor = false;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnBanka
            // 
            this.btnBanka.BackColor = System.Drawing.Color.MediumBlue;
            this.btnBanka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBanka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanka.ForeColor = System.Drawing.Color.White;
            this.btnBanka.Location = new System.Drawing.Point(202, 16);
            this.btnBanka.Name = "btnBanka";
            this.btnBanka.Size = new System.Drawing.Size(120, 42);
            this.btnBanka.TabIndex = 2;
            this.btnBanka.Text = "Banka";
            this.btnBanka.UseVisualStyleBackColor = false;
            this.btnBanka.Click += new System.EventHandler(this.btnBanka_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 84);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Muhasebe";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(628, 370);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.MediumBlue;
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ForeColor = System.Drawing.Color.White;
            this.btnStok.Location = new System.Drawing.Point(478, 16);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(120, 42);
            this.btnStok.TabIndex = 5;
            this.btnStok.Text = "Stok";
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.BackColor = System.Drawing.Color.MediumBlue;
            this.btnKasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKasa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.ForeColor = System.Drawing.Color.White;
            this.btnKasa.Location = new System.Drawing.Point(341, 16);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(120, 42);
            this.btnKasa.TabIndex = 4;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.UseVisualStyleBackColor = false;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(668, 464);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnKasa);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnBanka);
            this.Controls.Add(this.btnFatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Grafik";
            this.Text = "İstatistik";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnBanka;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnKasa;
    }
}