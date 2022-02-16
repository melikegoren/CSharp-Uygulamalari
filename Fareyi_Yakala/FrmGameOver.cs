using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_In_Time
{
    public partial class FrmGameOver : Form
    {
        public FrmGameOver(string skor)
        {
            InitializeComponent();
            lblSkor2.Text = skor;
        }

        private void FrmGameOver_Load(object sender, EventArgs e)
        {
           
        }

        private void btnHayır_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            this.Close();
            FormOyun fr1 = new FormOyun();
            fr1.Show();
        }
    }
}
