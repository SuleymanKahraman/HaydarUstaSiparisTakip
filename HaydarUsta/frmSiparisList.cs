using HaydarUsta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaydarUsta
{
    public partial class frmSiparisList : Form
    {
        private SiparisModel Model;
        private DataHelper helper;
        public frmSiparisList(SiparisModel model)
        {
            InitializeComponent();
            Model = model;
            helper = new DataHelper();
        }


        private void frmSiparisList_Load(object sender, EventArgs e)
        {
            dgvSiparisList.DataSource = helper.TabloGetir($"SELECT * FROM Siparisler WHERE Musteri_Id = {Model.Musteri_Id} AND Durum = 0");
        }

        private void siparişiİptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var durum = (bool)dgvSiparisList.CurrentRow.Cells[8].Value;
            if(durum)
            {
                MessageBox.Show("Siparişiniz teslim edilmiş.", "Bildirim");
            }
            else
            {
                DialogResult YesNo = MessageBox.Show("Siparişinizi iptal etmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YesNo == DialogResult.Yes)
                {
                    Model.Siparis_Id = (int)dgvSiparisList.CurrentRow.Cells[0].Value;
                    var result = helper.SiparisSilme(Model.Siparis_Id);
                    if (result)
                    {
                        MessageBox.Show("Siparişiniz iptal edilmiştir.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("İptal işlemi başarısız veya siparişiniz teslim edilmiş.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                frmSiparisList_Load(null, null);
            
            }
        }
    }
}
