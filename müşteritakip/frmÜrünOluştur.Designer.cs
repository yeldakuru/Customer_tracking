namespace müşteritakip
{
    partial class frmÜrünOluştur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdet = new System.Windows.Forms.TextBox();
            this.tbAdı = new System.Windows.Forms.TextBox();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbAdet
            // 
            this.tbAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdet.Location = new System.Drawing.Point(147, 170);
            this.tbAdet.Name = "tbAdet";
            this.tbAdet.Size = new System.Drawing.Size(210, 28);
            this.tbAdet.TabIndex = 4;
            // 
            // tbAdı
            // 
            this.tbAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdı.Location = new System.Drawing.Point(147, 82);
            this.tbAdı.Name = "tbAdı";
            this.tbAdı.Size = new System.Drawing.Size(210, 28);
            this.tbAdı.TabIndex = 5;
            // 
            // tbFiyat
            // 
            this.tbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFiyat.Location = new System.Drawing.Point(147, 124);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(210, 28);
            this.tbFiyat.TabIndex = 6;
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(147, 42);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(210, 30);
            this.cbKategori.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmÜrünOluştur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.tbAdı);
            this.Controls.Add(this.tbAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmÜrünOluştur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN OLUŞTUR";
            this.Load += new System.EventHandler(this.frmÜrünOluştur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdet;
        private System.Windows.Forms.TextBox tbAdı;
        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}