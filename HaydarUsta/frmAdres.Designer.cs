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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdres));
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.btnKaydetAdres = new System.Windows.Forms.Button();
            this.btnGuncelleAdres = new System.Windows.Forms.Button();
            this.btnSilAdres = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAdresler = new System.Windows.Forms.DataGridView();
            this.btnSec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(17, 76);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(381, 98);
            this.txtAdres.TabIndex = 22;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(169, 38);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(55, 20);
            this.lblAdres.TabIndex = 21;
            this.lblAdres.Text = "Adres:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(17, 239);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(381, 26);
            this.txtTelefon.TabIndex = 20;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(169, 200);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(66, 20);
            this.lblTelefon.TabIndex = 23;
            this.lblTelefon.Text = "Telefon:";
            // 
            // btnKaydetAdres
            // 
            this.btnKaydetAdres.Location = new System.Drawing.Point(139, 307);
            this.btnKaydetAdres.Name = "btnKaydetAdres";
            this.btnKaydetAdres.Size = new System.Drawing.Size(110, 56);
            this.btnKaydetAdres.TabIndex = 24;
            this.btnKaydetAdres.Text = "Kaydet";
            this.btnKaydetAdres.UseVisualStyleBackColor = true;
            // 
            // btnGuncelleAdres
            // 
            this.btnGuncelleAdres.Location = new System.Drawing.Point(138, 307);
            this.btnGuncelleAdres.Name = "btnGuncelleAdres";
            this.btnGuncelleAdres.Size = new System.Drawing.Size(110, 56);
            this.btnGuncelleAdres.TabIndex = 25;
            this.btnGuncelleAdres.Text = "Güncelle";
            this.btnGuncelleAdres.UseVisualStyleBackColor = true;
            // 
            // btnSilAdres
            // 
            this.btnSilAdres.Location = new System.Drawing.Point(376, 307);
            this.btnSilAdres.Name = "btnSilAdres";
            this.btnSilAdres.Size = new System.Drawing.Size(110, 58);
            this.btnSilAdres.TabIndex = 26;
            this.btnSilAdres.Text = "Sil";
            this.btnSilAdres.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.btnKaydetAdres);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Location = new System.Drawing.Point(25, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 411);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAdresler);
            this.groupBox2.Controls.Add(this.btnSec);
            this.groupBox2.Controls.Add(this.btnSilAdres);
            this.groupBox2.Controls.Add(this.btnGuncelleAdres);
            this.groupBox2.Location = new System.Drawing.Point(489, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 411);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Adreslerim";
            // 
            // dgvAdresler
            // 
            this.dgvAdresler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdresler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdresler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdresler.Location = new System.Drawing.Point(48, 52);
            this.dgvAdresler.Name = "dgvAdresler";
            this.dgvAdresler.RowHeadersWidth = 62;
            this.dgvAdresler.RowTemplate.Height = 28;
            this.dgvAdresler.Size = new System.Drawing.Size(542, 231);
            this.dgvAdresler.TabIndex = 29;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(263, 307);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(96, 58);
            this.btnSec.TabIndex = 28;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // frmAdres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adres Sayfası";
            this.Load += new System.EventHandler(this.frmAdres_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Button btnKaydetAdres;
        private System.Windows.Forms.Button btnGuncelleAdres;
        private System.Windows.Forms.Button btnSilAdres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.DataGridView dgvAdresler;
    }
}