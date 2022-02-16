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
    public partial class FormSatici : Form
    {
        public FormSatici()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3DUO7VC;Initial Catalog=kitapAlSat;Integrated Security=True");
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from satici_kitap_tbl ", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void temizle()
        {
            txtKitapFiyat.Text = "";
            txtKitapYazar.Text = "";
            txtKitapİsim.Text = "";
            txtSaticiAdSoyad.Text = "";
            txtSaticiId.Text = "";
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtSaticiId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtSaticiAdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtKitapİsim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtKitapYazar.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtKitapFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }
        private void btnSatisaKoy_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Insert into satici_kitap_tbl (SaticiAdSoyad, KitapIsim, KitapYazar, KitapFiyat) values (@k1,@k2,@k3,@k4)", baglanti);
            komut1.Parameters.AddWithValue("@k1", txtSaticiAdSoyad.Text);
            komut1.Parameters.AddWithValue("@k2", txtKitapİsim.Text);
            komut1.Parameters.AddWithValue("@k3", txtKitapYazar.Text);
            komut1.Parameters.AddWithValue("@k4", txtKitapFiyat.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            listele();
            temizle();
            MessageBox.Show("Kitap Satışa konuldu.", "İşlem Tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }   
        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update satici_kitap_tbl set SaticiAdSoyad = @k1, KitapIsim = @k2, KitapYazar = @k3, KitapFiyat = @k4 where SaticiId = @k5", baglanti);
            komut2.Parameters.AddWithValue("@k1", txtSaticiAdSoyad.Text);
            komut2.Parameters.AddWithValue("@k2", txtKitapİsim.Text);
            komut2.Parameters.AddWithValue("@k3", txtKitapYazar.Text);
            komut2.Parameters.AddWithValue("@k4", txtKitapFiyat.Text);
            komut2.Parameters.AddWithValue("@k5", txtSaticiId.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            listele();
            temizle();
            MessageBox.Show("Bilgiler Güncellendi.", "İşlem Tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormSatici_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapAlSatDataSet.satici_kitap_tbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.satici_kitap_tblTableAdapter.Fill(this.kitapAlSatDataSet.satici_kitap_tbl);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Delete from satici_kitap_tbl where SaticiId=@k1", baglanti);
            komut3.Parameters.AddWithValue("@k1", txtSaticiId.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            listele();
            temizle();
            MessageBox.Show("Kitap Satıştan Kaldırıldı.", "İşlem Tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGiris frGiris = new FormGiris();
            frGiris.Show();
        }
    }
}
