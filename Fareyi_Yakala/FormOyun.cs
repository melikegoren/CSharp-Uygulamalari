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
    public partial class FormOyun : Form
    {
        public FormOyun()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                FrmGameOver frmGameOver = new FrmGameOver(lblSayac2.Text);
                frmGameOver.Show();
                this.Hide();
               
            }
            if(progressBar1.Value %2 == 0)
            {
                btnTik.Visible = false;
                int n1 = rnd.Next(0, 750);
                int n2 = rnd.Next(0, 400);
                btnTik.Location = new Point(n1, n2);
            }
            else
            {
                btnTik.Visible = true;
            }
        }

        

        private void btnTik_Click(object sender, EventArgs e)
        {

            sayac++;
            lblSayac2.Text = sayac.ToString();
            
        }
    }
}
