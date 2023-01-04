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
    
    //TODO: Button - TapStop: Program çalışırken butonun seçili olup olmayacağını belirliyor. 

    public partial class frmAnaSayfa : Form
    {
        #region Construct/Load
        /**
         * SQL veri tabanıyla iletişimde kullanacağımız metotları DataHeper adında bir class yardımıyla çağıracağız.
         *  DataHelper clasından ve müsteriden aldığımız Login verilerini tutmak için LoginModel clasından birer örnek almak için en başa birer field tanımladık. 
         */

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
        #endregion

        #region Giriş/KayıtOl

        /**
         * Musteri kayıt olması gerekirse ilgili Form.cs'e yönlendirili.
         */

        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit kayit = new frmKullaniciKayit();
            kayit.ShowDialog();
            kayit.Dispose();
        }

        /**
         * Login işlemleri için önce textbox boşluk kontrolü yapılır. 
         * Login model clasından örnek alınır ve musteri verileri kaydedilir. 
         * Musteri bilgileri loginSorgu metodu yardımıyla veri tabanından sorgulanır. 
         * Musteri sisteme kayıtlı ise Musteri.cs'e yönlendirilir. 
         * Sisteme kayıtlı değilse giriş yapamaz ve kayıt olunması talep edilir. 
        */

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            if (txtLogEmailAdres.Text == string.Empty || txtLogParola.Text == string.Empty)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                model = new LoginModel()
                {
                    emailAdres = txtLogEmailAdres.Text,
                    parola = txtLogParola.Text
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
        #endregion

    }
}
