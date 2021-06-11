
namespace muhasebeUygulamasi
{
    partial class Raporlama
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioİrsaliye = new System.Windows.Forms.RadioButton();
            this.radioSiparis = new System.Windows.Forms.RadioButton();
            this.radioCari = new System.Windows.Forms.RadioButton();
            this.radioCekSenet = new System.Windows.Forms.RadioButton();
            this.radioStok = new System.Windows.Forms.RadioButton();
            this.radioFirma = new System.Windows.Forms.RadioButton();
            this.radioTeklif = new System.Windows.Forms.RadioButton();
            this.radioBanka = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.printDocument4 = new System.Drawing.Printing.PrintDocument();
            this.printDocument5 = new System.Drawing.Printing.PrintDocument();
            this.printDocument6 = new System.Drawing.Printing.PrintDocument();
            this.printDocument7 = new System.Drawing.Printing.PrintDocument();
            this.printDocument8 = new System.Drawing.Printing.PrintDocument();
            this.printDocument9 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 224);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRaporla
            // 
            this.btnRaporla.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRaporla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaporla.Location = new System.Drawing.Point(143, 144);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(242, 32);
            this.btnRaporla.TabIndex = 2;
            this.btnRaporla.Text = "RAPORLA";
            this.btnRaporla.UseVisualStyleBackColor = false;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(22, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(145, 22);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fatura İşlemleri";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioİrsaliye
            // 
            this.radioİrsaliye.AutoSize = true;
            this.radioİrsaliye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioİrsaliye.Location = new System.Drawing.Point(178, 30);
            this.radioİrsaliye.Name = "radioİrsaliye";
            this.radioİrsaliye.Size = new System.Drawing.Size(150, 22);
            this.radioİrsaliye.TabIndex = 5;
            this.radioİrsaliye.TabStop = true;
            this.radioİrsaliye.Text = "İrsaliye İşlemleri";
            this.radioİrsaliye.UseVisualStyleBackColor = true;
            this.radioİrsaliye.Click += new System.EventHandler(this.radioİrsaliye_Click);
            // 
            // radioSiparis
            // 
            this.radioSiparis.AutoSize = true;
            this.radioSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioSiparis.Location = new System.Drawing.Point(365, 30);
            this.radioSiparis.Name = "radioSiparis";
            this.radioSiparis.Size = new System.Drawing.Size(149, 22);
            this.radioSiparis.TabIndex = 6;
            this.radioSiparis.TabStop = true;
            this.radioSiparis.Text = "Sipariş İşlemleri";
            this.radioSiparis.UseVisualStyleBackColor = true;
            this.radioSiparis.Click += new System.EventHandler(this.radioSiparis_Click);
            // 
            // radioCari
            // 
            this.radioCari.AutoSize = true;
            this.radioCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioCari.Location = new System.Drawing.Point(22, 69);
            this.radioCari.Name = "radioCari";
            this.radioCari.Size = new System.Drawing.Size(128, 22);
            this.radioCari.TabIndex = 7;
            this.radioCari.TabStop = true;
            this.radioCari.Text = "Cari İşlemleri";
            this.radioCari.UseVisualStyleBackColor = true;
            this.radioCari.Click += new System.EventHandler(this.radioCari_Click);
            // 
            // radioCekSenet
            // 
            this.radioCekSenet.AutoSize = true;
            this.radioCekSenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioCekSenet.Location = new System.Drawing.Point(178, 69);
            this.radioCekSenet.Name = "radioCekSenet";
            this.radioCekSenet.Size = new System.Drawing.Size(175, 22);
            this.radioCekSenet.TabIndex = 8;
            this.radioCekSenet.TabStop = true;
            this.radioCekSenet.Text = "Çek Senet İşlemleri";
            this.radioCekSenet.UseVisualStyleBackColor = true;
            this.radioCekSenet.Click += new System.EventHandler(this.radioCekSenet_Click);
            // 
            // radioStok
            // 
            this.radioStok.AutoSize = true;
            this.radioStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioStok.Location = new System.Drawing.Point(365, 69);
            this.radioStok.Name = "radioStok";
            this.radioStok.Size = new System.Drawing.Size(132, 22);
            this.radioStok.TabIndex = 9;
            this.radioStok.TabStop = true;
            this.radioStok.Text = "Stok İşlemleri";
            this.radioStok.UseVisualStyleBackColor = true;
            this.radioStok.Click += new System.EventHandler(this.radioStok_Click);
            // 
            // radioFirma
            // 
            this.radioFirma.AutoSize = true;
            this.radioFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioFirma.Location = new System.Drawing.Point(365, 110);
            this.radioFirma.Name = "radioFirma";
            this.radioFirma.Size = new System.Drawing.Size(132, 22);
            this.radioFirma.TabIndex = 12;
            this.radioFirma.TabStop = true;
            this.radioFirma.Text = "Firma Bilgileri";
            this.radioFirma.UseVisualStyleBackColor = true;
            this.radioFirma.Click += new System.EventHandler(this.radioFirma_Click);
            // 
            // radioTeklif
            // 
            this.radioTeklif.AutoSize = true;
            this.radioTeklif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTeklif.Location = new System.Drawing.Point(22, 110);
            this.radioTeklif.Name = "radioTeklif";
            this.radioTeklif.Size = new System.Drawing.Size(138, 22);
            this.radioTeklif.TabIndex = 11;
            this.radioTeklif.TabStop = true;
            this.radioTeklif.Text = "Teklif İşlemleri";
            this.radioTeklif.UseVisualStyleBackColor = true;
            this.radioTeklif.Click += new System.EventHandler(this.radioTeklif_Click);
            // 
            // radioBanka
            // 
            this.radioBanka.AutoSize = true;
            this.radioBanka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBanka.Location = new System.Drawing.Point(178, 110);
            this.radioBanka.Name = "radioBanka";
            this.radioBanka.Size = new System.Drawing.Size(144, 22);
            this.radioBanka.TabIndex = 10;
            this.radioBanka.TabStop = true;
            this.radioBanka.Text = "Banka İşlemleri";
            this.radioBanka.UseVisualStyleBackColor = true;
            this.radioBanka.Click += new System.EventHandler(this.radioBanka_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument2
            // 
            this.printDocument2.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument2_BeginPrint);
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printDocument3
            // 
            this.printDocument3.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument3_BeginPrint);
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // printDocument4
            // 
            this.printDocument4.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument4_BeginPrint);
            this.printDocument4.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument4_PrintPage);
            // 
            // printDocument5
            // 
            this.printDocument5.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument5_BeginPrint);
            this.printDocument5.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument5_PrintPage);
            // 
            // printDocument6
            // 
            this.printDocument6.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument6_BeginPrint);
            this.printDocument6.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument6_PrintPage);
            // 
            // printDocument7
            // 
            this.printDocument7.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument7_BeginPrint);
            this.printDocument7.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument7_PrintPage);
            // 
            // printDocument8
            // 
            this.printDocument8.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument8_BeginPrint);
            this.printDocument8.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument8_PrintPage);
            // 
            // printDocument9
            // 
            this.printDocument9.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument9_BeginPrint);
            this.printDocument9.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument9_PrintPage);
            // 
            // Raporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.radioFirma);
            this.Controls.Add(this.radioTeklif);
            this.Controls.Add(this.radioBanka);
            this.Controls.Add(this.radioStok);
            this.Controls.Add(this.radioCekSenet);
            this.Controls.Add(this.radioCari);
            this.Controls.Add(this.radioSiparis);
            this.Controls.Add(this.radioİrsaliye);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnRaporla);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Raporlama";
            this.Text = "Raporlama";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioİrsaliye;
        private System.Windows.Forms.RadioButton radioSiparis;
        private System.Windows.Forms.RadioButton radioCari;
        private System.Windows.Forms.RadioButton radioCekSenet;
        private System.Windows.Forms.RadioButton radioStok;
        private System.Windows.Forms.RadioButton radioFirma;
        private System.Windows.Forms.RadioButton radioTeklif;
        private System.Windows.Forms.RadioButton radioBanka;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Drawing.Printing.PrintDocument printDocument4;
        private System.Drawing.Printing.PrintDocument printDocument5;
        private System.Drawing.Printing.PrintDocument printDocument6;
        private System.Drawing.Printing.PrintDocument printDocument7;
        private System.Drawing.Printing.PrintDocument printDocument8;
        private System.Drawing.Printing.PrintDocument printDocument9;
    }
}