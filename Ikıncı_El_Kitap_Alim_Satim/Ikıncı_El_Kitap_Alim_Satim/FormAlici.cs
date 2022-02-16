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

namespace Ikıncı_El_Kitap_Alim_Satim
{
    public partial class FormAlici : Form
    {
        
        public FormAlici()
        {
            InitializeComponent();
          
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3DUO7VC;Initial Catalog=kitapAlSat;Integrated Security=True");
        void show()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from satici_kitap_tbl ", baglanti);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from alici_tbl", baglanti);

            da2.Fill(dt2);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;
            
            
        }

        private void FormAlici_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapAlSatDataSet2.alici_tbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.alici_tblTableAdapter.Fill(this.kitapAlSatDataSet2.alici_tbl);
            // TODO: Bu kod satırı 'kitapAlSatDataSet1.satici_kitap_tbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satici_kitap_tblTableAdapter.Fill(this.kitapAlSatDataSet1.satici_kitap_tbl);
            show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAlinacakKitap.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtKitapFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
     
            SqlCommand komut1 = new SqlCommand("Insert into alici_tbl (AliciAdSoyad,AliciAlinanKitap,AliciKitapFiyat) values (@k1,@k2,@k3)", baglanti);
            komut1.Parameters.AddWithValue("@k1", txtAliciAdSoyad.Text);
            komut1.Parameters.AddWithValue("@k2", txtAlinacakKitap.Text);
            komut1.Parameters.AddWithValue("@k3", txtKitapFiyat.Text);
    
            SqlCommand komut2 = new SqlCommand("Delete from satici_kitap_tbl where KitapIsim = @isim ", baglanti);
            komut2.Parameters.AddWithValue("@isim", txtAlinacakKitap.Text);

            komut1.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            
            baglanti.Close();
            show();
            MessageBox.Show("Kitap Satın Alındı.", "İşlem Tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnGeriDön2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGiris frGiris = new FormGiris();
            frGiris.Show();
        }
    }
}
