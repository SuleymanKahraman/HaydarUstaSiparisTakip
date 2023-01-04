using HaydarUsta.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HaydarUsta
{
    public class DataHelper
    {
        #region Connection 

        /**
         * SQL bağlantısı burada kurulur. Bunun nedeni Veri Tabanı ile Programın veri alışverişini tek bir sınıftan gerçekleştirerek karmaşadan kurtulabiliriz. 
         */
        private readonly SqlConnection connection;
        public DataHelper()
        {
            connection = new SqlConnection("Data Source=LAPTOP-VMEL2LCP\\SQLEXPRESS01;Initial Catalog=HaydarUsta;Integrated Security=True");
        }

        #endregion

        #region Ana Sayfa

        /**
         * Kayıtlı müşteri giriş yapmak istediğinde emailAdres ve parolasını girecektir. 
         * Veri tabanında şifre ve emailAdres eşlemeşmesi gerçekleşirse LoginModel.cs propertileri veri tabanındaki bilgilerle doldurulacaktır. 
         */
        public bool LoginSorgu(LoginModel model)
        {
            connection.Open();
            SqlCommand sorgu = new SqlCommand($"SELECT * FROM Musteriler WHERE EmailAdres = '{model.emailAdres}' AND Parola ='{model.parola}'", connection);
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                model.Id = (int)oku.GetValue(0);
                model.ad = oku["Ad"].ToString();
                model.soyad = oku["Soyad"].ToString();
                connection.Close();
                return true;
            }
            connection.Close();
            return false;

        }

        #endregion

        #region Kullanıcı Kayıt 

        /**
         * Aynı ad ve soyadlı kullanıcı var ise müşterinin kaydolmaması gerekir. Bu nedenle metot false dönecektir.
         */
        public bool AddSorgu(LoginModel model)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Musteriler WHERE Ad = '{model.ad}' AND Soyad = '{model.soyad}'", connection);
            SqlDataReader read = cmd.ExecuteReader();
            var result = read.Read();
            connection.Close();
            if (result)
            {
                return true;
            }
            return false;

        }

        /**
         * Müşteri veri tabanında daha önceden kayıt olmamışsa kayıt olur. Metot true döner.  
         */
        public bool AddMusteri(LoginModel model)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler (Ad, Soyad, EmailAdres, Parola) VALUES (@Ad, @Soyad, @EmailAdres, @Parola)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("Ad", model.ad);
            cmd.Parameters.AddWithValue("Soyad", model.soyad);
            cmd.Parameters.AddWithValue("EmailAdres", model.emailAdres);
            cmd.Parameters.AddWithValue("Parola", model.parola);
            var result = cmd.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        #endregion

        #region Musteri Sayfası

        /**
         * Musteri sayfasından elde edilen ve SiparisModel.cs propertilerine atanan bilgiler doğrultusunda kayıt işlemleri yapılır.  
         */
        public bool SiparisEkle(SiparisModel menuModel)
        {
            SqlCommand cmd = new SqlCommand($"INSERT INTO Siparisler(Musteri_Id, Siparis, SiparisTarihi, OdemeTutari, OdemeYontemi, Adres, Telefon) VALUES (@Musteri_Id, @Siparis, @SiparisTarihi, @OdemeTutari, @OdemeYontemi, @Adres, @Telefon)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("Musteri_Id", menuModel.Musteri_Id);
            cmd.Parameters.AddWithValue("Siparis", menuModel.siparis);
            cmd.Parameters.AddWithValue("SiparisTarihi", menuModel.siparisTarih);
            cmd.Parameters.AddWithValue("OdemeTutari", menuModel.odemeTurari);
            cmd.Parameters.AddWithValue("OdemeYontemi", menuModel.odemeYontemi);
            cmd.Parameters.AddWithValue("Adres", menuModel.adres);
            cmd.Parameters.AddWithValue("Telefon", menuModel.telefon);
            var result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        /**
         * Müşteri uygulamadan hesabını silmek istediğinde Hesabı Sil butonuna basarak üyeliğini sonlandırabilir.  
         */
        public bool MusteriSilme(int ıd)
        {
            SqlCommand sil = new SqlCommand($"DELETE FROM Musteriler WHERE Id = '{ıd}'", connection);
            connection.Open();
            sil.Parameters.AddWithValue("Id", ıd);
            var result = sil.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        /**
         * Sipariş kaydı tamamlanmış müşteri siparişini SiparişBilgileri sayfasında iptal edebilir. İptal işlemiyle birlikte Sipariş kaydı Veri Tabanından silinir ve yetkiliye gösterilmez. 
         *
         */
        public bool SiparisSilme(int Id)
        {
            SqlCommand sil = new SqlCommand($"DELETE FROM Siparisler WHERE Id = '{Id}'", connection);
            connection.Open();
            sil.Parameters.AddWithValue("Id", Id);
            var result = sil.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Müşteri Güncelleme Sayfası
        /**
         * Müşteri bilgilerini güncellemek istediğinde kullanılan metottur. 
         */
        public bool MusteriGuncelle(LoginModel model)
        {
            SqlCommand guncelle = new SqlCommand($"UPDATE Musteriler SET Ad=@Ad, Soyad=@Soyad, EmailAdres=@EmailAdres, Parola=@Parola WHERE Id= '{model.Id}'", connection);
            connection.Open();
            guncelle.Parameters.AddWithValue("Id", model.Id);
            guncelle.Parameters.AddWithValue("Ad", model.ad);
            guncelle.Parameters.AddWithValue("Soyad", model.soyad);
            guncelle.Parameters.AddWithValue("EmailAdres", model.emailAdres);
            guncelle.Parameters.AddWithValue("Parola", model.parola);
            var result = guncelle.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Sipariş Güncelleme Sayfası

        /**
         * Sipariş Bilgilerinin güncellenmesi istenildiğinde kullanılan metottur. Sİpariş güncelleme sayfasında yeni sipariş kaydı girilir ve eskisiyle güncellenir. 
         */
        public bool SiparisGuncelle(SiparisModel model)
        {
            SqlCommand guncelle = new SqlCommand($"UPDATE Siparisler SET Siparis=@Siparis, SiparisTarihi=@SiparisTarihi, OdemeTutari=@OdemeTutari, OdemeYontemi=@OdemeYontemi, Adres=@Adres, Telefon=@Telefon WHERE Id = '{model.Siparis_Id}' ", connection);
            connection.Open();
            guncelle.Parameters.AddWithValue("Id", model.Siparis_Id);
            guncelle.Parameters.AddWithValue("Siparis", model.siparis);
            guncelle.Parameters.AddWithValue("SiparisTarihi", model.siparisTarih);
            guncelle.Parameters.AddWithValue("OdemeTutari", model.odemeTurari);
            guncelle.Parameters.AddWithValue("OdemeYontemi", model.odemeYontemi);
            guncelle.Parameters.AddWithValue("Adres", model.adres);
            guncelle.Parameters.AddWithValue("Telefon", model.telefon);
            var result = guncelle.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        /**
         * SiparisId'si siparis bilgilerinin güncellenmesi ve iptal edilmesi sırasında SQL'den alınmak zorundadır. Bu metot sadece Sipariş kaydı tamamlanan siparişin silme ve güncelleme işlemleri için talep edilen SiparisId'yi getirmek için tasarlandı. 
         * SiparişId veri tabanından bir şekilde okunamadığı durumda metot 0 dönmeli ve ilgili sayfada 0 dönüş değeri durumundaki işlemler tasarlanmalıdır. 
         */
        public int SiparisId(SiparisModel model)
        {
            SqlCommand oneValue = new SqlCommand($"SELECT Id FROM Siparisler WHERE Siparis='{model.siparis}'", connection);
            connection.Open();
            SqlDataReader dr = oneValue.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                int Id = (int)dr.GetValue(0);
                connection.Close();
                return Id;

            }
            connection.Close();
            return 0;
        }
        #endregion

        #region Adres Sayfası
        /**
         * AdresModel.cs'deki propertilere yüklenmiş veriler SQL veri tabanına eklenir.  
         */
        public bool AdresKaydet(AdresModel adres)
        {
            SqlCommand cmd = new SqlCommand($"INSERT INTO Adresler(Musteri_Id, Baslık, Adres, Telefon) VALUES (@Musteri_Id, @Baslık, @Adres, @Telefon)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("Musteri_Id", adres.musteri_Id);
            cmd.Parameters.AddWithValue("Baslık", adres.baslik);
            cmd.Parameters.AddWithValue("Adres", adres.adres);
            cmd.Parameters.AddWithValue("Telefon", adres.telefon);
            var result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        /**
         * DataGridView'de silmek istenilen adresin Id'si alınarak bu metotta kullanılır. 
         */
        public bool AdresSilme(int Id)
        {
            SqlCommand sil = new SqlCommand($"DELETE FROM Adresler WHERE Id = '{Id}'", connection);
            connection.Open();
            sil.Parameters.AddWithValue("Id", Id);
            var result = sil.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        /**
         * DataGridView'e tablo olarak yansıtmak istediğimiz tabloyu SQL'den çekmek için kullanılan metot. 
         */
        public DataTable TabloGetir(string sql)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        #endregion

        #region Adres Güncelleme

        /**
         * Adreslerin güncellenmesi durumunda kullanılan metot. 
         */
        public bool AdresGuncelle(AdresModel adres)
        {
            SqlCommand guncelle = new SqlCommand($"UPDATE Adresler SET Baslık=@Baslık, Adres=@Adres, Telefon=@Telefon WHERE Id = '{adres.Id}'", connection);
            connection.Open();
            guncelle.Parameters.AddWithValue("Id", adres.Id);
            guncelle.Parameters.AddWithValue("Baslık", adres.baslik);
            guncelle.Parameters.AddWithValue("Adres", adres.adres);
            guncelle.Parameters.AddWithValue("Telefon", adres.telefon);
            var result = guncelle.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        #endregion




    }
}
