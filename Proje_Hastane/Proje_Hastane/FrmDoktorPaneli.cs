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
<<<<<<< HEAD:Proje_Hastane/Proje_Hastane/FrmDoktorPaneli.cs
=======

>>>>>>> 4574c9f68f309f58cd6213fd1539a13bd358aadf:Proje_Hastane/FrmSekreterGiris.cs
namespace Proje_Hastane
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
<<<<<<< HEAD:Proje_Hastane/Proje_Hastane/FrmDoktorPaneli.cs
        private void label1_Click(object sender, EventArgs e)
=======
        private void FrmSekreterGiris_Load(object sender, EventArgs e)
>>>>>>> 4574c9f68f309f58cd6213fd1539a13bd358aadf:Proje_Hastane/FrmSekreterGiris.cs
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.Show();
                this.Hide();
 
            }
            else {
                MessageBox.Show("Hatalı TC & Şifre");
            
            }
            bgl.baglanti().Close();
        }

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {

        }
    }
}
