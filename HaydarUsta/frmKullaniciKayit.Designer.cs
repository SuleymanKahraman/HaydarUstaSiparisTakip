namespace HaydarUsta
{
    partial class frmKullaniciKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciKayit));
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtParolaTekrar = new System.Windows.Forms.TextBox();
            this.lblParolaTekrar = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(156, 148);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(58, 20);
            this.lblSoyad.TabIndex = 33;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtParolaTekrar
            // 
            this.txtParolaTekrar.Location = new System.Drawing.Point(155, 424);
            this.txtParolaTekrar.Name = "txtParolaTekrar";
            this.txtParolaTekrar.Size = new System.Drawing.Size(381, 26);
            this.txtParolaTekrar.TabIndex = 32;
            // 
            // lblParolaTekrar
            // 
            this.lblParolaTekrar.AutoSize = true;
            this.lblParolaTekrar.Location = new System.Drawing.Point(156, 401);
            this.lblParolaTekrar.Name = "lblParolaTekrar";
            this.lblParolaTekrar.Size = new System.Drawing.Size(113, 20);
            this.lblParolaTekrar.TabIndex = 31;
            this.lblParolaTekrar.Text = "Parola(Tekrar):";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(155, 333);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(381, 26);
            this.txtParola.TabIndex = 30;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(156, 310);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(58, 20);
            this.lblParola.TabIndex = 29;
            this.lblParola.Text = "Parola:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 244);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(381, 26);
            this.txtEmail.TabIndex = 28;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(155, 171);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(381, 26);
            this.txtSoyad.TabIndex = 27;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(156, 221);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 20);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "E-mail Adresi:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(156, 78);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(33, 20);
            this.lblAd.TabIndex = 25;
            this.lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(155, 101);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(381, 26);
            this.txtAd.TabIndex = 24;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(155, 497);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(381, 71);
            this.btnKayit.TabIndex = 23;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.txtParolaTekrar);
            this.groupBox1.Controls.Add(this.lblParolaTekrar);
            this.groupBox1.Controls.Add(this.txtParola);
            this.groupBox1.Controls.Add(this.lblParola);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.btnKayit);
            this.groupBox1.Location = new System.Drawing.Point(380, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 634);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // frmKullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 880);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKullaniciKayit";
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.frmKullaniciKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoyad;
        public System.Windows.Forms.TextBox txtParolaTekrar;
        private System.Windows.Forms.Label lblParolaTekrar;
        public System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAd;
        public System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}