namespace muhasebeUygulamasi
{
    partial class Firma_Guncelle
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
            this.txtDonem = new System.Windows.Forms.TextBox();
            this.txtVarsayilan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFirmaGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDonem
            // 
            this.txtDonem.Location = new System.Drawing.Point(129, 126);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Size = new System.Drawing.Size(200, 22);
            this.txtDonem.TabIndex = 13;
            // 
            // txtVarsayilan
            // 
            this.txtVarsayilan.Location = new System.Drawing.Point(129, 90);
            this.txtVarsayilan.Name = "txtVarsayilan";
            this.txtVarsayilan.Size = new System.Drawing.Size(200, 22);
            this.txtVarsayilan.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kod :";
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(129, 55);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(200, 22);
            this.txtUnvan.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unvan :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Varsayılan :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dönem :";
            // 
            // btnFirmaGuncelle
            // 
            this.btnFirmaGuncelle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnFirmaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaGuncelle.Location = new System.Drawing.Point(79, 245);
            this.btnFirmaGuncelle.Name = "btnFirmaGuncelle";
            this.btnFirmaGuncelle.Size = new System.Drawing.Size(271, 56);
            this.btnFirmaGuncelle.TabIndex = 17;
            this.btnFirmaGuncelle.Text = "GUNCELLE";
            this.btnFirmaGuncelle.UseVisualStyleBackColor = false;
            this.btnFirmaGuncelle.Click += new System.EventHandler(this.btnFirmaGuncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(74, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Firma Bilgisi Guncelleme";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtDonem);
            this.groupBox1.Controls.Add(this.txtVarsayilan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUnvan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(21, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 174);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnFirmaGuncelle);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 334);
            this.panel1.TabIndex = 2;
            // 
            // Firma_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 336);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Firma_Guncelle";
            this.Text = "Firma Guncelle";
            this.Load += new System.EventHandler(this.Firma_Guncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonem;
        private System.Windows.Forms.TextBox txtVarsayilan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFirmaGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
    }
}