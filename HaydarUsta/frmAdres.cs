using HaydarUsta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaydarUsta
{
    public partial class frmAdres : Form
    {
        #region Constructor/Load

        /**
         * frmAdres.cs SiparisModel tipinde bir parametre tanımlanmalıdır. Nitekim adres seçme Musteri.cs'de gerçekleştirilen işlemlerin bütünleyici parçası konumundadır. O nedenle Musteri.cs'de örneği alınmış SiparisModel tipindeki parametre adres sayfasına aktarılarak, SiparisModel'deki adres ve telefon propertilerine atamalar yapılır. 
         * bu nedenle Musteri.cs sayfasında frmAdres örneği alındığında parametre olarak girilen siparis isimli değişken, buradaki siparis isimli değişkene atanır. 
         */

        private DataHelper helper;
        private SiparisModel siparis;
        private AdresModel adres;

        public frmAdres(SiparisModel model)
        {
            InitializeComponent();
            siparis = model;
            helper = new DataHelper();
            adres = new AdresModel();
        }

        private void frmAdres_Load(object sender, EventArgs e)
        {
            dgvAdresler.DataSource = helper.TabloGetir($"SELECT Id, Baslık, Adres, Telefon FROM Adresler WHERE Musteri_Id ='{siparis.Musteri_Id}'");
        }

        #endregion

        #region Butonlar

        /**
         * Musteri.cs'de tanımlanmış SiparisModel tipindeki siparis field'ına adres ve telefon ataması yapılır. Bunun için DataGridView'de müşterinin seçtiği adresin ilgili hücrelerinden veriler çekilerek ilgili propertilere atamalar yapılır. 
         */
        
        private void btnSec_Click(object sender, EventArgs e)
        {
            if(siparis.siparis == null)
            {
                MessageBox.Show("Siparişiniz mevcut değil.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                siparis.adres = dgvAdresler.CurrentRow.Cells[2].Value.ToString();
                siparis.telefon = dgvAdresler.CurrentRow.Cells[3].Value.ToString();
            }
            this.Close();
        }

        /**
         * Adres bilgilerinin güncellenmesi için AdresModel tipinde tanımlanan değişken tanımlanır. 
         * Güncellenmesini istediğimiz satıra sağ tıklayarak tanımladığımız ContextMenuStrip butonu ile güncelleme sayfasına yönlendirilir. 
         * frmAdresGuncelleme sayfasına yönlendirilmeden önce AdresModel.cs'deki propertiler DataGridView'den çekilen bilgiler aracılığıyla doldurulur. 
         * AdresModel tipindeki değişken frmAdresGuncelle sayfasına iletilir. 
         */

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adres.Id = (int)dgvAdresler.CurrentRow.Cells[0].Value;
            adres.musteri_Id = siparis.Musteri_Id;
            adres.baslik = dgvAdresler.CurrentRow.Cells[1].Value.ToString();
            adres.adres = dgvAdresler.CurrentRow.Cells[2].Value.ToString();
            adres.telefon = dgvAdresler.CurrentRow.Cells[3].Value.ToString();
            frmAdresGuncelle guncelle = new frmAdresGuncelle(adres);
            guncelle.ShowDialog();
            guncelle.Dispose();
            frmAdres_Load(null, null);
        }

        /**
         * Silmek istediğimiz adresin Id'sini AdresSilme metoduna yönlendirerek silme işlemi tamamlanır. 
         */
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adres.Id = (int)dgvAdresler.CurrentRow.Cells[0].Value;
            var result = helper.AdresSilme(adres.Id);
            if (result)
            {
                MessageBox.Show("Silme işlemi başarılı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            frmAdres_Load(null, null);

        }

        /**
         * Yeni bir adres kaydedilmek istendiğinde ilgili kutucuklar doldurulur. 
         * Ardından textbox'taki bilgiler AdresModel.cs propertilerine atanır. 
         * AdresModel tipindeki adres değişkeni AdresKaydet metoduna eklenerek kaydetme işlemleri tamamlanır. 
         */
        private void btnKaydetAdres_Click(object sender, EventArgs e)
        {
            if (txtAdres.Text == string.Empty || txtbaslik.Text == string.Empty || txtTelefon.Text == string.Empty)
            {
                MessageBox.Show("Kutucukları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                adres = new AdresModel()
                {
                    musteri_Id = siparis.Musteri_Id,
                    baslik = txtbaslik.Text,
                    adres = txtAdres.Text,
                    telefon = txtTelefon.Text,
                };
                var result = helper.AdresKaydet(adres);
                if (result)
                {
                    MessageBox.Show("Kaydetme İşlemi Başarılı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAdres.Clear();
                    txtbaslik.Clear();
                    txtTelefon.Clear();
                }
                else
                {
                    MessageBox.Show("Kaydetme İşlemi Yapılamadı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmAdres_Load(null, null);
            }
        }
        #endregion

    }
}
