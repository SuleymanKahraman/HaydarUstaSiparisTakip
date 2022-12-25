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
    public partial class frmMusteri : Form
    {
        private LoginModel loginModel;
        private MenuModel menuModel;
        private DataHelper helper;
        List<string> MenuList = new List<string>();
        public frmMusteri(LoginModel model)
        {
            InitializeComponent();
            this.loginModel = model;
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            txtAdSoyad.Text = loginModel.ad + " " + loginModel.soyad;
            helper = new DataHelper();
            menuModel= new MenuModel();
            menuModel.Musteri_Id = loginModel.Id;

        }
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (cbAdana.Checked == false && cbTantuni.Checked == false && cbTavukSis.Checked == false && cbKofte.Checked == false && cbUsta.Checked == false && cbLahmacun.Checked == false && cbEtli.Checked == false)
            {
                MessageBox.Show("Ana Yemeklerden en az bir adet seçmek zorunludur.");
                Clear();

            }
            else
            {

                DialogResult YesNo = MessageBox.Show("Siparişinizi Onaylıyor musunuz?", "", MessageBoxButtons.YesNo);
                if (YesNo == DialogResult.Yes)
                {
                    frmAdres adres = new frmAdres(menuModel);
                    adres.ShowDialog();
                    adres.Dispose();
                    if (menuModel.adres != null)
                    {
                        menuModel.odemeTurari = UcretHesapla();
                        menuModel.siparis = SiparisList();
                        menuModel.odemeYontemi=OdemeYontemi();
                        menuModel.siparisTarih=DateTime.Now;    
                        var result = helper.SiparisEkle(menuModel);
                        if (result)
                        {
                            MessageBox.Show("İşleminiz başarıyla gerçekleşti. Afiyet olsun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
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
            foreach (var item in MenuList)
            {
                lbFatura.Items.Add(item.ToString());
                siparis += item.ToString() + " ";

            }
            lbFatura.Items.Add("**********");
            lbFatura.Items.Add($"Toplam Siparis Tutarı: {menuModel.odemeTurari} TL.");
            return siparis;
        }
        //TODO: her combobox için seçilen ürünler siparişler olarak liste şeklinde veri tabanına kaydedileceğinden combobox.text özelliğinden yararlanalım. 
        private decimal UcretHesapla()
        {
            decimal ucret = 0;
            if (cbAdana.Checked)
            {
                ucret += (nmAdanaKebap.Value * 78);
                MenuList.Add($" {nmAdanaKebap.Value} Adet Adana Kebap");
            }
            if (cbTantuni.Checked)
            {
                ucret += (nmTantuni.Value * 65);
                MenuList.Add($" {nmTantuni.Value} Adet Tantuni");

            }
            if (cbTavukSis.Checked)
            {
                ucret += (nmTavukSis.Value * 65);
                MenuList.Add($" {nmTavukSis.Value} Adet Tavuk Şiş");

            }
            if (cbKofte.Checked)
            {
                ucret += (nmKofte.Value * 72);
                MenuList.Add($" {nmKofte.Value} Adet Köfte");

            }
            if (cbUsta.Checked)
            {
                ucret += (nmUsta.Value * 80);
                MenuList.Add($" {nmUsta.Value} Adet Ustanın Sipesiyeli");

            }
            if (cbLahmacun.Checked)
            {
                ucret += (nmLahmacun.Value * 25);
                MenuList.Add($" {nmLahmacun.Value} Adet Lahmacun");

            }
            if (cbEtli.Checked)
            {
                ucret += (nmEtli.Value * 58);
                MenuList.Add($" {nmEtli.Value} Adet Etli Ekmek");

            }
            if (cbHumus.Checked)
            {
                ucret += (nmHumus.Value * 20);
                MenuList.Add($" {nmHumus.Value} Adet Humus");

            }
            if (cbTarator.Checked)
            {
                ucret += (nmTarator.Value * 20);
                MenuList.Add($" {nmTarator.Value} Adet Tarator");

            }
            if (cbAtom.Checked)
            {
                ucret += (nmAtom.Value * 25);
                MenuList.Add($" {nmAtom.Value} Adet Atom");

            }
            if (cbOcce.Checked)
            {
                ucret += (nmOcce.Value * 25);
                MenuList.Add($" {nmOcce.Value} Adet Öcce");

            }
            if (cbZeytin.Checked)
            {
                ucret += (nmZeytin.Value * 15);
                MenuList.Add($" {nmZeytin.Value} Adet Zeytin Salatası");

            }
            if (cbCoban.Checked)
            {
                ucret += (nmCoban.Value * 15);
                MenuList.Add($" {nmCoban.Value} Adet Çoban Salatası");

            }
            if (cbTursu.Checked)
            {
                ucret += (nmTursu.Value * 10);
                MenuList.Add($" {nmTursu.Value} Adet Turşu");

            }
            if (cbKola.Checked)
            {
                ucret += (nmKola.Value * 8);
                MenuList.Add($" {nmKola.Value} Adet Kola");

            }
            if (cbFanta.Checked)
            {
                ucret += (nmFanta.Value * 8);
                MenuList.Add($" {nmFanta.Value} Adet Fanta");

            }
            if (cbKayran.Checked)
            {
                ucret += (nmKayran.Value * 6);
                MenuList.Add($" {nmKayran.Value} Adet Kapalı Ayran");

            }
            if (cbAayran.Checked)
            {
                ucret += (nmAayran.Value * 10);
                MenuList.Add($" {nmAayran.Value} Adet Açık Ayran");

            }
            if (cbSalgam.Checked)
            {
                ucret += (nmSalgam.Value * 8);
                MenuList.Add($" {nmSalgam.Value} Adet Salgam");

            }
            if (cbLipton.Checked)
            {
                ucret += (nmLipton.Value * 8);
                MenuList.Add($" {nmLipton.Value} Adet Lipton Ice Tea");

            }
            if (cbSu.Checked)
            {
                ucret += (nmSu.Value * 5);
                MenuList.Add($" {nmSu.Value} Adet Su");

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

        private void bilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
