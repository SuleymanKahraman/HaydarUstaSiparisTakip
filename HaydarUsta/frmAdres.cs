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
        private DataHelper helper;
        public MenuModel Model;

        public frmAdres(MenuModel model)
        {
            InitializeComponent();
            Model = model;
        }

        private void frmAdres_Load(object sender, EventArgs e)
        {
            helper = new DataHelper();
            dgvAdresler.DataSource = helper.TabloGetir($"SELECT Baslık, Adres, Telefon FROM Adresler WHERE Musteri_Id ='{Model.Musteri_Id}'");
        }

        

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            Model.adres = dgvAdresler.CurrentRow.Cells[1].Value.ToString();
            Model.telefon = dgvAdresler.CurrentRow.Cells[2].Value.ToString();

            this.Close();
        }
    }
}
