namespace HaydarUsta
{
    partial class MusteriBilgileri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMusteri = new System.Windows.Forms.DataGridView();
            this.dgvSiparis = new System.Windows.Forms.DataGridView();
            this.dgvAdres = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdres)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMusteri);
            this.groupBox1.Location = new System.Drawing.Point(45, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Musteri Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSiparis);
            this.groupBox2.Location = new System.Drawing.Point(533, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparis Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAdres);
            this.groupBox3.Location = new System.Drawing.Point(1021, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 335);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adres Bilgileri";
            // 
            // dgvMusteri
            // 
            this.dgvMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteri.Location = new System.Drawing.Point(6, 25);
            this.dgvMusteri.Name = "dgvMusteri";
            this.dgvMusteri.RowHeadersWidth = 62;
            this.dgvMusteri.RowTemplate.Height = 28;
            this.dgvMusteri.Size = new System.Drawing.Size(470, 304);
            this.dgvMusteri.TabIndex = 0;
            // 
            // dgvSiparis
            // 
            this.dgvSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparis.Location = new System.Drawing.Point(6, 25);
            this.dgvSiparis.Name = "dgvSiparis";
            this.dgvSiparis.RowHeadersWidth = 62;
            this.dgvSiparis.RowTemplate.Height = 28;
            this.dgvSiparis.Size = new System.Drawing.Size(470, 304);
            this.dgvSiparis.TabIndex = 1;
            // 
            // dgvAdres
            // 
            this.dgvAdres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdres.Location = new System.Drawing.Point(0, 25);
            this.dgvAdres.Name = "dgvAdres";
            this.dgvAdres.RowHeadersWidth = 62;
            this.dgvAdres.RowTemplate.Height = 28;
            this.dgvAdres.Size = new System.Drawing.Size(476, 304);
            this.dgvAdres.TabIndex = 1;
            // 
            // MusteriBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 864);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MusteriBilgileri";
            this.Text = "MusteriBilgileri";
            this.Load += new System.EventHandler(this.MusteriBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMusteri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSiparis;
        private System.Windows.Forms.DataGridView dgvAdres;
    }
}