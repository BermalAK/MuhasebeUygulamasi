
namespace muhasebeUygulamasi
{
    partial class CekSenetİslemler
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
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnBanka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKasa
            // 
            this.btnKasa.BackColor = System.Drawing.Color.MediumBlue;
            this.btnKasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKasa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.ForeColor = System.Drawing.Color.White;
            this.btnKasa.Location = new System.Drawing.Point(57, 50);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(314, 75);
            this.btnKasa.TabIndex = 0;
            this.btnKasa.Text = "Tahsilat/Ödeme-Kasadan";
            this.btnKasa.UseVisualStyleBackColor = false;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnBanka
            // 
            this.btnBanka.BackColor = System.Drawing.Color.MediumBlue;
            this.btnBanka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBanka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanka.ForeColor = System.Drawing.Color.White;
            this.btnBanka.Location = new System.Drawing.Point(57, 150);
            this.btnBanka.Name = "btnBanka";
            this.btnBanka.Size = new System.Drawing.Size(314, 75);
            this.btnBanka.TabIndex = 1;
            this.btnBanka.Text = "Tahsilat/Ödeme-Bankadan";
            this.btnBanka.UseVisualStyleBackColor = false;
            this.btnBanka.Click += new System.EventHandler(this.btnBanka_Click);
            // 
            // CekSenetİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(425, 299);
            this.Controls.Add(this.btnBanka);
            this.Controls.Add(this.btnKasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CekSenetİslemler";
            this.Text = "Çek Senet İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnBanka;
    }
}