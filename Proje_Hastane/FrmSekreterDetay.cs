using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string Tcnumara;
        SqlBaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = Tcnumara;
            //Ad Soyad 
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1", bgl.baglantı());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 =komut.ExecuteReader();
            while   (dr1.Read())
            {
               LblAdSoyad.Text = dr1[0].ToString();
            
            }
            bgl.baglanti().Close();
            
            
            //Branşları Datagride Aktarma
            DataTable dt1  = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
