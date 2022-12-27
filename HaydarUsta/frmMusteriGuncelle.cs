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
            txtEmail.Text = Model.EmailAdres;
            txtParola.Text = Model.Parola;
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Model.ad= txtAd.Text;   
            Model.soyad= txtSoyad.Text;
            Model.EmailAdres= txtEmail.Text;    
            Model.Parola= txtParola.Text;
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
