namespace HaydarUsta
{
    partial class frmSiparisList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisList));
            this.dgvSiparisList = new System.Windows.Forms.DataGridView();
            this.cmsIptal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparişiİptalEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisList)).BeginInit();
            this.cmsIptal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSiparisList
            // 
            this.dgvSiparisList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisList.ContextMenuStrip = this.cmsIptal;
            this.dgvSiparisList.Location = new System.Drawing.Point(218, 82);
            this.dgvSiparisList.Name = "dgvSiparisList";
            this.dgvSiparisList.RowHeadersWidth = 62;
            this.dgvSiparisList.RowTemplate.Height = 28;
            this.dgvSiparisList.Size = new System.Drawing.Size(1148, 522);
            this.dgvSiparisList.TabIndex = 0;
            // 
            // cmsIptal
            // 
            this.cmsIptal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsIptal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişiİptalEtToolStripMenuItem});
            this.cmsIptal.Name = "cmsIptal";
            this.cmsIptal.Size = new System.Drawing.Size(241, 69);
            // 
            // siparişiİptalEtToolStripMenuItem
            // 
            this.siparişiİptalEtToolStripMenuItem.Name = "siparişiİptalEtToolStripMenuItem";
            this.siparişiİptalEtToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.siparişiİptalEtToolStripMenuItem.Text = "Siparişi İptal Et";
            this.siparişiİptalEtToolStripMenuItem.Click += new System.EventHandler(this.siparişiİptalEtToolStripMenuItem_Click);
            // 
            // frmSiparisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 767);
            this.Controls.Add(this.dgvSiparisList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSiparisList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sipariş Listem";
            this.Load += new System.EventHandler(this.frmSiparisList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisList)).EndInit();
            this.cmsIptal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisList;
        private System.Windows.Forms.ContextMenuStrip cmsIptal;
        private System.Windows.Forms.ToolStripMenuItem siparişiİptalEtToolStripMenuItem;
    }
}