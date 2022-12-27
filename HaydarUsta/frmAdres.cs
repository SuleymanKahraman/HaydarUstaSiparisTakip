using HaydarUsta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaydarUsta
{
    public partial class frmAdres : Form
    {
        private DataHelper helper;
        private SiparisModel siparis;
        private AdresModel adres;

        public frmAdres(SiparisModel model)
        {
            InitializeComponent();
            siparis = model;
            helper = new DataHelper();
            adres = new AdresModel();
        }

        private void frmAdres_Load(object sender, EventArgs e)
        {
            dgvAdresler.DataSource = helper.TabloGetir($"SELECT Id, Baslık, Adres, Telefon FROM Adresler WHERE Musteri_Id ='{siparis.Musteri_Id}'");
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            siparis.adres = dgvAdresler.CurrentRow.Cells[2].Value.ToString();
            siparis.telefon = dgvAdresler.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adres.Id = (int)dgvAdresler.CurrentRow.Cells[0].Value;
            adres.musteri_Id = siparis.Musteri_Id;
            adres.baslik = dgvAdresler.CurrentRow.Cells[1].Value.ToString();
            adres.adres = dgvAdresler.CurrentRow.Cells[2].Value.ToString();
            adres.telefon = dgvAdresler.CurrentRow.Cells[3].Value.ToString();
            frmAdresGuncelle guncelle = new frmAdresGuncelle(adres);
            guncelle.ShowDialog();
            guncelle.Dispose();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adres.Id = (int)dgvAdresler.CurrentRow.Cells[0].Value;
            var result = helper.AdresSilme(adres.Id);
            if (result)
            {
                MessageBox.Show("Silme işlemi başarılı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
