using HaydarUsta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaydarUsta
{
    public partial class frmMusteri : Form
    {
        private LoginModel login;
        private SiparisModel siparis;
        private DataHelper helper;
        private MenuModel menu;
        public frmMusteri(LoginModel model)
        {
            InitializeComponent();
            this.login = model;
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            lblİsim.Text = login.ad + " " + login.soyad;
            helper = new DataHelper();
            siparis= new SiparisModel();
            menu = new MenuModel();
            siparis.Musteri_Id = login.Id;

        }
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (cbAdana.Checked == false && cbTantuni.Checked == false && cbTavukSis.Checked == false && cbKofte.Checked == false && cbUsta.Checked == false && cbLahmacun.Checked == false && cbEtli.Checked == false)
            {
                MessageBox.Show("Ana Yemeklerden en az bir adet seçmek zorunludur.");
                return;

            }
            else
            {

                DialogResult YesNo = MessageBox.Show("Siparişinizi Onaylıyor musunuz?", "", MessageBoxButtons.YesNo);
                if (YesNo == DialogResult.Yes)
                {
                    frmAdres adres = new frmAdres(siparis);
                    adres.ShowDialog();
                    adres.Dispose();
                    if (siparis.adres != null)
                    {
                        siparis.odemeTurari = UcretHesapla();
                        siparis.siparis = SiparisList();
                        siparis.odemeYontemi=OdemeYontemi();
                        siparis.siparisTarih=DateTime.Now;    
                        var result = helper.SiparisEkle(siparis);
                        if (result)
                        {
                            MessageBox.Show("İşleminiz başarıyla gerçekleşti. Afiyet olsun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SiparisFisi();
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                    }
                    
                }
                else
                {
                    Clear();
                }

            }
        }

        private void SiparisFisi()
        {
            lbFatura.Items.Add("SİPARİŞ ÖZETİ");
            lbFatura.Items.Add(" ");
            lbFatura.Items.Add("**********");
            lbFatura.Items.Add(" ");
            foreach (var prop in typeof(MenuModel).GetProperties())
            {
                var prop1 = prop.GetValue(menu);
                if (prop1 == null)
                {
                    continue;
                }
                lbFatura.Items.Add(prop.GetValue(menu));
            }
            lbFatura.Items.Add(" ");
            lbFatura.Items.Add("**********");
            lbFatura.Items.Add($"Toplam Siparis Tutarı: {siparis.odemeTurari} TL.");
            lbFatura.Items.Add($"Ödeme Yöntemi: {siparis.odemeYontemi}");
            lbFatura.Items.Add(" ");
            lbFatura.Items.Add("**********");
            lbFatura.Items.Add($"Adres: {siparis.adres}");
            lbFatura.Items.Add($"Telefon: {siparis.telefon}");
        }
        private string OdemeYontemi()
        {
            if (rbKrediKarti.Checked)
            {
                return "Kredi Kartı";
            }
            return "Nakit";
        }
        private string SiparisList()
        {
            // Class Properties'lerden veri aktarma
            string siparis = string.Empty;
            foreach (var prop in typeof(MenuModel).GetProperties())
            {
                var prop1 = prop.GetValue(menu);
                if (prop1 == null)
                {
                    continue;
                }
                siparis += prop.GetValue(menu);
            }
            return siparis;
        }
        //TODO: her combobox için seçilen ürünler siparişler olarak liste şeklinde veri tabanına kaydedileceğinden combobox.text özelliğinden yararlanalım. 
        private decimal UcretHesapla()
        {
            decimal ucret = 0;
            if (cbAdana.Checked)
            {
                ucret += (nmAdanaKebap.Value * 78);
                menu.adanaKebab = $" {nmAdanaKebap.Value} Adet Adana Kebap";
            }
            if (cbTantuni.Checked)
            {
                ucret += (nmTantuni.Value * 65);
                menu.tantuni = $" {nmTantuni.Value} Adet Tantuni";

            }
            if (cbTavukSis.Checked)
            {
                ucret += (nmTavukSis.Value * 65);
                menu.tavukSis = $" {nmTavukSis.Value} Adet Tavuk Şiş";

            }
            if (cbKofte.Checked)
            {
                ucret += (nmKofte.Value * 72);
                menu.kofte = $" {nmKofte.Value} Adet Köfte";

            }
            if (cbUsta.Checked)
            {
                ucret += (nmUsta.Value * 80);
                menu.ustaSpesiyel = $" {nmUsta.Value} Adet Ustanın Sipesiyeli";

            }
            if (cbLahmacun.Checked)
            {
                ucret += (nmLahmacun.Value * 25);
                menu.lahmacun = $" {nmLahmacun.Value} Adet Lahmacun";

            }
            if (cbEtli.Checked)
            {
                ucret += (nmEtli.Value * 58);
                menu.etliEkmek = $" {nmEtli.Value} Adet Etli Ekmek";

            }
            if (cbHumus.Checked)
            {
                ucret += (nmHumus.Value * 20);
                menu.humus = $" {nmHumus.Value} Adet Humus";

            }
            if (cbTarator.Checked)
            {
                ucret += (nmTarator.Value * 20);
                menu.tarator = $" {nmTarator.Value} Adet Tarator";

            }
            if (cbAtom.Checked)
            {
                ucret += (nmAtom.Value * 25);
                menu.atom = $" {nmAtom.Value} Adet Atom";

            }
            if (cbOcce.Checked)
            {
                ucret += (nmOcce.Value * 25);
                menu.occe = $" {nmOcce.Value} Adet Öcce";

            }
            if (cbZeytin.Checked)
            {
                ucret += (nmZeytin.Value * 15);
                menu.zeytinSalata = $" {nmZeytin.Value} Adet Zeytin Salatası";

            }
            if (cbCoban.Checked)
            {
                ucret += (nmCoban.Value * 15);
                menu.cobanSalata = $" {nmCoban.Value} Adet Çoban Salatası";

            }
            if (cbTursu.Checked)
            {
                ucret += (nmTursu.Value * 10);
                menu.tursu = $" {nmTursu.Value} Adet Turşu";

            }
            if (cbKola.Checked)
            {
                ucret += (nmKola.Value * 8);
                menu.kola = $" {nmKola.Value} Adet Kola";

            }
            if (cbFanta.Checked)
            {
                ucret += (nmFanta.Value * 8);
                menu.fanta = $" {nmFanta.Value} Adet Fanta";

            }
            if (cbKayran.Checked)
            {
                ucret += (nmKayran.Value * 6);
                menu.kAyran = $" {nmKayran.Value} Adet Kapalı Ayran";

            }
            if (cbAayran.Checked)
            {
                ucret += (nmAayran.Value * 10);
                menu.aAyran = $" {nmAayran.Value} Adet Açık Ayran";

            }
            if (cbSalgam.Checked)
            {
                ucret += (nmSalgam.Value * 8);
                menu.salgam = $" {nmSalgam.Value} Adet Salgam";

            }
            if (cbLipton.Checked)
            {
                ucret += (nmLipton.Value * 8);
                menu.liptonIcetea = $" {nmLipton.Value} Adet Lipton Ice Tea";

            }
            if (cbSu.Checked)
            {
                ucret += (nmSu.Value * 5);
                menu.su = $" {nmSu.Value} Adet Su";
            }
            return ucret;

        }
        private void Clear()
        {
            foreach (Control c in gbAnaYemek.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 1;
                }
            }
            foreach (Control c in gbMzSlt.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 1;
                }
            }
            foreach (Control c in gbIcecek.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 1;
                }
            }
        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSiparisBilgileri siparisBilgiler = new frmSiparisBilgileri(siparis,menu);
            siparisBilgiler.ShowDialog();
            siparisBilgiler.Dispose();
            lbFatura.Items.Clear();
            Clear();
        }

        private void musteriGuncelleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMusteriGuncelle musteriBilgileri = new frmMusteriGuncelle(login);
            musteriBilgileri.ShowDialog();
            musteriBilgileri.Dispose();
        }

        private void hesabıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                var result = helper.MusteriSilme(login.Id);
                if (result)
                {
                    MessageBox.Show("Hesabınızı sildiğiniz için üzgünüz. Tekrar bekleriz.", "Bildirim",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Başarısız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            Clear();
        }

       
    }
}
