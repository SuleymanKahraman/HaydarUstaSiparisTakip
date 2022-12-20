namespace HaydarUsta
{
    partial class frmAnaSayfa
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmailAdresGiris = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParolaTekrar = new System.Windows.Forms.Label();
            this.txtParolaTekrar = new System.Windows.Forms.TextBox();
            this.txtEmailGiris = new System.Windows.Forms.TextBox();
            this.lblParolaGiris = new System.Windows.Forms.Label();
            this.txtParolaGiris = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(197, 536);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(156, 71);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(909, 536);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(150, 71);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(99, 133);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(381, 26);
            this.txtAd.TabIndex = 2;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(100, 110);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(33, 20);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(100, 253);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail Adresi:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(99, 203);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(381, 26);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 276);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(381, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "HAYDAR USTANIN YERİNE HOŞGELDİNİZ...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmailAdresGiris
            // 
            this.lblEmailAdresGiris.AutoSize = true;
            this.lblEmailAdresGiris.Location = new System.Drawing.Point(815, 241);
            this.lblEmailAdresGiris.Name = "lblEmailAdresGiris";
            this.lblEmailAdresGiris.Size = new System.Drawing.Size(106, 20);
            this.lblEmailAdresGiris.TabIndex = 14;
            this.lblEmailAdresGiris.Text = "E-mail Adresi:";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(100, 342);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(54, 20);
            this.lblParola.TabIndex = 15;
            this.lblParola.Text = "Parola";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(99, 365);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(381, 26);
            this.txtParola.TabIndex = 16;
            // 
            // lblParolaTekrar
            // 
            this.lblParolaTekrar.AutoSize = true;
            this.lblParolaTekrar.Location = new System.Drawing.Point(100, 433);
            this.lblParolaTekrar.Name = "lblParolaTekrar";
            this.lblParolaTekrar.Size = new System.Drawing.Size(109, 20);
            this.lblParolaTekrar.TabIndex = 17;
            this.lblParolaTekrar.Text = "Parola(Tekrar)";
            // 
            // txtParolaTekrar
            // 
            this.txtParolaTekrar.Location = new System.Drawing.Point(99, 456);
            this.txtParolaTekrar.Name = "txtParolaTekrar";
            this.txtParolaTekrar.Size = new System.Drawing.Size(381, 26);
            this.txtParolaTekrar.TabIndex = 18;
            // 
            // txtEmailGiris
            // 
            this.txtEmailGiris.Location = new System.Drawing.Point(808, 276);
            this.txtEmailGiris.Name = "txtEmailGiris";
            this.txtEmailGiris.Size = new System.Drawing.Size(337, 26);
            this.txtEmailGiris.TabIndex = 19;
            // 
            // lblParolaGiris
            // 
            this.lblParolaGiris.AutoSize = true;
            this.lblParolaGiris.Location = new System.Drawing.Point(815, 328);
            this.lblParolaGiris.Name = "lblParolaGiris";
            this.lblParolaGiris.Size = new System.Drawing.Size(54, 20);
            this.lblParolaGiris.TabIndex = 20;
            this.lblParolaGiris.Text = "Parola";
            this.lblParolaGiris.Click += new System.EventHandler(this.lblParolaGiris_Click);
            // 
            // txtParolaGiris
            // 
            this.txtParolaGiris.Location = new System.Drawing.Point(808, 365);
            this.txtParolaGiris.Name = "txtParolaGiris";
            this.txtParolaGiris.Size = new System.Drawing.Size(337, 26);
            this.txtParolaGiris.TabIndex = 21;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(100, 180);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(58, 20);
            this.lblSoyad.TabIndex = 22;
            this.lblSoyad.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "VE YA";
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtParolaGiris);
            this.Controls.Add(this.lblParolaGiris);
            this.Controls.Add(this.txtEmailGiris);
            this.Controls.Add(this.txtParolaTekrar);
            this.Controls.Add(this.lblParolaTekrar);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmailAdresGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnKayit);
            this.Name = "frmAnaSayfa";
            this.Text = "ANASAYFA";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmailAdresGiris;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblParolaTekrar;
        private System.Windows.Forms.Label lblParolaGiris;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtParola;
        public System.Windows.Forms.TextBox txtParolaTekrar;
        public System.Windows.Forms.TextBox txtEmailGiris;
        public System.Windows.Forms.TextBox txtParolaGiris;
    }
}

