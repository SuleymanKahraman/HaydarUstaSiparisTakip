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
    public partial class frmKullaniciKayit : Form
    {
        #region Construct/Load

        /**
         * LoginModel.cs'de bulununan ad, soyad, emailAdres ve parola fieldlarını kullanarak ekleme işlemi yapabiliriz. 
         */
        private readonly DataHelper helper;
        private LoginModel model;
        public frmKullaniciKayit()
        {
            InitializeComponent();
            helper = new DataHelper();

        }

        private void frmKullaniciKayit_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region KayıtOl

        /**
         * Boşluk kontrolleri yapılır. 
         * Parolanın doğru girildiğinden emin olmak için, müşteriden parolanın tekrar girilmesi istenerek kontrolü yapılır.
         * LoginModel.cs'den bir örnek alınır ve müşteri bilgileri buraya atanır. 
         * DataHelper.cs'deki AddSorgu metodu ile daha önce benzer ad ve soyad ile müşteri kayıt olmuş ise müşteriden giriş yapması istenir. 
         * Müşterinin adı ve soyadı veri tabanın da kayıtlı değil ise AddMusteri metodu ile veri tabanına kaydedilir. 
         */
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == string.Empty || txtSoyad.Text == string.Empty || txtEmail.Text == string.Empty || txtParola.Text == string.Empty || txtParolaTekrar.Text == string.Empty)
            {
                MessageBox.Show("Boş Alan Bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtParola.Text != txtParolaTekrar.Text)
                {
                    MessageBox.Show("Parolalar Eşleşmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    model = new LoginModel()
                    {
                        ad = txtAd.Text,
                        soyad = txtSoyad.Text,
                        emailAdres = txtEmail.Text,
                        parola = txtParola.Text,
                    };
                    var sorgu = helper.AddSorgu(model);
                    if (sorgu)
                    {
                        MessageBox.Show("Bu kullanıcı daha önce kayıt olmuş. Lütfen giriş yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearAll();
                    }
                    else
                    {
                        var add = helper.AddMusteri(model);
                        if (add)
                        {
                            MessageBox.Show("İşleminiz Başarıyla Gerçekleşti.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt İşlemi Başarısız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAll();
                        }
                    }

                }

            }

        }

        #endregion

        #region Metotlar

        /**
         *Tüm textboxları resetlemek için yazılmış bir metot 
         */
        public void ClearAll()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
            txtParola.Clear();
            txtParolaTekrar.Clear();
        }
        #endregion



    }
}
