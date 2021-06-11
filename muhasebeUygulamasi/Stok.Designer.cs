namespace muhasebeUygulamasi
{
    partial class Stok
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
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioKdv = new System.Windows.Forms.RadioButton();
            this.radioGrup = new System.Windows.Forms.RadioButton();
            this.radioStokAdi = new System.Windows.Forms.RadioButton();
            this.radioStokKod = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.Azure;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYazdir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(959, 15);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 67);
            this.btnYazdir.TabIndex = 11;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Azure;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(871, 15);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 67);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.radioKdv);
            this.panel1.Controls.Add(this.radioGrup);
            this.panel1.Controls.Add(this.radioStokAdi);
            this.panel1.Controls.Add(this.radioStokKod);
            this.panel1.Controls.Add(this.btnYazdir);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 96);
            this.panel1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(447, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 24);
            this.comboBox1.TabIndex = 36;
            // 
            // radioKdv
            // 
            this.radioKdv.AutoSize = true;
            this.radioKdv.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKdv.Location = new System.Drawing.Point(331, 35);
            this.radioKdv.Name = "radioKdv";
            this.radioKdv.Size = new System.Drawing.Size(61, 25);
            this.radioKdv.TabIndex = 35;
            this.radioKdv.TabStop = true;
            this.radioKdv.Text = "KDV";
            this.radioKdv.UseVisualStyleBackColor = true;
            this.radioKdv.Click += new System.EventHandler(this.radioKdv_Click);
            // 
            // radioGrup
            // 
            this.radioGrup.AutoSize = true;
            this.radioGrup.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioGrup.Location = new System.Drawing.Point(251, 35);
            this.radioGrup.Name = "radioGrup";
            this.radioGrup.Size = new System.Drawing.Size(66, 25);
            this.radioGrup.TabIndex = 34;
            this.radioGrup.TabStop = true;
            this.radioGrup.Text = "Grup";
            this.radioGrup.UseVisualStyleBackColor = true;
            this.radioGrup.Click += new System.EventHandler(this.radioGrup_Click);
            // 
            // radioStokAdi
            // 
            this.radioStokAdi.AutoSize = true;
            this.radioStokAdi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioStokAdi.Location = new System.Drawing.Point(146, 35);
            this.radioStokAdi.Name = "radioStokAdi";
            this.radioStokAdi.Size = new System.Drawing.Size(89, 25);
            this.radioStokAdi.TabIndex = 33;
            this.radioStokAdi.TabStop = true;
            this.radioStokAdi.Text = "Stok Adi";
            this.radioStokAdi.UseVisualStyleBackColor = true;
            this.radioStokAdi.Click += new System.EventHandler(this.radioStokAdi_Click);
            // 
            // radioStokKod
            // 
            this.radioStokKod.AutoSize = true;
            this.radioStokKod.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioStokKod.Location = new System.Drawing.Point(34, 35);
            this.radioStokKod.Name = "radioStokKod";
            this.radioStokKod.Size = new System.Drawing.Size(93, 25);
            this.radioStokKod.TabIndex = 32;
            this.radioStokKod.TabStop = true;
            this.radioStokKod.Text = "Stok Kod";
            this.radioStokKod.UseVisualStyleBackColor = true;
            this.radioStokKod.Click += new System.EventHandler(this.radioStokKod_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 504);
            this.dataGridView1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnGuncelle);
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 96);
            this.panel3.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Azure;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(824, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(219, 67);
            this.button8.TabIndex = 15;
            this.button8.Text = "Stok Hareketlerini Aç";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(630, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(509, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Bulunan Kayıt :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Azure;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(319, 15);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(138, 67);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Değiştir";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Azure;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(175, 15);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(138, 67);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Azure;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(15, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 67);
            this.button6.TabIndex = 10;
            this.button6.Text = "Ekle";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.dateTimePicker4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox5);
            this.panel2.Controls.Add(this.comboBox6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 96);
            this.panel2.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(959, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 67);
            this.button3.TabIndex = 11;
            this.button3.Text = "Yazdır";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(871, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 67);
            this.button4.TabIndex = 10;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(657, 18);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(577, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Son Tarih :";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(379, 55);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(466, 24);
            this.comboBox4.TabIndex = 7;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(379, 18);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker4.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(299, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Genel : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(299, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "İlk Tarih :";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(82, 58);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(205, 24);
            this.comboBox5.TabIndex = 3;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(82, 15);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(205, 24);
            this.comboBox6.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(11, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sırala :";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Stok";
            this.Text = "Stok İşlemleri";
            this.Load += new System.EventHandler(this.Stok_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioKdv;
        private System.Windows.Forms.RadioButton radioGrup;
        private System.Windows.Forms.RadioButton radioStokAdi;
        private System.Windows.Forms.RadioButton radioStokKod;
    }
}