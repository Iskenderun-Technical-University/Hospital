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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;

        sglbaglantisi bgl = new sglbaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            SglCommand komut = new SglCommand("Select HastaAd,HastaSoyAd From Tbl_Hastalar where HastaTC =@p1", bgl.baglanti());
            komut.Parameteres.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.Executereader();
            while(dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " +dr[1];
            }
            bgl.baglanti().Close();
        }
    }
}
