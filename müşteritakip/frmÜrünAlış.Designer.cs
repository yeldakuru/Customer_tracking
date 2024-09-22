namespace müşteritakip
{
    partial class frmÜrünAlış
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
            this.lblÜrünNo = new System.Windows.Forms.Label();
            this.lblÜrünAdı = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAlınanAdet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblÜrünNo
            // 
            this.lblÜrünNo.AutoSize = true;
            this.lblÜrünNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜrünNo.Location = new System.Drawing.Point(68, 115);
            this.lblÜrünNo.Name = "lblÜrünNo";
            this.lblÜrünNo.Size = new System.Drawing.Size(53, 20);
            this.lblÜrünNo.TabIndex = 0;
            this.lblÜrünNo.Text = "label1";
            // 
            // lblÜrünAdı
            // 
            this.lblÜrünAdı.AutoSize = true;
            this.lblÜrünAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜrünAdı.Location = new System.Drawing.Point(170, 114);
            this.lblÜrünAdı.Name = "lblÜrünAdı";
            this.lblÜrünAdı.Size = new System.Drawing.Size(53, 20);
            this.lblÜrünAdı.TabIndex = 1;
            this.lblÜrünAdı.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adet";
            // 
            // tbAlınanAdet
            // 
            this.tbAlınanAdet.Location = new System.Drawing.Point(112, 192);
            this.tbAlınanAdet.Name = "tbAlınanAdet";
            this.tbAlınanAdet.Size = new System.Drawing.Size(182, 22);
            this.tbAlınanAdet.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Alış Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmÜrünAlış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAlınanAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblÜrünAdı);
            this.Controls.Add(this.lblÜrünNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmÜrünAlış";
            this.Text = "ÜRÜN ALIŞ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAlınanAdet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lblÜrünNo;
        public System.Windows.Forms.Label lblÜrünAdı;
    }
}