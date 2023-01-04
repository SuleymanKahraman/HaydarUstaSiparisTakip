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
    public partial class frmSiparisGuncelle : Form
    {

        #region Constructor/Load

        /**
         * SiparisBilgileri sayfasına erişen müşteriler güncelle butonu ile bu sayfaya erişir. 
         * Sipariş güncellenmek istenirse yeni siparis bilgileri bu sayfadan girileceğinden eski sipariş bilgileri yeni SiparisModel tipindeki bir field'a atanacaktır. 
         */
        public SiparisModel newSiparis;
        private DataHelper helper;
        public MenuModel menu;
        public frmSiparisGuncelle(SiparisModel siparis)
        {
            InitializeComponent();
            this.newSiparis = siparis;
            helper = new DataHelper();
            menu = new MenuModel();
        }
        private void frmSiparisGuncelle_Load(object sender, EventArgs e)
        {
            

        }
        #endregion

        #region Metotlar

        /**
         * Müşteri siparişini güncellemek istediğinde yeniden sipariş bilgilerini girmesi istenir bu nedenle Musteri.cs'deki işlemler tekrar edilmelidir.  
         */
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
        /**
         * Musteri.cs sayfasından ListBox olarak alınan veriler buradaki listboxa yazdırılır. Bu nedenle SiparisFisi metodu bırada listbox tipinde parametre alacaktır. 
         */
        public void SiparisFisi(ListBox list)
        {
            list.Items.Add("SİPARİŞ ÖZETİ");
            list.Items.Add(" ");
            list.Items.Add("**********");
            list.Items.Add(" ");
            foreach (var prop in typeof(MenuModel).GetProperties())
            {
                var prop1 = prop.GetValue(menu);
                if (prop1 == null)
                {
                    continue;
                }
                list.Items.Add(prop.GetValue(menu));
            }

            list.Items.Add(" ");
            list.Items.Add("**********");
            list.Items.Add($"Toplam Siparis Tutarı: {newSiparis.odemeTurari} TL.");
            list.Items.Add($"Ödeme Yöntemi: {newSiparis.odemeYontemi}");
            list.Items.Add(" ");
            list.Items.Add("**********");
            list.Items.Add($"Adres: {newSiparis.adres}");
            list.Items.Add($"Telefon: {newSiparis.telefon}");
        }
        #endregion

        #region Butonlar

        /**
         * Sipariş güncellemesi esasen siparişin yeni baştan girilmesi işlemidir. 
         * Ana Yemekten seçmek zorunlu olduğundan AnaYemek seçme kontrolü yapılır. 
         * Ardından değiştirilmesini istediğimiz siparişin veri tabanından Id'si SiparisId metodu aracılığıyla elde edilir. 
         * SiparisId 0'a eşit olması demek Id verisinin Veri Tabanından bir nedenle okunmadığı/okunamadığı anlamına gelmektedir. 
         * Id değeri geldiğinde yeni sipariş bilgileri SiparisModel tipindeki field'a eklenir ve SiparisGuncelle metoduna parametre olarak eklenir. 
         * İşlem tamamlandığında bu sayfa kapatılır. 
         */
        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            DialogResult YesNo = MessageBox.Show("Siparişinizi Onaylıyor musunuz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesNo == DialogResult.Yes)
            {
                if (cbAdana.Checked == false && cbTantuni.Checked == false && cbTavukSis.Checked == false && cbKofte.Checked == false && cbUsta.Checked == false && cbLahmacun.Checked == false && cbEtli.Checked == false)
                {
                    MessageBox.Show("Ana Yemeklerden en az bir adet seçmek zorunludur.");
                    return;

                }
                else
                {
                    var Id = helper.SiparisId(this.newSiparis);
                    if (Id == 0)
                    {
                        MessageBox.Show("Siparis Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        this.newSiparis.Siparis_Id = Id;
                        this.newSiparis.odemeTurari = UcretHesapla();
                        this.newSiparis.siparis = SiparisList();
                        this.newSiparis.odemeYontemi = OdemeYontemi();
                        this.newSiparis.siparisTarih = DateTime.Now;
                        var result = helper.SiparisGuncelle(this.newSiparis);
                        if (result)
                        {
                            MessageBox.Show("Siparişiniz Güncellendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion


    }
}
