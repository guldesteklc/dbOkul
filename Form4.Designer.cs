
namespace dbOkul
{
    partial class ogrencifrm
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
            this.sil_adosp3 = new System.Windows.Forms.Button();
            this.sil_ado3 = new System.Windows.Forms.Button();
            this.ekle_adosp3 = new System.Windows.Forms.Button();
            this.ekle_ado3 = new System.Windows.Forms.Button();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_ogrncadi = new System.Windows.Forms.TextBox();
            this.d_yeri = new System.Windows.Forms.Label();
            this.o_kodu = new System.Windows.Forms.Label();
            this.dgogrenci = new System.Windows.Forms.DataGridView();
            this.o_adi = new System.Windows.Forms.Label();
            this.txt_dyeri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrencinotxt = new System.Windows.Forms.TextBox();
            this.txtbolid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgogrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // sil_adosp3
            // 
            this.sil_adosp3.Location = new System.Drawing.Point(354, 72);
            this.sil_adosp3.Name = "sil_adosp3";
            this.sil_adosp3.Size = new System.Drawing.Size(75, 23);
            this.sil_adosp3.TabIndex = 39;
            this.sil_adosp3.Text = "Sil(Ado SP)";
            this.sil_adosp3.UseVisualStyleBackColor = true;
            this.sil_adosp3.Click += new System.EventHandler(this.sil_adosp3_Click);
            // 
            // sil_ado3
            // 
            this.sil_ado3.Location = new System.Drawing.Point(354, 43);
            this.sil_ado3.Name = "sil_ado3";
            this.sil_ado3.Size = new System.Drawing.Size(75, 23);
            this.sil_ado3.TabIndex = 38;
            this.sil_ado3.Text = "Sil(Ado)";
            this.sil_ado3.UseVisualStyleBackColor = true;
            this.sil_ado3.Click += new System.EventHandler(this.sil_ado3_Click);
            // 
            // ekle_adosp3
            // 
            this.ekle_adosp3.Location = new System.Drawing.Point(256, 73);
            this.ekle_adosp3.Name = "ekle_adosp3";
            this.ekle_adosp3.Size = new System.Drawing.Size(75, 23);
            this.ekle_adosp3.TabIndex = 35;
            this.ekle_adosp3.Text = "Ekle (Ado SP)";
            this.ekle_adosp3.UseVisualStyleBackColor = true;
            this.ekle_adosp3.Click += new System.EventHandler(this.ekle_adosp3_Click);
            // 
            // ekle_ado3
            // 
            this.ekle_ado3.Location = new System.Drawing.Point(256, 44);
            this.ekle_ado3.Name = "ekle_ado3";
            this.ekle_ado3.Size = new System.Drawing.Size(75, 23);
            this.ekle_ado3.TabIndex = 34;
            this.ekle_ado3.Text = "Ekle(Ado)";
            this.ekle_ado3.UseVisualStyleBackColor = true;
            this.ekle_ado3.Click += new System.EventHandler(this.ekle_ado3_Click);
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(117, 75);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(100, 20);
            this.txt_soyadi.TabIndex = 33;
            // 
            // txt_ogrncadi
            // 
            this.txt_ogrncadi.Location = new System.Drawing.Point(117, 46);
            this.txt_ogrncadi.Name = "txt_ogrncadi";
            this.txt_ogrncadi.Size = new System.Drawing.Size(100, 20);
            this.txt_ogrncadi.TabIndex = 32;
            // 
            // d_yeri
            // 
            this.d_yeri.AutoSize = true;
            this.d_yeri.Location = new System.Drawing.Point(34, 107);
            this.d_yeri.Name = "d_yeri";
            this.d_yeri.Size = new System.Drawing.Size(62, 13);
            this.d_yeri.TabIndex = 30;
            this.d_yeri.Text = "Dogum Yeri";
            this.d_yeri.Click += new System.EventHandler(this.d_yeri_Click);
            // 
            // o_kodu
            // 
            this.o_kodu.AutoSize = true;
            this.o_kodu.Location = new System.Drawing.Point(31, 78);
            this.o_kodu.Name = "o_kodu";
            this.o_kodu.Size = new System.Drawing.Size(79, 13);
            this.o_kodu.TabIndex = 29;
            this.o_kodu.Text = "Ogrenci Soyadi";
            this.o_kodu.Click += new System.EventHandler(this.o_kodu_Click);
            // 
            // dgogrenci
            // 
            this.dgogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgogrenci.Location = new System.Drawing.Point(12, 202);
            this.dgogrenci.Name = "dgogrenci";
            this.dgogrenci.Size = new System.Drawing.Size(772, 175);
            this.dgogrenci.TabIndex = 28;
            // 
            // o_adi
            // 
            this.o_adi.AutoSize = true;
            this.o_adi.Location = new System.Drawing.Point(33, 49);
            this.o_adi.Name = "o_adi";
            this.o_adi.Size = new System.Drawing.Size(62, 13);
            this.o_adi.TabIndex = 27;
            this.o_adi.Text = "Ogrenci Adi";
            this.o_adi.Click += new System.EventHandler(this.o_adi_Click);
            // 
            // txt_dyeri
            // 
            this.txt_dyeri.Location = new System.Drawing.Point(117, 107);
            this.txt_dyeri.Name = "txt_dyeri";
            this.txt_dyeri.Size = new System.Drawing.Size(100, 20);
            this.txt_dyeri.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ogrenci NO";
            // 
            // ogrencinotxt
            // 
            this.ogrencinotxt.Location = new System.Drawing.Point(117, 20);
            this.ogrencinotxt.Name = "ogrencinotxt";
            this.ogrencinotxt.Size = new System.Drawing.Size(100, 20);
            this.ogrencinotxt.TabIndex = 46;
            // 
            // txtbolid
            // 
            this.txtbolid.Location = new System.Drawing.Point(117, 133);
            this.txtbolid.Name = "txtbolid";
            this.txtbolid.Size = new System.Drawing.Size(100, 20);
            this.txtbolid.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Bolum ID";
            // 
            // ogrencifrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbolid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ogrencinotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dyeri);
            this.Controls.Add(this.sil_adosp3);
            this.Controls.Add(this.sil_ado3);
            this.Controls.Add(this.ekle_adosp3);
            this.Controls.Add(this.ekle_ado3);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.txt_ogrncadi);
            this.Controls.Add(this.d_yeri);
            this.Controls.Add(this.o_kodu);
            this.Controls.Add(this.dgogrenci);
            this.Controls.Add(this.o_adi);
            this.Name = "ogrencifrm";
            this.Text = "OGRENCİ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgogrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sil_adosp3;
        private System.Windows.Forms.Button sil_ado3;
        private System.Windows.Forms.Button ekle_adosp3;
        private System.Windows.Forms.Button ekle_ado3;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_ogrncadi;
        private System.Windows.Forms.Label d_yeri;
        private System.Windows.Forms.Label o_kodu;
        private System.Windows.Forms.DataGridView dgogrenci;
        private System.Windows.Forms.Label o_adi;
        private System.Windows.Forms.TextBox txt_dyeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ogrencinotxt;
        private System.Windows.Forms.TextBox txtbolid;
        private System.Windows.Forms.Label label2;
    }
}