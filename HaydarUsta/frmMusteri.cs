using HaydarUsta.Models;
using System;
using System.Windows.Forms;

namespace HaydarUsta
{
    //TODO: her combobox için seçilen ürünler siparişler olarak liste şeklinde veri tabanına kaydedileceğinden combobox.text özelliğinden yararlanalım.
    public partial class frmMusteri : Form
    {
        #region Construct/Load
        /**
         * Formlar arası veri aktarımı sağlamak için frmMusteri.cs'in Constructor'ına LoginModel tipinde parametre tanımladık. Müşteri login olduğunda müşteri bilgilerini LoginModel tipinde bir fielda atayacağız.
         * Ayrıca sipariş bilgilerini ve menü bilgilerini fieldlara kaydetmek için farklı classlar tanımladım: SiparisModel ve MenuModel.
         *
         */

        private LoginModel login;
        private SiparisModel siparis;
        private DataHelper helper;
        private MenuModel menu;

        public frmMusteri(LoginModel model)
        {
            InitializeComponent();
            this.login = model;
            helper = new DataHelper();
            lblİsim.Text = login.ad + " " + login.soyad;
        }

        /**
         * DataHelper.cs, SiparisModel.cs ve MenuModel.cs'den örnek alındı.
         * Müsterinin SQL tablosundaki Id'sini SiparisModel'deki Musteri_Id'ye atarız. Nitekim Musteri_Id SQL tablolarında ForeignKey işlevi görmektedir.
         */

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            Clear();
            lbFatura.Items.Clear();
            siparis = new SiparisModel();
            menu = new MenuModel();
            siparis.Musteri_Id = login.Id;
        }

        #endregion Construct/Load

        #region Butonlar

        /**
         * ckeckboxlar ve numericUpDown'lardan oluşan menüden yapılan seçimler sonucunda müşteri TAMAM butonuna basarak sipariş kayıt işlemleri başlanır.
         * AnaYemekten seçmek zorunlu olduğundan müşteri anayemekten seçmediği durumda uyarılır.
         * Sipariş doğru girilmiş ise MessageBox aracılığıyla ONAY talep edilir. Onay verilmezse menü checkboxları ve numericUpDown'ları Clear metoduyla güncellenir.
         * Müşteri siparişini onayladıktan sonra frmAdres sayfasından kayıtlı adresi varsa istediği adresi, kayıtlı adresi yoksa yeni adresini ve telefonunu kaydettikten sonra kaydettiği adresi seçmesi istenir.
         * Adres seçimi gerçekleştiyse SiparisModel fieldlarına diğer sipariş bilgileri atanır ve ardından SiparisEkle metoduyla sipariş eklenir (siparis bilgilerinin nasıl oluştuğu aşağıda anlatılmaktadır).
         * Adres seçimi gerçekleşmediyse goto metoduyla adres sayfasına yönlendirilmek üzere geri dönderilir.
         *
         *
         */

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (cbAdana.Checked == false && cbTantuni.Checked == false && cbTavukSis.Checked == false && cbKofte.Checked == false && cbUsta.Checked == false && cbLahmacun.Checked == false && cbEtli.Checked == false)
            {
                MessageBox.Show("Ana Yemeklerden en az bir adet seçmek zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult YesNo = MessageBox.Show("Siparişinizi Onaylıyor musunuz?", "Bildirim", MessageBoxButtons.YesNo);
                if (YesNo == DialogResult.Yes)
                {
                    siparis.odemeTurari = UcretHesapla();
                    siparis.siparis = SiparisList();
                    siparis.odemeYontemi = OdemeYontemi();
                    siparis.siparisTarih = DateTime.Now;
                    if (siparis.adres == null)
                    {
                        frmAdres adres = new frmAdres(siparis);
                        adres.ShowDialog();
                        adres.Dispose();
                    }
                    var result = helper.SiparisEkle(siparis);
                    if (result)
                    {
                        MessageBox.Show("İşleminiz başarıyla gerçekleşti. Afiyet olsun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SiparisFisi();
                    }
                    else
                    {
                        MessageBox.Show("İşlem Başarısız. Tekrar Deneyiniz.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    Clear();
                }
            }
        }

        /**
         * Yeniden sipariş girmek isteyen müşteri için checkbox ve numericUpDownları resetlemek için Yeni Sipariş butonu koyduk.
         */

        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            frmKullanici_Load(null, null);
            rbNakit.Enabled = true;
            
        }

        /**
         * Sipariş alındıktan sonra Sipariş bilgilerini güncellemek istenirse MenuStrip alt butonu olarak tasarlanmış Siparis Güncelle butonuna basılır.
         * siparis kaydı oluşmamışsa SiparsiModel.cs'teki siparis propertisi null olacağından güncelleme veya iptal işlemleri yapılmamalıdır.
         * Siparis verildikten sonra güncelleme sayfasına yönlendirilir.
         * Yeni sipariş listesi güncellenmiş halde Listbox'a geçirilir.
         */

        private void siparişGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (siparis.siparis == null)
            {
                MessageBox.Show("Siparişiniz mevcut değil.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmSiparisGuncelle guncelle = new frmSiparisGuncelle(siparis);
                guncelle.ShowDialog();
                guncelle.Dispose();
                lbFatura.Items.Clear();
                guncelle.SiparisFisi(lbFatura);
                Clear();
            }
        }

        /**
         * Siparişi iptal etmek istediğimiz eğer sipariş kaydımız var ise MenuStrip alt butonu olarak tasarlanmış Siparis İptal butonuna basmak yeterli.
         */

        private void siparişİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (siparis.siparis == null)
            {
                MessageBox.Show("Siparişiniz mevcut değil.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult YesNo = MessageBox.Show("Siparişinizi iptal etmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YesNo == DialogResult.Yes)
                {
                    siparis.Siparis_Id = helper.SiparisId(siparis);
                    var result = helper.SiparisSilme(siparis.Siparis_Id);
                    if (result)
                    {
                        MessageBox.Show("Siparişiniz iptal edilmiştir.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmKullanici_Load(null, null);
                        lbFatura.Items.Clear();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("İptal işlemi başarısız veya siparişiniz teslim edilmiş.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        /**
         * Sipariş bilgilerinden sadece adres ve telefon değişikliği yapılmak istenirse yine MenuStrip alt butonu olarak tasarlanmış Adres Güncelle butonuna basılır.
         * Adres Güncellemek için adres sayfasına yönlendirilir.
         * Adres sayfasında istenilen adres seçilir ve yeni adresli sipariş bilgileri listbox'a yazdırılır.
         */

        private void adresGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (siparis.siparis == null)
            {
                MessageBox.Show("Siparişiniz mevcut değil.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmAdres newAdres = new frmAdres(siparis);
                newAdres.ShowDialog();
                newAdres.Dispose();
                lbFatura.Items.Clear();
                SiparisFisi();
            }
        }

        /**
         * Musteri SQL'deki bilgilerinin güncellemek için Menuden frmMusteriGuncelle sayfasına yönlendirilmek üzere LoginModel tipinde bir değişkeni parametre olarak alan frmMusteriGuncelle adında bir class oluşturuldu.
         */

        private void musteriGuncelleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMusteriGuncelle guncelle = new frmMusteriGuncelle(login);
            guncelle.ShowDialog();
            guncelle.Dispose();
            

        }

        /**
         * Musteri hesabını silmek için bir MenuStrip butonu oluşturuldu.
         * Silmek istenilen hesabın Login.Id'sini parametre olarak alan MusteriSilme adında bir metot oluşturuldu.
         * Hesap silindiğinde Musteri.cs sayfası kapatılacaktır.Böylece kullanıcı yeniden kayıt olması gerekmektedir.
         */

        private void hesabıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var result = helper.MusteriSilme(login.Id);
                if (result)
                {
                    MessageBox.Show("Hesabınızı sildiğiniz için üzgünüz. Tekrar bekleriz.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Başarısız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        /**
         * Müşteri adres işlemlerini gerçekleştirmek üzere frmAdres.cs sayfasına yönlenebileceği bir MenuStrip menusu oluşturuldu.
         */

        private void adresBilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdres adres = new frmAdres(siparis);
            adres.ShowDialog();
            adres.Dispose();
        }

        private void siparişlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSiparisList list = new frmSiparisList(siparis);
            list.ShowDialog();
            list.Dispose();
        }

        #endregion Butonlar

        #region Metotlar

        /**
         * SiparisFisi() metodu listbox'a verilen sipariş özetini koymak için tasarlandı.
         * Menu checkboxlarından seçilen siparişler MenuModel tipinde bir field'a kaydedilir.
         * Ardından kayıtlı menü bilgilerini listbox'a yazdırmak için MenüModel clasının propertilerini kontrol eden bir foreach döngüsü tasarlandı. Amaç, hangi property dolu ise onun listbox'a yazılması sağlamak.
         * Diğer sipariş bilgileri ise SiparisModel.cs propertilerinden elde edilmiştir.
         */

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

        /**
         * radiobutton'lardan oluşturulan ödeme seçeneklerinin belirlenmesini sağlayan metot
         * Nakit default olarak seçili olmalıdır.
         */

        private string OdemeYontemi()
        {
            if (rbKrediKarti.Checked)
            {
                return "Kredi Kartı";
            }
            return "Nakit";
        }

        /**
         * Burada menüden seçilen yiyecek ve içecekleri tek bir string değişkenine atamak için tasarlanmış bir metottur.
         * Bunun nedeni, Veri Tabanına Siparisler tablosundaki siparis kısmına tek bir string değişken olarak kaydetmemizden dolayıdır.
         */

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

        /**
         * Checkbox olarak tasarlanmış menü çeşitleri ve adetlerin belirlendiği numericUpDown'lar sayesinde siparisin tutarı belirlenir.
         * Hangi hangi yiyecek ve içeçekten seçim yapıldıysa o yiyecek ve içeçekler MenuModel.cs'de karşılığı property'lere string olarak kaydedilir.
         * Metot ücret olarak dönecektir.
         */

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
         * Checkbox ve numericUpDown'ları resetlemek için oluşturulan metot
         */

        private void Clear()
        {
            foreach (Control c in gbAnaYemek.Controls)
            {
                if (c is CheckBox box)
                {
                    box.Checked = false;
                }
                else if (c is NumericUpDown nud)
                {
                    nud.Value = 1;
                }
            }
            foreach (Control c in gbMzSlt.Controls)
            {
                if (c is CheckBox box)
                {
                    box.Checked = false;
                }
                else if (c is NumericUpDown nud)
                {
                    nud.Value = 1;
                }
            }
            foreach (Control c in gbIcecek.Controls)
            {
                if (c is CheckBox box)
                {
                    box.Checked = false;
                }
                else if (c is NumericUpDown nud)
                {
                    nud.Value = 1;
                }
            }
        }

        #endregion Metotlar

       
    }
}