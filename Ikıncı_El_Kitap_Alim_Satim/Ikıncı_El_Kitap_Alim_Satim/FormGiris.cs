using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikıncı_El_Kitap_Alim_Satim
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnAlici_Click(object sender, EventArgs e)
        {
            FormAlici frAlici = new FormAlici();
            frAlici.Show();
            this.Hide();
        }

        private void btnSatici_Click(object sender, EventArgs e)
        {
            FormSatici frSatici = new FormSatici();
            frSatici.Show();
            this.Hide();
        }
    }
}
