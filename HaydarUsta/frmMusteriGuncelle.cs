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
    public partial class frmMusteriGuncelle : Form
    {
        #region Constructor/Load

        /**
         * Müşteriler Musteri.cs'de Personel Güncelleme butonuna basarak bu sayfaya yönlenecektir. 
         */

        private DataHelper helper;
        public LoginModel Model;

        public frmMusteriGuncelle(LoginModel model)
        {
            InitializeComponent();
            helper = new DataHelper();
            Model = model;
        }

        private void MusteriBilgileri_Load(object sender, EventArgs e)
        {
            txtAd.Text = Model.ad;
            txtSoyad.Text = Model.soyad;
            txtEmail.Text = Model.emailAdres;
            txtParola.Text = Model.parola;
            
        }
        #endregion

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == string.Empty || txtSoyad.Text == string.Empty || txtEmail.Text == string.Empty || txtParola.Text == string.Empty)
            {
                MessageBox.Show("Boş Alan Bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtParola.Text!= txtParolaTekrar.Text)
                {
                    MessageBox.Show("Parolalar Eşleşmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Model.ad = txtAd.Text;
                    Model.soyad = txtSoyad.Text;
                    Model.emailAdres = txtEmail.Text;
                    Model.parola = txtParola.Text;
                    var result = helper.MusteriGuncelle(Model);
                    if (result)
                    {
                        MessageBox.Show("Güncelleme İşlemi Başarılı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme İşlemi Yapılamadı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
