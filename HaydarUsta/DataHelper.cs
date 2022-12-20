using System;
using System.Collections.Generic;
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
            connection = new SqlConnection("Data Source=LAPTOP-VMEL2LCP\\SULEYMANKAHRAMAN;Initial Catalog=HaydarUstaninYeri;Integrated Security=True");
        }
        
        public bool KullaniciEkle (string ad, string soyad, string email, string parola)
        {
            SqlCommand ekleKomut = new SqlCommand("INSERT INTO tbl_Musteriler (Ad, Soyad, EmailAdres, Parola) VALUES (@Ad, @Soyad, @EmailAdres, @Parola)", connection);
            connection.Open();
            ekleKomut.Parameters.AddWithValue("Ad", ad);
            ekleKomut.Parameters.AddWithValue("Soyad", soyad);
            ekleKomut.Parameters.AddWithValue("EmailAdres", email);
            ekleKomut.Parameters.AddWithValue("Parola", parola);
            var result = ekleKomut.ExecuteNonQuery(); // 0 veya 1 Row effected, ekleme yaptığında gerçekleşir, 
            connection.Close();

            return result > 0; // Void'e çeviriyoruz. 
            
            
        }

        public LoginResult Login(string email, string parola)
        {
            connection.Open();
            SqlCommand girisKomut = new SqlCommand("SELECT KullaniciID,Ad FROM tbl_Musteriler WHERE EmailAdres = '" +email+ "' AND Parola ='" +parola+ "'", connection);
            SqlDataReader okuyucu = girisKomut.ExecuteReader();
            if (okuyucu.Read())
            {
                LoginResult result = new LoginResult()
                {
                    Ad = okuyucu["Ad"].ToString(),
                    KullaniciID = (int)okuyucu["KullaniciID"]
                };
                return result;
            }
            return null;
            
        }

    }
}
