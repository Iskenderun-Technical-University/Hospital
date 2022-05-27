using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void BtnHastaGirisi_Click(object sender, EventArgs e)
=======
        private void button1_Click(object sender, EventArgs e)
>>>>>>> 3ac9f35f1c6c73e670cc05e3044cdd91ab34ea8a
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }
<<<<<<< HEAD

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }
=======
>>>>>>> 3ac9f35f1c6c73e670cc05e3044cdd91ab34ea8a
    }
}
