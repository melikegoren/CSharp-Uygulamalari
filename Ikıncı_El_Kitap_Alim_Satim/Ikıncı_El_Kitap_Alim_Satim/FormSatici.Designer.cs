
namespace Ikıncı_El_Kitap_Alim_Satim
{
    partial class FormSatici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSaticiAdSoyad = new System.Windows.Forms.Label();
            this.txtSaticiAdSoyad = new System.Windows.Forms.TextBox();
            this.txtKitapİsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSatisaKoy = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.grpbxSatilanKitaplar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saticikitaptblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapAlSatDataSet = new Ikıncı_El_Kitap_Alim_Satim.kitapAlSatDataSet();
            this.txtSaticiId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.satici_kitap_tblTableAdapter = new Ikıncı_El_Kitap_Alim_Satim.kitapAlSatDataSetTableAdapters.satici_kitap_tblTableAdapter();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.saticiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saticiAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxSatilanKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saticikitaptblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlSatDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaticiAdSoyad
            // 
            this.lblSaticiAdSoyad.AutoSize = true;
            this.lblSaticiAdSoyad.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblSaticiAdSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaticiAdSoyad.Location = new System.Drawing.Point(12, 57);
            this.lblSaticiAdSoyad.Name = "lblSaticiAdSoyad";
            this.lblSaticiAdSoyad.Size = new System.Drawing.Size(159, 25);
            this.lblSaticiAdSoyad.TabIndex = 0;
            this.lblSaticiAdSoyad.Text = "Satıcı Ad Soyad:";
            // 
            // txtSaticiAdSoyad
            // 
            this.txtSaticiAdSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaticiAdSoyad.Location = new System.Drawing.Point(177, 52);
            this.txtSaticiAdSoyad.Name = "txtSaticiAdSoyad";
            this.txtSaticiAdSoyad.Size = new System.Drawing.Size(157, 34);
            this.txtSaticiAdSoyad.TabIndex = 1;
            // 
            // txtKitapİsim
            // 
            this.txtKitapİsim.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapİsim.Location = new System.Drawing.Point(177, 89);
            this.txtKitapİsim.Name = "txtKitapİsim";
            this.txtKitapİsim.Size = new System.Drawing.Size(157, 34);
            this.txtKitapİsim.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitabın İsmi:";
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYazar.Location = new System.Drawing.Point(177, 125);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(157, 34);
            this.txtKitapYazar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kitabın Yazarı:";
            // 
            // txtKitapFiyat
            // 
            this.txtKitapFiyat.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapFiyat.Location = new System.Drawing.Point(177, 162);
            this.txtKitapFiyat.Name = "txtKitapFiyat";
            this.txtKitapFiyat.Size = new System.Drawing.Size(157, 34);
            this.txtKitapFiyat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kitabın Fiyatı:";
            // 
            // btnSatisaKoy
            // 
            this.btnSatisaKoy.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSatisaKoy.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisaKoy.Location = new System.Drawing.Point(363, 20);
            this.btnSatisaKoy.Name = "btnSatisaKoy";
            this.btnSatisaKoy.Size = new System.Drawing.Size(150, 48);
            this.btnSatisaKoy.TabIndex = 8;
            this.btnSatisaKoy.Text = "Satışa Koy";
            this.btnSatisaKoy.UseVisualStyleBackColor = false;
            this.btnSatisaKoy.Click += new System.EventHandler(this.btnSatisaKoy_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(363, 75);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 48);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSil.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(363, 129);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(150, 48);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Satıştan Kaldır";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // grpbxSatilanKitaplar
            // 
            this.grpbxSatilanKitaplar.Controls.Add(this.dataGridView1);
            this.grpbxSatilanKitaplar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbxSatilanKitaplar.Location = new System.Drawing.Point(16, 199);
            this.grpbxSatilanKitaplar.Name = "grpbxSatilanKitaplar";
            this.grpbxSatilanKitaplar.Size = new System.Drawing.Size(878, 336);
            this.grpbxSatilanKitaplar.TabIndex = 11;
            this.grpbxSatilanKitaplar.TabStop = false;
            this.grpbxSatilanKitaplar.Text = "Satışa Konulan Kitaplar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saticiIdDataGridViewTextBoxColumn,
            this.saticiAdSoyadDataGridViewTextBoxColumn,
            this.kitapIsimDataGridViewTextBoxColumn,
            this.kitapYazarDataGridViewTextBoxColumn,
            this.kitapFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.saticikitaptblBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // saticikitaptblBindingSource
            // 
            this.saticikitaptblBindingSource.DataMember = "satici_kitap_tbl";
            this.saticikitaptblBindingSource.DataSource = this.kitapAlSatDataSet;
            // 
            // kitapAlSatDataSet
            // 
            this.kitapAlSatDataSet.DataSetName = "kitapAlSatDataSet";
            this.kitapAlSatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSaticiId
            // 
            this.txtSaticiId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaticiId.Location = new System.Drawing.Point(176, 15);
            this.txtSaticiId.Name = "txtSaticiId";
            this.txtSaticiId.Size = new System.Drawing.Size(157, 34);
            this.txtSaticiId.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(81, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Satıcı Id:";
            // 
            // satici_kitap_tblTableAdapter
            // 
            this.satici_kitap_tblTableAdapter.ClearBeforeFill = true;
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnGeriDön.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDön.Location = new System.Drawing.Point(546, 75);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(120, 48);
            this.btnGeriDön.TabIndex = 15;
            this.btnGeriDön.Text = "Geri Dön";
            this.btnGeriDön.UseVisualStyleBackColor = false;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // saticiIdDataGridViewTextBoxColumn
            // 
            this.saticiIdDataGridViewTextBoxColumn.DataPropertyName = "SaticiId";
            this.saticiIdDataGridViewTextBoxColumn.HeaderText = "Satıcı ID";
            this.saticiIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saticiIdDataGridViewTextBoxColumn.Name = "saticiIdDataGridViewTextBoxColumn";
            this.saticiIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.saticiIdDataGridViewTextBoxColumn.Width = 165;
            // 
            // saticiAdSoyadDataGridViewTextBoxColumn
            // 
            this.saticiAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "SaticiAdSoyad";
            this.saticiAdSoyadDataGridViewTextBoxColumn.HeaderText = "Satıcının Adı Soyadı";
            this.saticiAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saticiAdSoyadDataGridViewTextBoxColumn.Name = "saticiAdSoyadDataGridViewTextBoxColumn";
            this.saticiAdSoyadDataGridViewTextBoxColumn.Width = 165;
            // 
            // kitapIsimDataGridViewTextBoxColumn
            // 
            this.kitapIsimDataGridViewTextBoxColumn.DataPropertyName = "KitapIsim";
            this.kitapIsimDataGridViewTextBoxColumn.HeaderText = "Kitabın İsmi";
            this.kitapIsimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapIsimDataGridViewTextBoxColumn.Name = "kitapIsimDataGridViewTextBoxColumn";
            this.kitapIsimDataGridViewTextBoxColumn.Width = 165;
            // 
            // kitapYazarDataGridViewTextBoxColumn
            // 
            this.kitapYazarDataGridViewTextBoxColumn.DataPropertyName = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.HeaderText = "Kitabın Yazarı";
            this.kitapYazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYazarDataGridViewTextBoxColumn.Name = "kitapYazarDataGridViewTextBoxColumn";
            this.kitapYazarDataGridViewTextBoxColumn.Width = 165;
            // 
            // kitapFiyatDataGridViewTextBoxColumn
            // 
            this.kitapFiyatDataGridViewTextBoxColumn.DataPropertyName = "KitapFiyat";
            this.kitapFiyatDataGridViewTextBoxColumn.HeaderText = "Kitabın Fiyatı";
            this.kitapFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapFiyatDataGridViewTextBoxColumn.Name = "kitapFiyatDataGridViewTextBoxColumn";
            this.kitapFiyatDataGridViewTextBoxColumn.Width = 165;
            // 
            // FormSatici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(906, 547);
            this.Controls.Add(this.btnGeriDön);
            this.Controls.Add(this.txtSaticiId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpbxSatilanKitaplar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSatisaKoy);
            this.Controls.Add(this.txtKitapFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKitapYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapİsim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaticiAdSoyad);
            this.Controls.Add(this.lblSaticiAdSoyad);
            this.Name = "FormSatici";
            this.Text = "FormSatici";
            this.Load += new System.EventHandler(this.FormSatici_Load);
            this.grpbxSatilanKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saticikitaptblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlSatDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaticiAdSoyad;
        private System.Windows.Forms.TextBox txtSaticiAdSoyad;
        private System.Windows.Forms.TextBox txtKitapİsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSatisaKoy;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox grpbxSatilanKitaplar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSaticiId;
        private System.Windows.Forms.Label label4;
        private kitapAlSatDataSet kitapAlSatDataSet;
        private System.Windows.Forms.BindingSource saticikitaptblBindingSource;
        private kitapAlSatDataSetTableAdapters.satici_kitap_tblTableAdapter satici_kitap_tblTableAdapter;
        private System.Windows.Forms.Button btnGeriDön;
        private System.Windows.Forms.DataGridViewTextBoxColumn saticiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saticiAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapFiyatDataGridViewTextBoxColumn;
    }
}