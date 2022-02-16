
namespace Ikıncı_El_Kitap_Alim_Satim
{
    partial class FormGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlici = new System.Windows.Forms.Button();
            this.btnSatici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 118);
            this.label1.TabIndex = 0;
            this.label1.Text = "2. EL KİTAP \r\nALIM SATIM";
            // 
            // btnAlici
            // 
            this.btnAlici.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAlici.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlici.Location = new System.Drawing.Point(145, 192);
            this.btnAlici.Name = "btnAlici";
            this.btnAlici.Size = new System.Drawing.Size(138, 61);
            this.btnAlici.TabIndex = 1;
            this.btnAlici.Text = "Alıcı";
            this.btnAlici.UseVisualStyleBackColor = false;
            this.btnAlici.Click += new System.EventHandler(this.btnAlici_Click);
            // 
            // btnSatici
            // 
            this.btnSatici.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSatici.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatici.Location = new System.Drawing.Point(145, 259);
            this.btnSatici.Name = "btnSatici";
            this.btnSatici.Size = new System.Drawing.Size(138, 61);
            this.btnSatici.TabIndex = 2;
            this.btnSatici.Text = "Satıcı";
            this.btnSatici.UseVisualStyleBackColor = false;
            this.btnSatici.Click += new System.EventHandler(this.btnSatici_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(433, 411);
            this.Controls.Add(this.btnSatici);
            this.Controls.Add(this.btnAlici);
            this.Controls.Add(this.label1);
            this.Name = "FormGiris";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlici;
        private System.Windows.Forms.Button btnSatici;
    }
}

