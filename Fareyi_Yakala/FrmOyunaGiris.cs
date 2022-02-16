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
    public partial class FrmOyunaGiris : Form
    {
        public FrmOyunaGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOyun fr1 = new FormOyun();
            fr1.Show();
            this.Hide();
        }
    }
}
