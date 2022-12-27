using HaydarUsta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaydarUsta
{
    public partial class frmSiparisBilgileri : Form
    {
        private SiparisModel siparis;
        private  MenuModel menu;
        private DataHelper helper;

        public frmSiparisBilgileri(SiparisModel siparis, MenuModel menu)
        {
            InitializeComponent();
            this.siparis= siparis;
            this.menu= menu;
            helper = new DataHelper();
        }


        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            SiparisFisi();
        }

        private void SiparisFisi()
        {
            listSiparis.Items.Add("SİPARİŞ ÖZETİ");
            listSiparis.Items.Add(" ");
            listSiparis.Items.Add("**********");
            listSiparis.Items.Add(" ");
            foreach (var prop in typeof(MenuModel).GetProperties())
            {
                var prop1 = prop.GetValue(menu);
                if (prop1 == null)
                {
                    continue;
                }
                listSiparis.Items.Add(prop.GetValue(menu));
            }
            listSiparis.Items.Add(" ");
            listSiparis.Items.Add("**********");
            listSiparis.Items.Add($"Toplam Siparis Tutarı: {siparis.odemeTurari} TL.");
            listSiparis.Items.Add($"Ödeme Yöntemi: {siparis.odemeYontemi}");
            listSiparis.Items.Add(" ");
            listSiparis.Items.Add("**********");
            listSiparis.Items.Add($"Adres: {siparis.adres}");
            listSiparis.Items.Add($"Telefon: {siparis.telefon}");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            frmSiparisGuncelle guncelle = new frmSiparisGuncelle(siparis);
            guncelle.ShowDialog();
            guncelle.Dispose();
            listSiparis.Items.Clear();
            guncelle.SiparisFisi(listSiparis);

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult YesNo = MessageBox.Show("Siparişinizi iptal etmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                int Id = helper.SiparisId(siparis);
                var result = helper.SiparisSilme(Id);
                if (result)
                {
                    MessageBox.Show("Siparişiniz iptal edilmiştir.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listSiparis.Items.Clear();
                }
                else
                {
                    MessageBox.Show("İptal işlemi başarısız. Tekrar deneyiniz.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
