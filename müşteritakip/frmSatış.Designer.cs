namespace müşteritakip
{
    partial class frmSatış
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
            this.grdMüşteriler = new System.Windows.Forms.DataGridView();
            this.grdÜrünler = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbAdet = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.tbAçıklama = new System.Windows.Forms.TextBox();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMüşteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdÜrünler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMüşteriler
            // 
            this.grdMüşteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMüşteriler.Dock = System.Windows.Forms.DockStyle.Left;
            this.grdMüşteriler.Location = new System.Drawing.Point(0, 0);
            this.grdMüşteriler.Name = "grdMüşteriler";
            this.grdMüşteriler.RowHeadersWidth = 51;
            this.grdMüşteriler.RowTemplate.Height = 24;
            this.grdMüşteriler.Size = new System.Drawing.Size(289, 511);
            this.grdMüşteriler.TabIndex = 0;
            // 
            // grdÜrünler
            // 
            this.grdÜrünler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdÜrünler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdÜrünler.Location = new System.Drawing.Point(289, 0);
            this.grdÜrünler.Name = "grdÜrünler";
            this.grdÜrünler.RowHeadersWidth = 51;
            this.grdÜrünler.RowTemplate.Height = 24;
            this.grdÜrünler.Size = new System.Drawing.Size(398, 511);
            this.grdÜrünler.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.tbTutar);
            this.panel1.Controls.Add(this.tbAçıklama);
            this.panel1.Controls.Add(this.dtpTarih);
            this.panel1.Controls.Add(this.tbAdet);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(289, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 235);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tutar";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(295, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(214, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Satış Yap";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbAdet
            // 
            this.tbAdet.Location = new System.Drawing.Point(83, 15);
            this.tbAdet.Name = "tbAdet";
            this.tbAdet.Size = new System.Drawing.Size(195, 22);
            this.tbAdet.TabIndex = 6;
            this.tbAdet.TextChanged += new System.EventHandler(this.tbAdet_TextChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(84, 51);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(194, 22);
            this.dtpTarih.TabIndex = 7;
            // 
            // tbAçıklama
            // 
            this.tbAçıklama.Location = new System.Drawing.Point(84, 86);
            this.tbAçıklama.Name = "tbAçıklama";
            this.tbAçıklama.Size = new System.Drawing.Size(194, 22);
            this.tbAçıklama.TabIndex = 8;
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(84, 123);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.ReadOnly = true;
            this.tbTutar.Size = new System.Drawing.Size(194, 22);
            this.tbTutar.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Hesapla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmSatış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdÜrünler);
            this.Controls.Add(this.grdMüşteriler);
            this.Name = "frmSatış";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSatış_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMüşteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdÜrünler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMüşteriler;
        private System.Windows.Forms.DataGridView grdÜrünler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.TextBox tbAçıklama;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox tbAdet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}