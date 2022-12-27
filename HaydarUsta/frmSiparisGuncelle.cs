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
    public partial class frmSiparisGuncelle : Form
    {
        public SiparisModel Model;
        List<string> MenuList = new List<string>();
        private DataHelper helper;

        public frmSiparisGuncelle(SiparisModel model)
        {
            InitializeComponent();
            Model = model;
            helper = new DataHelper();
        }
        private void frmSiparisGuncelle_Load(object sender, EventArgs e)
        {

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
                siparis += item.ToString() + " ";
            }
            return siparis;
        }
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

        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            DialogResult YesNo = MessageBox.Show("Siparişinizi Onaylıyor musunuz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesNo == DialogResult.Yes)
            {
                var Id = helper.VeriAl(Model);
                if (Id == 0)
                {
                    MessageBox.Show("Siparis Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Model.Siparis_Id= Id;
                    Model.siparis = SiparisList();
                    Model.odemeTurari = UcretHesapla();
                    Model.odemeYontemi = OdemeYontemi();
                    Model.siparisTarih = DateTime.Now;
                    var result = helper.SiparisGuncelle(Model);
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

        private void btnAdresSayfa_Click(object sender, EventArgs e)
        {
            frmAdres adres = new frmAdres(Model);
            adres.ShowDialog();
            adres.Dispose();
        }
    }
}
