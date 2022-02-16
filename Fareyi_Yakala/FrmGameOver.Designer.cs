
namespace Click_In_Time
{
    partial class FrmGameOver
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
            this.lblOyunBitti = new System.Windows.Forms.Label();
            this.lblSkorunuz = new System.Windows.Forms.Label();
            this.lblSkor2 = new System.Windows.Forms.Label();
            this.lblReplay = new System.Windows.Forms.Label();
            this.btnEvet = new System.Windows.Forms.Button();
            this.btnHayır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOyunBitti
            // 
            this.lblOyunBitti.AutoSize = true;
            this.lblOyunBitti.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblOyunBitti.Font = new System.Drawing.Font("Perpetua Titling MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyunBitti.Location = new System.Drawing.Point(179, 46);
            this.lblOyunBitti.Name = "lblOyunBitti";
            this.lblOyunBitti.Size = new System.Drawing.Size(341, 58);
            this.lblOyunBitti.TabIndex = 0;
            this.lblOyunBitti.Text = "OYUN BİTTİ";
            // 
            // lblSkorunuz
            // 
            this.lblSkorunuz.AutoSize = true;
            this.lblSkorunuz.BackColor = System.Drawing.Color.Khaki;
            this.lblSkorunuz.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkorunuz.Location = new System.Drawing.Point(305, 148);
            this.lblSkorunuz.Name = "lblSkorunuz";
            this.lblSkorunuz.Size = new System.Drawing.Size(108, 52);
            this.lblSkorunuz.TabIndex = 1;
            this.lblSkorunuz.Text = "Skor";
            // 
            // lblSkor2
            // 
            this.lblSkor2.AutoSize = true;
            this.lblSkor2.BackColor = System.Drawing.Color.Khaki;
            this.lblSkor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor2.Location = new System.Drawing.Point(343, 221);
            this.lblSkor2.Name = "lblSkor2";
            this.lblSkor2.Size = new System.Drawing.Size(36, 39);
            this.lblSkor2.TabIndex = 2;
            this.lblSkor2.Text = "0";
            // 
            // lblReplay
            // 
            this.lblReplay.AutoSize = true;
            this.lblReplay.BackColor = System.Drawing.Color.Cornsilk;
            this.lblReplay.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReplay.Location = new System.Drawing.Point(206, 281);
            this.lblReplay.Name = "lblReplay";
            this.lblReplay.Size = new System.Drawing.Size(314, 27);
            this.lblReplay.TabIndex = 3;
            this.lblReplay.Text = "Yeniden Oynamak İster Misiniz?";
            // 
            // btnEvet
            // 
            this.btnEvet.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnEvet.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvet.Location = new System.Drawing.Point(258, 327);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(99, 46);
            this.btnEvet.TabIndex = 4;
            this.btnEvet.Text = "Evet";
            this.btnEvet.UseVisualStyleBackColor = false;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // btnHayır
            // 
            this.btnHayır.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnHayır.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHayır.Location = new System.Drawing.Point(368, 327);
            this.btnHayır.Name = "btnHayır";
            this.btnHayır.Size = new System.Drawing.Size(99, 46);
            this.btnHayır.TabIndex = 5;
            this.btnHayır.Text = "Hayır";
            this.btnHayır.UseVisualStyleBackColor = false;
            this.btnHayır.Click += new System.EventHandler(this.btnHayır_Click);
            // 
            // FrmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(719, 430);
            this.Controls.Add(this.btnHayır);
            this.Controls.Add(this.btnEvet);
            this.Controls.Add(this.lblReplay);
            this.Controls.Add(this.lblSkor2);
            this.Controls.Add(this.lblSkorunuz);
            this.Controls.Add(this.lblOyunBitti);
            this.Name = "FrmGameOver";
            this.Text = "FrmGameOver";
            this.Load += new System.EventHandler(this.FrmGameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOyunBitti;
        private System.Windows.Forms.Label lblSkorunuz;
        private System.Windows.Forms.Label lblSkor2;
        private System.Windows.Forms.Label lblReplay;
        private System.Windows.Forms.Button btnEvet;
        private System.Windows.Forms.Button btnHayır;
    }
}