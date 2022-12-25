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

        private readonly DataHelper helper;
        private LoginModel model;

        public frmAnaSayfa()
        {
            InitializeComponent();
            helper = new DataHelper();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit kayit = new frmKullaniciKayit();
            kayit.ShowDialog();
            kayit.Dispose();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            if (txtLogEmailAdres.Text == "" || txtLogParola.Text == "")
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                model = new LoginModel()
                {
                    EmailAdres = txtLogEmailAdres.Text,
                    Parola = txtLogParola.Text
                };

                var result = helper.LoginSorgu(model);
                if (result)
                {
                    frmMusteri menu = new frmMusteri(model);
                    menu.ShowDialog();
                    menu.Dispose();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız. Lütfen Tekrar Deneyiniz Veya Kayıt Olunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLogEmailAdres.Clear();
                    txtLogParola.Clear();
                }
            }
        }
    }
}
