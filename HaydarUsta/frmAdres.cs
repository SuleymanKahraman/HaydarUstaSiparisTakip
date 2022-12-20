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
    public partial class frmAdres : Form
    {
        private readonly int id;
        public frmAdres(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmAdres_Load(object sender, EventArgs e)
        {
            
           
        }

        private void  AdresEkle()
        {
            //SqlCommand AdresEkle = new SqlCommand("INSERT INTO tbl_Adres(Adres,Telefon) VALUES (@Adres, @Telefon)", baglanti);
            //baglanti.Open();
            //if(txtAdres.Text=="" || txtTelefon.Text == "")
            //{
            //    MessageBox.Show("Kutucuklar Boş Olmamalıdır.");
            //}
            //else
            //{
            //    AdresEkle.Parameters.AddWithValue("Adres", txtAdres.Text);
            //    AdresEkle.Parameters.AddWithValue("Telefon", Convert.ToDecimal(txtTelefon.Text));
            //    AdresEkle.ExecuteNonQuery();
            //}
            //MessageBox.Show("Adresiniz Eklendi.");
            //baglanti.Close();
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
