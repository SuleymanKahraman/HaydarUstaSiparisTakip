using System;
using System.Windows.Forms;

namespace HaydarUsta
{
    public partial class frmYetkili : Form
    {
        #region Constructor/Load

        private DataHelper helper;

        /**
         * Burada SQL'in İnner Join metodu ile farklı tablolardaki sütünlerin birlikte gösterilmesini sağlayan (Musteri ve Siparisler tabloları) bir SQL komutu oluşturuldu. DataHelper.TabloGetir metoduna bu SQL komutu yerleştirildi ve Admin panelindeki DataGridVİew'e yansıtıldı. 
         */
        public frmYetkili()
        {
            InitializeComponent();
            helper = new DataHelper();
        }

        private void frmYetkili_Load(object sender, EventArgs e)
        {
            var sql = "SELECT s.Id, s.Siparis, m.Ad, m.Soyad, m.EmailAdres, s.SiparisTarihi, s.OdemeTutari, s.OdemeYontemi, s.Adres, s.Telefon, s.Durum FROM Siparisler AS s INNER JOIN Musteriler AS m ON m.Id = s.Musteri_Id";
            dgv_Siparisler.DataSource = helper.TabloGetir(sql);
        }
        #endregion
        #region Butonlar

        /**
         * Siparişler Admin tarafından teslim edildikten sonra teslim et butonuna basılarak siparişin durumu True çevrilir ve işlem tamamlanır.
         * Yetkili ayrıca siparişi iptal etmek isterse iptal ederek sipariş veri tabanından komple silinir. 
         */

        private void teslimEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var siparisId = (int)dgv_Siparisler.CurrentRow.Cells[0].Value;
            var result = helper.TeslimEt(siparisId);
            if (result)
            {
                MessageBox.Show("Sipariş Teslim Edildi", "Bildirim");
            }
            else
            {
                MessageBox.Show("Bir sorun oluştu", "Uyarı");
            }
            frmYetkili_Load(null, null);
        }

        private void iptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var siparisId = (int)dgv_Siparisler.CurrentRow.Cells[0].Value;
            var result = helper.SiparisSilme(siparisId);
            if (result)
            {
                MessageBox.Show("Sipariş İptal Edildi", "Bildirim");
            }
            else
            {
                MessageBox.Show("Bir sorun oluştu veya sipariş zaten teslim edildi.", "Uyarı");
            }
            frmYetkili_Load(null, null);
        }
        #endregion

    }
}