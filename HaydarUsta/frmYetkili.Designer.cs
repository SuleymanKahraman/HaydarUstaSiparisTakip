namespace HaydarUsta
{
    partial class frmYetkili
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYetkili));
            this.dgv_Siparisler = new System.Windows.Forms.DataGridView();
            this.cms_yetkili = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teslimEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iptalEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Siparisler)).BeginInit();
            this.cms_yetkili.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Siparisler
            // 
            this.dgv_Siparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Siparisler.ContextMenuStrip = this.cms_yetkili;
            this.dgv_Siparisler.Location = new System.Drawing.Point(31, 29);
            this.dgv_Siparisler.Name = "dgv_Siparisler";
            this.dgv_Siparisler.ReadOnly = true;
            this.dgv_Siparisler.Size = new System.Drawing.Size(879, 499);
            this.dgv_Siparisler.TabIndex = 0;
            // 
            // cms_yetkili
            // 
            this.cms_yetkili.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teslimEtToolStripMenuItem,
            this.iptalEtToolStripMenuItem});
            this.cms_yetkili.Name = "cms_yetkili";
            this.cms_yetkili.Size = new System.Drawing.Size(181, 70);
            // 
            // teslimEtToolStripMenuItem
            // 
            this.teslimEtToolStripMenuItem.Name = "teslimEtToolStripMenuItem";
            this.teslimEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teslimEtToolStripMenuItem.Text = "Teslim Et";
            this.teslimEtToolStripMenuItem.Click += new System.EventHandler(this.teslimEtToolStripMenuItem_Click);
            // 
            // iptalEtToolStripMenuItem
            // 
            this.iptalEtToolStripMenuItem.Name = "iptalEtToolStripMenuItem";
            this.iptalEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iptalEtToolStripMenuItem.Text = "İptal Et";
            this.iptalEtToolStripMenuItem.Click += new System.EventHandler(this.iptalEtToolStripMenuItem_Click);
            // 
            // frmYetkili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 566);
            this.Controls.Add(this.dgv_Siparisler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmYetkili";
            this.Text = "İşletme Sayfası";
            this.Load += new System.EventHandler(this.frmYetkili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Siparisler)).EndInit();
            this.cms_yetkili.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Siparisler;
        private System.Windows.Forms.ContextMenuStrip cms_yetkili;
        private System.Windows.Forms.ToolStripMenuItem teslimEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iptalEtToolStripMenuItem;
    }
}