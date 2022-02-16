
namespace Ikıncı_El_Kitap_Alim_Satim
{
    partial class FormAlici
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
            this.grpbxKitaplarAlici = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saticiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saticiAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saticikitaptblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapAlSatDataSet1 = new Ikıncı_El_Kitap_Alim_Satim.kitapAlSatDataSet1();
            this.lblAliciAdSoyad = new System.Windows.Forms.Label();
            this.txtAliciAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAlinacakKitap = new System.Windows.Forms.TextBox();
            this.lblAlinacakKitap = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.grpbxSatilanKitaplar = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.aliciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciAlinanKitapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciKitapFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alicitblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapAlSatDataSet2 = new Ikıncı_El_Kitap_Alim_Satim.kitapAlSatDataSet2();
            this.kitapAlSatDataSet = new Ikıncı_El_Kitap_Alim_Satim.kitapAlSatDataSet();
            this.kitapAlSatDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satici_kitap_tblTableAdapter = new Ikıncı_El_Kitap_Alim_Satim.kitapAlSatDataSet1TableAdapters.satici_kitap_tblTableAdapter();
            this.btnGeriDön2 = new System.Windows.Forms.Button();
            this.alici_tblTableAdapter = new Ikıncı_El_Kitap_Alim_Satim.kitapAlSatDataSet2TableAdapters.alici_tblTableAdapter();
            this.txtKitapFiyat = new System.Windows.Forms.TextBox();
            this.grpbxKitaplarAlici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saticikitaptblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlSatDataSet1)).BeginInit();
            this.grpbxSatilanKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicitblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlSatDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlSatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlSatDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxKitaplarAlici
            // 
            this.grpbxKitaplarAlici.Controls.Add(this.dataGridView1);
            this.grpbxKitaplarAlici.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbxKitaplarAlici.Location = new System.Drawing.Point(12, 12);
            this.grpbxKitaplarAlici.Name = "grpbxKitaplarAlici";
            this.grpbxKitaplarAlici.Size = new System.Drawing.Size(687, 262);
            this.grpbxKitaplarAlici.TabIndex = 0;
            this.grpbxKitaplarAlici.TabStop = false;
            this.grpbxKitaplarAlici.Text = "Satışta Olan Kitaplar";
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // saticiIdDataGridViewTextBoxColumn
            // 
            this.saticiIdDataGridViewTextBoxColumn.DataPropertyName = "SaticiId";
            this.saticiIdDataGridViewTextBoxColumn.HeaderText = "Satıcı ID";
            this.saticiIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saticiIdDataGridViewTextBoxColumn.Name = "saticiIdDataGridViewTextBoxColumn";
            this.saticiIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.saticiIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // saticiAdSoyadDataGridViewTextBoxColumn
            // 
            this.saticiAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "SaticiAdSoyad";
            this.saticiAdSoyadDataGridViewTextBoxColumn.HeaderText = "Satıcının Adı Soyadı";
            this.saticiAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saticiAdSoyadDataGridViewTextBoxColumn.Name = "saticiAdSoyadDataGridViewTextBoxColumn";
            this.saticiAdSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapIsimDataGridViewTextBoxColumn
            // 
            this.kitapIsimDataGridViewTextBoxColumn.DataPropertyName = "KitapIsim";
            this.kitapIsimDataGridViewTextBoxColumn.HeaderText = "Kitabın İsmi";
            this.kitapIsimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapIsimDataGridViewTextBoxColumn.Name = "kitapIsimDataGridViewTextBoxColumn";
            this.kitapIsimDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapYazarDataGridViewTextBoxColumn
            // 
            this.kitapYazarDataGridViewTextBoxColumn.DataPropertyName = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.HeaderText = "Kitabın Yazarı";
            this.kitapYazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYazarDataGridViewTextBoxColumn.Name = "kitapYazarDataGridViewTextBoxColumn";
            this.kitapYazarDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapFiyatDataGridViewTextBoxColumn
            // 
            this.kitapFiyatDataGridViewTextBoxColumn.DataPropertyName = "KitapFiyat";
            this.kitapFiyatDataGridViewTextBoxColumn.HeaderText = "Kitabın Satış Fiyatı";
            this.kitapFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapFiyatDataGridViewTextBoxColumn.Name = "kitapFiyatDataGridViewTextBoxColumn";
            this.kitapFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // saticikitaptblBindingSource
            // 
            this.saticikitaptblBindingSource.DataMember = "satici_kitap_tbl";
            this.saticikitaptblBindingSource.DataSource = this.kitapAlSatDataSet1;
            // 
            // kitapAlSatDataSet1
            // 
            this.kitapAlSatDataSet1.DataSetName = "kitapAlSatDataSet1";
            this.kitapAlSatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblAliciAdSoyad
            // 
            this.lblAliciAdSoyad.AutoSize = true;
            this.lblAliciAdSoyad.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblAliciAdSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAliciAdSoyad.Location = new System.Drawing.Point(718, 144);
            this.lblAliciAdSoyad.Name = "lblAliciAdSoyad";
            this.lblAliciAdSoyad.Size = new System.Drawing.Size(133, 23);
            this.lblAliciAdSoyad.TabIndex = 1;
            this.lblAliciAdSoyad.Text = "Alıcı Ad Soyad:";
            // 
            // txtAliciAdSoyad
            // 
            this.txtAliciAdSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAliciAdSoyad.Location = new System.Drawing.Point(722, 170);
            this.txtAliciAdSoyad.Name = "txtAliciAdSoyad";
            this.txtAliciAdSoyad.Size = new System.Drawing.Size(172, 30);
            this.txtAliciAdSoyad.TabIndex = 2;
            // 
            // txtAlinacakKitap
            // 
            this.txtAlinacakKitap.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlinacakKitap.Location = new System.Drawing.Point(722, 229);
            this.txtAlinacakKitap.Name = "txtAlinacakKitap";
            this.txtAlinacakKitap.Size = new System.Drawing.Size(172, 30);
            this.txtAlinacakKitap.TabIndex = 4;
            // 
            // lblAlinacakKitap
            // 
            this.lblAlinacakKitap.AutoSize = true;
            this.lblAlinacakKitap.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblAlinacakKitap.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlinacakKitap.Location = new System.Drawing.Point(718, 203);
            this.lblAlinacakKitap.Name = "lblAlinacakKitap";
            this.lblAlinacakKitap.Size = new System.Drawing.Size(129, 23);
            this.lblAlinacakKitap.TabIndex = 3;
            this.lblAlinacakKitap.Text = "Alınacak Kitap:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(718, 262);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(99, 23);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "Kitap Fiyat:";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSatinAl.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAl.Location = new System.Drawing.Point(722, 324);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(151, 43);
            this.btnSatinAl.TabIndex = 7;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = false;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // grpbxSatilanKitaplar
            // 
            this.grpbxSatilanKitaplar.Controls.Add(this.dataGridView2);
            this.grpbxSatilanKitaplar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbxSatilanKitaplar.Location = new System.Drawing.Point(12, 277);
            this.grpbxSatilanKitaplar.Name = "grpbxSatilanKitaplar";
            this.grpbxSatilanKitaplar.Size = new System.Drawing.Size(687, 262);
            this.grpbxSatilanKitaplar.TabIndex = 8;
            this.grpbxSatilanKitaplar.TabStop = false;
            this.grpbxSatilanKitaplar.Text = "Satılan Kitaplar ve Sahipleri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aliciIdDataGridViewTextBoxColumn,
            this.aliciAdSoyadDataGridViewTextBoxColumn,
            this.aliciAlinanKitapDataGridViewTextBoxColumn,
            this.aliciKitapFiyatDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.alicitblBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(681, 236);
            this.dataGridView2.TabIndex = 0;
            // 
            // aliciIdDataGridViewTextBoxColumn
            // 
            this.aliciIdDataGridViewTextBoxColumn.DataPropertyName = "AliciId";
            this.aliciIdDataGridViewTextBoxColumn.HeaderText = "Alıcı ID";
            this.aliciIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aliciIdDataGridViewTextBoxColumn.Name = "aliciIdDataGridViewTextBoxColumn";
            this.aliciIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.aliciIdDataGridViewTextBoxColumn.Width = 165;
            // 
            // aliciAdSoyadDataGridViewTextBoxColumn
            // 
            this.aliciAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "AliciAdSoyad";
            this.aliciAdSoyadDataGridViewTextBoxColumn.HeaderText = "Alan Kişinin Adı Soyadı";
            this.aliciAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aliciAdSoyadDataGridViewTextBoxColumn.Name = "aliciAdSoyadDataGridViewTextBoxColumn";
            this.aliciAdSoyadDataGridViewTextBoxColumn.Width = 165;
            // 
            // aliciAlinanKitapDataGridViewTextBoxColumn
            // 
            this.aliciAlinanKitapDataGridViewTextBoxColumn.DataPropertyName = "AliciAlinanKitap";
            this.aliciAlinanKitapDataGridViewTextBoxColumn.HeaderText = "Alınan Kitap";
            this.aliciAlinanKitapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aliciAlinanKitapDataGridViewTextBoxColumn.Name = "aliciAlinanKitapDataGridViewTextBoxColumn";
            this.aliciAlinanKitapDataGridViewTextBoxColumn.Width = 165;
            // 
            // aliciKitapFiyatDataGridViewTextBoxColumn
            // 
            this.aliciKitapFiyatDataGridViewTextBoxColumn.DataPropertyName = "AliciKitapFiyat";
            this.aliciKitapFiyatDataGridViewTextBoxColumn.HeaderText = "Alınan Kitabın Fiyatı";
            this.aliciKitapFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aliciKitapFiyatDataGridViewTextBoxColumn.Name = "aliciKitapFiyatDataGridViewTextBoxColumn";
            this.aliciKitapFiyatDataGridViewTextBoxColumn.Width = 165;
            // 
            // alicitblBindingSource
            // 
            this.alicitblBindingSource.DataMember = "alici_tbl";
            this.alicitblBindingSource.DataSource = this.kitapAlSatDataSet2;
            // 
            // kitapAlSatDataSet2
            // 
            this.kitapAlSatDataSet2.DataSetName = "kitapAlSatDataSet2";
            this.kitapAlSatDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapAlSatDataSet
            // 
            this.kitapAlSatDataSet.DataSetName = "kitapAlSatDataSet";
            this.kitapAlSatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapAlSatDataSetBindingSource
            // 
            this.kitapAlSatDataSetBindingSource.DataSource = this.kitapAlSatDataSet;
            this.kitapAlSatDataSetBindingSource.Position = 0;
            // 
            // satici_kitap_tblTableAdapter
            // 
            this.satici_kitap_tblTableAdapter.ClearBeforeFill = true;
            // 
            // btnGeriDön2
            // 
            this.btnGeriDön2.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnGeriDön2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDön2.Location = new System.Drawing.Point(722, 373);
            this.btnGeriDön2.Name = "btnGeriDön2";
            this.btnGeriDön2.Size = new System.Drawing.Size(151, 43);
            this.btnGeriDön2.TabIndex = 16;
            this.btnGeriDön2.Text = "Geri Dön";
            this.btnGeriDön2.UseVisualStyleBackColor = false;
            this.btnGeriDön2.Click += new System.EventHandler(this.btnGeriDön2_Click);
            // 
            // alici_tblTableAdapter
            // 
            this.alici_tblTableAdapter.ClearBeforeFill = true;
            // 
            // txtKitapFiyat
            // 
            this.txtKitapFiyat.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapFiyat.Location = new System.Drawing.Point(722, 288);
            this.txtKitapFiyat.Name = "txtKitapFiyat";
            this.txtKitapFiyat.ReadOnly = true;
            this.txtKitapFiyat.Size = new System.Drawing.Size(172, 30);
            this.txtKitapFiyat.TabIndex = 17;
            // 
            // FormAlici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(906, 547);
            this.Controls.Add(this.txtKitapFiyat);
            this.Controls.Add(this.btnGeriDön2);
            this.Controls.Add(this.grpbxSatilanKitaplar);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtAlinacakKitap);
            this.Controls.Add(this.lblAlinacakKitap);
            this.Controls.Add(this.txtAliciAdSoyad);
            this.Controls.Add(this.lblAliciAdSoyad);
            this.Controls.Add(this.grpbxKitaplarAlici);
            this.Name = "FormAlici";
            this.Text = "FormAlici";
            this.Load += new System.EventHandler(this.FormAlici_Load);
            this.grpbxKitaplarAlici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saticikitaptblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlSatDataSet1)).EndInit();
            this.grpbxSatilanKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicitblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlSatDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlSatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlSatDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxKitaplarAlici;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAliciAdSoyad;
        private System.Windows.Forms.TextBox txtAliciAdSoyad;
        private System.Windows.Forms.TextBox txtAlinacakKitap;
        private System.Windows.Forms.Label lblAlinacakKitap;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.GroupBox grpbxSatilanKitaplar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource kitapAlSatDataSetBindingSource;
        private kitapAlSatDataSet kitapAlSatDataSet;
        private kitapAlSatDataSet1 kitapAlSatDataSet1;
        private System.Windows.Forms.BindingSource saticikitaptblBindingSource;
        private kitapAlSatDataSet1TableAdapters.satici_kitap_tblTableAdapter satici_kitap_tblTableAdapter;
        private System.Windows.Forms.Button btnGeriDön2;
        private kitapAlSatDataSet2 kitapAlSatDataSet2;
        private System.Windows.Forms.BindingSource alicitblBindingSource;
        private kitapAlSatDataSet2TableAdapters.alici_tblTableAdapter alici_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saticiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saticiAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciAlinanKitapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciKitapFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtKitapFiyat;
    }
}