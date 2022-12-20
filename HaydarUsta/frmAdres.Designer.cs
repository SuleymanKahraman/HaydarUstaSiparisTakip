namespace HaydarUsta
{
    partial class frmAdres
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
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.btnKaydetAdres = new System.Windows.Forms.Button();
            this.btnGuncelleAdres = new System.Windows.Forms.Button();
            this.btnSilAdres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(174, 75);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(381, 98);
            this.txtAdres.TabIndex = 22;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(326, 37);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(55, 20);
            this.lblAdres.TabIndex = 21;
            this.lblAdres.Text = "Adres:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(174, 238);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(381, 26);
            this.txtTelefon.TabIndex = 20;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(326, 199);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(66, 20);
            this.lblTelefon.TabIndex = 23;
            this.lblTelefon.Text = "Telefon:";
            // 
            // btnKaydetAdres
            // 
            this.btnKaydetAdres.Location = new System.Drawing.Point(174, 306);
            this.btnKaydetAdres.Name = "btnKaydetAdres";
            this.btnKaydetAdres.Size = new System.Drawing.Size(110, 56);
            this.btnKaydetAdres.TabIndex = 24;
            this.btnKaydetAdres.Text = "Kaydet";
            this.btnKaydetAdres.UseVisualStyleBackColor = true;
            // 
            // btnGuncelleAdres
            // 
            this.btnGuncelleAdres.Location = new System.Drawing.Point(309, 306);
            this.btnGuncelleAdres.Name = "btnGuncelleAdres";
            this.btnGuncelleAdres.Size = new System.Drawing.Size(110, 56);
            this.btnGuncelleAdres.TabIndex = 25;
            this.btnGuncelleAdres.Text = "Güncelle";
            this.btnGuncelleAdres.UseVisualStyleBackColor = true;
            // 
            // btnSilAdres
            // 
            this.btnSilAdres.Location = new System.Drawing.Point(445, 306);
            this.btnSilAdres.Name = "btnSilAdres";
            this.btnSilAdres.Size = new System.Drawing.Size(110, 56);
            this.btnSilAdres.TabIndex = 26;
            this.btnSilAdres.Text = "Sil";
            this.btnSilAdres.UseVisualStyleBackColor = true;
            // 
            // frmAdres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSilAdres);
            this.Controls.Add(this.btnGuncelleAdres);
            this.Controls.Add(this.btnKaydetAdres);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtTelefon);
            this.Name = "frmAdres";
            this.Text = "frmAdres";
            this.Load += new System.EventHandler(this.frmAdres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Button btnKaydetAdres;
        private System.Windows.Forms.Button btnGuncelleAdres;
        private System.Windows.Forms.Button btnSilAdres;
    }
}