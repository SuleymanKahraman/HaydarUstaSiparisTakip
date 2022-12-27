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
    public partial class frmAdresGuncelle: Form
    {
        public AdresModel Adres;
        private DataHelper helper;

        public frmAdresGuncelle(AdresModel adres)
        {
            InitializeComponent();
            Adres = adres;
            helper = new DataHelper();
        }


        private void frmAdresGuncelle_Load(object sender, EventArgs e)
        {
            txtbaslik.Text = Adres.baslik;
            txtAdres.Text = Adres.adres;
            txtTelefon.Text = Adres.telefon;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtAdres.Text == string.Empty || txtbaslik.Text == string.Empty || txtTelefon.Text == string.Empty) 
            { 
                MessageBox.Show("Kutucukları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var result = helper.AdresGuncelle(Adres);
                if (result)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme İşlemi Yapılamadı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
