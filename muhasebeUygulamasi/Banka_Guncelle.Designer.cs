namespace muhasebeUygulamasi
{
    partial class Banka_Guncelle
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHesapAdi = new System.Windows.Forms.TextBox();
            this.txtBankaAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCikan = new System.Windows.Forms.TextBox();
            this.txtGiren = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(83, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Banka Bilgisi Guncelleme";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 384);
            this.panel1.TabIndex = 7;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(70, 310);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(271, 56);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtHesapAdi);
            this.groupBox1.Controls.Add(this.txtBankaAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBakiye);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCikan);
            this.groupBox1.Controls.Add(this.txtGiren);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(21, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 239);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(130, 86);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(200, 22);
            this.txtHesapAdi.TabIndex = 22;
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(130, 53);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Size = new System.Drawing.Size(200, 22);
            this.txtBankaAdi.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kod :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banka Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(130, 185);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(200, 22);
            this.txtBakiye.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hesap Adı :";
            // 
            // txtCikan
            // 
            this.txtCikan.Location = new System.Drawing.Point(130, 152);
            this.txtCikan.Name = "txtCikan";
            this.txtCikan.Size = new System.Drawing.Size(200, 22);
            this.txtCikan.TabIndex = 12;
            // 
            // txtGiren
            // 
            this.txtGiren.Location = new System.Drawing.Point(130, 119);
            this.txtGiren.Name = "txtGiren";
            this.txtGiren.Size = new System.Drawing.Size(200, 22);
            this.txtGiren.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giren :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(27, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Çıkan :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bakiye :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Banka_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 388);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Banka_Guncelle";
            this.Text = "Banka Guncelle";
            this.Load += new System.EventHandler(this.Banka_Guncelle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtHesapAdi;
        private System.Windows.Forms.TextBox txtBankaAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCikan;
        private System.Windows.Forms.TextBox txtGiren;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}