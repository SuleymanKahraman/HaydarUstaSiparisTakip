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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.txtLogParola = new System.Windows.Forms.TextBox();
            this.txtLogEmailAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmailAdresGiris = new System.Windows.Forms.Label();
            this.lblParolaGiris = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogParola
            // 
            this.txtLogParola.Location = new System.Drawing.Point(321, 206);
            this.txtLogParola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogParola.Name = "txtLogParola";
            this.txtLogParola.PasswordChar = '*';
            this.txtLogParola.Size = new System.Drawing.Size(226, 20);
            this.txtLogParola.TabIndex = 2;
            // 
            // txtLogEmailAdres
            // 
            this.txtLogEmailAdres.Location = new System.Drawing.Point(321, 155);
            this.txtLogEmailAdres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogEmailAdres.Name = "txtLogEmailAdres";
            this.txtLogEmailAdres.Size = new System.Drawing.Size(226, 20);
            this.txtLogEmailAdres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "HAYDAR USTANIN YERİNE HOŞGELDİNİZ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "VE YA";
            // 
            // lblEmailAdresGiris
            // 
            this.lblEmailAdresGiris.AutoSize = true;
            this.lblEmailAdresGiris.Location = new System.Drawing.Point(325, 130);
            this.lblEmailAdresGiris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailAdresGiris.Name = "lblEmailAdresGiris";
            this.lblEmailAdresGiris.Size = new System.Drawing.Size(70, 13);
            this.lblEmailAdresGiris.TabIndex = 28;
            this.lblEmailAdresGiris.Text = "E-mail Adresi:";
            // 
            // lblParolaGiris
            // 
            this.lblParolaGiris.AutoSize = true;
            this.lblParolaGiris.Location = new System.Drawing.Point(325, 191);
            this.lblParolaGiris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParolaGiris.Name = "lblParolaGiris";
            this.lblParolaGiris.Size = new System.Drawing.Size(40, 13);
            this.lblParolaGiris.TabIndex = 30;
            this.lblParolaGiris.Text = "Parola:";
            // 
            // btnGiris
            // 
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Location = new System.Drawing.Point(321, 234);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(225, 47);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click_1);
            // 
            // btnKayit
            // 
            this.btnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayit.Location = new System.Drawing.Point(321, 319);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(225, 47);
            this.btnKayit.TabIndex = 4;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 471);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtLogParola);
            this.Controls.Add(this.txtLogEmailAdres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmailAdresGiris);
            this.Controls.Add(this.lblParolaGiris);
            this.Controls.Add(this.btnGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtLogParola;
        public System.Windows.Forms.TextBox txtLogEmailAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmailAdresGiris;
        private System.Windows.Forms.Label lblParolaGiris;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKayit;
    }
}

