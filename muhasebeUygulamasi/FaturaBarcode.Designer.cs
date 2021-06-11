
namespace muhasebeUygulamasi
{
    partial class FaturaBarcode
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnQrcode = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "FATURA NO :";
            // 
            // btnBarcode
            // 
            this.btnBarcode.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBarcode.Location = new System.Drawing.Point(58, 314);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(130, 45);
            this.btnBarcode.TabIndex = 4;
            this.btnBarcode.Text = "BARCODE";
            this.btnBarcode.UseVisualStyleBackColor = false;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // btnQrcode
            // 
            this.btnQrcode.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnQrcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQrcode.Location = new System.Drawing.Point(269, 314);
            this.btnQrcode.Name = "btnQrcode";
            this.btnQrcode.Size = new System.Drawing.Size(130, 45);
            this.btnQrcode.TabIndex = 5;
            this.btnQrcode.Text = "QRCODE";
            this.btnQrcode.UseVisualStyleBackColor = false;
            this.btnQrcode.Click += new System.EventHandler(this.btnQrcode_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(247, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 240);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(25, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FaturaBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(480, 396);
            this.Controls.Add(this.btnQrcode);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FaturaBarcode";
            this.Text = "Barcode ve QrCode";
            this.Load += new System.EventHandler(this.FaturaBarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnQrcode;
    }
}