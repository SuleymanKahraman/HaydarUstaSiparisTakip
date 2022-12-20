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
    public partial class frmKullanici : Form
    {
        private readonly string ad;
        private readonly int id;



        public frmKullanici(string ad, int id)
        {
            InitializeComponent();
            this.ad = ad;
            this.id = id;
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + ad;
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            frmAdres frmAd = new frmAdres(id);
            frmAd.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckAdana_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        decimal ucret = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbAdana.Checked == false || cbTantuni.Checked == false || cbTavukSis.Checked == false || cbKofte.Checked == false || cbUsta.Checked == false || cbLahmacun.Checked == false || cbEtli.Checked == false)
            {
                MessageBox.Show("Ana Yemeklerden en az bir adet seçmek zorunludur.");
                Clear();

            }
            else
            {

                UcretHesapla();
                DialogResult YesNo = MessageBox.Show("Siparişinizi Onaylıyor musunuz?", "", MessageBoxButtons.YesNo);
                if (YesNo == DialogResult.Yes)
                {
                    lblWelcome.Text = Convert.ToString(ucret);
                }
                else
                {
                    ucret = 0;
                    lblWelcome.Text = Convert.ToString(ucret);
                    Clear();

                }


            }



        }

        private void UcretHesapla()
        {
            if (cbAdana.Checked)
            {
                ucret += (nmAdanaKebap.Value * 78);
            }
            if (cbTantuni.Checked)
            {
                ucret += (nmTantuni.Value * 65);
            }
            if (cbTavukSis.Checked)
            {
                ucret += (nmTavukSis.Value * 65);
            }
            if (cbKofte.Checked)
            {
                ucret += (nmKofte.Value * 72);
            }
            if (cbUsta.Checked)
            {
                ucret += (nmUsta.Value * 80);
            }
            if (cbLahmacun.Checked)
            {
                ucret += (nmLahmacun.Value * 25);
            }
            if (cbEtli.Checked)
            {
                ucret += (nmEtli.Value * 58);
            }
            if (cbHumus.Checked)
            {
                ucret += (nmHumus.Value * 20);
            }
            if (cbTarator.Checked)
            {
                ucret += (nmTarator.Value * 20);
            }
            if (cbAtom.Checked)
            {
                ucret += (nmAtom.Value * 25);
            }
            if (cbOcce.Checked)
            {
                ucret += (nmOcce.Value * 25);
            }
            if (cbZeytin.Checked)
            {
                ucret += (nmZeytin.Value * 15);
            }
            if (cbCoban.Checked)
            {
                ucret += (nmCoban.Value * 15);
            }
            if (cbTursu.Checked)
            {
                ucret += (nmTursu.Value * 10);
            }
            if (cbKola.Checked)
            {
                ucret += (nmKola.Value * 8);
            }
            if (cbFanta.Checked)
            {
                ucret += (nmFanta.Value * 8);
            }
            if (cbKayran.Checked)
            {
                ucret += (nmKayran.Value * 6);
            }
            if (cbAayran.Checked)
            {
                ucret += (nmAayran.Value * 10);
            }
            if (cbSalgam.Checked)
            {
                ucret += (nmSalgam.Value * 8);
            }
            if (cbLipton.Checked)
            {
                ucret += (nmLipton.Value * 8);
            }
            if (cbSu.Checked)
            {
                ucret += (nmSu.Value * 5);
            }
        }
        private void Clear()
        {
            foreach (Control c in gbAnaYemek.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 1;
                }
            }
            foreach (Control c in gbMzSlt.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if(c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 1;
                }
            }
            foreach (Control c in gbIcecek.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 1;
                }
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        //public int KullaniciID { get; set; }
        //private void Form2_Load(object sender, EventArgs e)
        //{
        //    SqlCommand sql = new SqlCommand("SELECT KullaniciID FROM tbl_Musteriler WHERE EmailAdres = '" +frm.txtEmailGiris.Text+"'");

        //    lblWelcome.Text = sql.CommandText; 

        //}

        //private void txtAdres_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void lblAdres_Click(object sender, EventArgs e)
        //{

        //}

        //private void txtTelefon_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
