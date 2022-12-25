using HaydarUsta.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaydarUsta
{
    public class DataHelper
    {
        private readonly SqlConnection connection;
        public DataHelper()
        {
            connection = new SqlConnection("Data Source=LAPTOP-VMEL2LCP\\SQLEXPRESS01;Initial Catalog=HaydarUsta;Integrated Security=True");
        }
        
        public bool AddMusteri (AddModel model)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler (Ad, Soyad, EmailAdres, Parola) VALUES (@Ad, @Soyad, @EmailAdres, @Parola)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("Ad", model.ad);
            cmd.Parameters.AddWithValue("Soyad",model.soyad);
            cmd.Parameters.AddWithValue("EmailAdres", model.emailAdres);
            cmd.Parameters.AddWithValue("Parola", model.parola);
            var result = cmd.ExecuteNonQuery(); 
            connection.Close();
            return result > 0; 
        }

        public bool LoginSorgu(LoginModel model)
        {
            connection.Open();
            SqlCommand sorgu = new SqlCommand($"SELECT * FROM Musteriler WHERE EmailAdres = '{model.EmailAdres}' AND Parola ='{model.Parola}'", connection);
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

        public DataTable TabloGetir(string sql)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);   
            connection.Close();
            return dt;
        }

        public bool AddSorgu(AddModel model)
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

        public bool SiparisEkle(MenuModel menuModel)
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
    }
}
