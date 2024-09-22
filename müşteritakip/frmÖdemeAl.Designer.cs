namespace müşteritakip
{
    partial class frmÖdemeAl
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbAçıklama = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMüşteriAdı = new System.Windows.Forms.Label();
            this.lblMüşteriNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(350, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(269, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAçıklama
            // 
            this.tbAçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAçıklama.Location = new System.Drawing.Point(168, 207);
            this.tbAçıklama.Name = "tbAçıklama";
            this.tbAçıklama.Size = new System.Drawing.Size(236, 34);
            this.tbAçıklama.TabIndex = 17;
            this.tbAçıklama.TextChanged += new System.EventHandler(this.tbAçıklama_TextChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(168, 157);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(236, 34);
            this.dtpTarih.TabIndex = 16;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // tbTutar
            // 
            this.tbTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTutar.Location = new System.Drawing.Point(168, 108);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(115, 34);
            this.tbTutar.TabIndex = 15;
            this.tbTutar.TextChanged += new System.EventHandler(this.tbTutar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Açıklama";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(93, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tarih";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(93, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tutar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMüşteriAdı
            // 
            this.lblMüşteriAdı.AutoSize = true;
            this.lblMüşteriAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMüşteriAdı.Location = new System.Drawing.Point(141, 41);
            this.lblMüşteriAdı.Name = "lblMüşteriAdı";
            this.lblMüşteriAdı.Size = new System.Drawing.Size(186, 36);
            this.lblMüşteriAdı.TabIndex = 11;
            this.lblMüşteriAdı.Text = "KADİR ABA";
            this.lblMüşteriAdı.Click += new System.EventHandler(this.lblMüşteriAdı_Click);
            // 
            // lblMüşteriNo
            // 
            this.lblMüşteriNo.AutoSize = true;
            this.lblMüşteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMüşteriNo.Location = new System.Drawing.Point(50, 41);
            this.lblMüşteriNo.Name = "lblMüşteriNo";
            this.lblMüşteriNo.Size = new System.Drawing.Size(51, 36);
            this.lblMüşteriNo.TabIndex = 10;
            this.lblMüşteriNo.Text = "99";
            this.lblMüşteriNo.Click += new System.EventHandler(this.lblMüşteriNo_Click);
            // 
            // frmÖdemeAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAçıklama);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.tbTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMüşteriAdı);
            this.Controls.Add(this.lblMüşteriNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmÖdemeAl";
            this.Text = "ÖDEME AL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAçıklama;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblMüşteriAdı;
        public System.Windows.Forms.Label lblMüşteriNo;
    }
}