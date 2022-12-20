using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaydarUsta
{

    public partial class frmAnaSayfa : Form
    {

        private readonly DataHelper fn;
        public frmAnaSayfa()
        {
            InitializeComponent();
            fn = new DataHelper();
        }

        private void lblParolaGiris_Click(object sender, EventArgs e)
        {

        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "" || txtParola.Text == "" || txtParolaTekrar.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz.");
            }
            else
            {
                if (txtParola.Text != txtParolaTekrar.Text)
                {
                    MessageBox.Show("Parolalar Eşleşmedi.");
                }
                else
                {
                    bool result = fn.KullaniciEkle(txtAd.Text, txtSoyad.Text, txtEmail.Text, txtParola.Text);
                    if (result)
                    {
                        MessageBox.Show("İşleminiz Başarıyla Gerçekleşti.");
                        //txtAd.Clear(); metot yaz buraya cağır.
                    }
                    else
                    {
                        MessageBox.Show("Kardeş sql'in bok yemesi");
                    }
                }
                
            }
            

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            LoginResult result = fn.Login(txtEmailGiris.Text, txtParolaGiris.Text);
            if (result is null)
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı!");
                txtEmailGiris.Clear();
                txtParolaGiris.Clear();
            }
            else
            {
                frmKullanici frmKullanici = new frmKullanici(result.Ad, result.KullaniciID);
                frmKullanici.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
