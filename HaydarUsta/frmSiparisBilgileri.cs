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
        private SiparisModel Model;
        private readonly List<string> list;

        public frmSiparisBilgileri(SiparisModel model, List<string> list)
        {
            InitializeComponent();
            Model = model;
            this.list = list;
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
            foreach (var item in list)
            {
                listSiparis.Items.Add(item.ToString());
            }
            listSiparis.Items.Add(" ");
            listSiparis.Items.Add("**********");
            listSiparis.Items.Add(" ");
            listSiparis.Items.Add($"Toplam Siparis Tutarı: {Model.odemeTurari} TL.");
            listSiparis.Items.Add($"Ödeme Yöntemi: {Model.odemeYontemi}");
            listSiparis.Items.Add(" ");
            listSiparis.Items.Add("**********");
            listSiparis.Items.Add(" ");
            listSiparis.Items.Add($"Adres: {Model.adres}");
            listSiparis.Items.Add($"Telefon: {Model.telefon}");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmSiparisGuncelle guncelle = new frmSiparisGuncelle(Model);
            guncelle.ShowDialog();
            guncelle.Dispose();
        }
    }
}
