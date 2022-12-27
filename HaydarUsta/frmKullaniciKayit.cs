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
        private readonly DataHelper helper;
        private MusteriEkleModel model;
        public frmKullaniciKayit()
        {
            InitializeComponent();
            helper = new DataHelper();  
            
        }

        private void frmKullaniciKayit_Load(object sender, EventArgs e)
        {

        }

        public void ClearAll()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
            txtParola.Clear();  
            txtParolaTekrar.Clear();    
        }


        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "" || txtParola.Text == "" || txtParolaTekrar.Text == "")
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
                    model = new MusteriEkleModel()
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
    }
}
