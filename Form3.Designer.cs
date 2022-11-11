
namespace dbOkul
{
    partial class dersfrm
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
            this.d_adi = new System.Windows.Forms.Label();
            this.dgders = new System.Windows.Forms.DataGridView();
            this.d_kodu = new System.Windows.Forms.Label();
            this.d_kredisi = new System.Windows.Forms.Label();
            this.nmrc_kredi = new System.Windows.Forms.NumericUpDown();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_kodu = new System.Windows.Forms.TextBox();
            this.sil_adosp2 = new System.Windows.Forms.Button();
            this.sil_ado2 = new System.Windows.Forms.Button();
            this.ekle_adosp2 = new System.Windows.Forms.Button();
            this.ekle_ado2 = new System.Windows.Forms.Button();
            this.dersid = new System.Windows.Forms.Label();
            this.txt_did = new System.Windows.Forms.TextBox();
            this.txtbolid = new System.Windows.Forms.TextBox();
            this.bolid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_kredi)).BeginInit();
            this.SuspendLayout();
            // 
            // d_adi
            // 
            this.d_adi.AutoSize = true;
            this.d_adi.Location = new System.Drawing.Point(27, 49);
            this.d_adi.Name = "d_adi";
            this.d_adi.Size = new System.Drawing.Size(47, 13);
            this.d_adi.TabIndex = 0;
            this.d_adi.Text = "Ders Adi";
            // 
            // dgders
            // 
            this.dgders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgders.Location = new System.Drawing.Point(12, 187);
            this.dgders.Name = "dgders";
            this.dgders.Size = new System.Drawing.Size(772, 175);
            this.dgders.TabIndex = 1;
            // 
            // d_kodu
            // 
            this.d_kodu.AutoSize = true;
            this.d_kodu.Location = new System.Drawing.Point(27, 77);
            this.d_kodu.Name = "d_kodu";
            this.d_kodu.Size = new System.Drawing.Size(57, 13);
            this.d_kodu.TabIndex = 2;
            this.d_kodu.Text = "Ders Kodu";
            // 
            // d_kredisi
            // 
            this.d_kredisi.AutoSize = true;
            this.d_kredisi.Location = new System.Drawing.Point(27, 105);
            this.d_kredisi.Name = "d_kredisi";
            this.d_kredisi.Size = new System.Drawing.Size(63, 13);
            this.d_kredisi.TabIndex = 3;
            this.d_kredisi.Text = "Ders Kredisi";
            // 
            // nmrc_kredi
            // 
            this.nmrc_kredi.Location = new System.Drawing.Point(97, 105);
            this.nmrc_kredi.Name = "nmrc_kredi";
            this.nmrc_kredi.Size = new System.Drawing.Size(120, 20);
            this.nmrc_kredi.TabIndex = 4;
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(97, 49);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 5;
            // 
            // txt_kodu
            // 
            this.txt_kodu.Location = new System.Drawing.Point(97, 77);
            this.txt_kodu.Name = "txt_kodu";
            this.txt_kodu.Size = new System.Drawing.Size(100, 20);
            this.txt_kodu.TabIndex = 6;
            // 
            // sil_adosp2
            // 
            this.sil_adosp2.Location = new System.Drawing.Point(384, 76);
            this.sil_adosp2.Name = "sil_adosp2";
            this.sil_adosp2.Size = new System.Drawing.Size(75, 23);
            this.sil_adosp2.TabIndex = 22;
            this.sil_adosp2.Text = "Sil(Ado SP)";
            this.sil_adosp2.UseVisualStyleBackColor = true;
            this.sil_adosp2.Click += new System.EventHandler(this.sil_adosp2_Click);
            // 
            // sil_ado2
            // 
            this.sil_ado2.Location = new System.Drawing.Point(384, 47);
            this.sil_ado2.Name = "sil_ado2";
            this.sil_ado2.Size = new System.Drawing.Size(75, 23);
            this.sil_ado2.TabIndex = 21;
            this.sil_ado2.Text = "Sil(Ado)";
            this.sil_ado2.UseVisualStyleBackColor = true;
            this.sil_ado2.Click += new System.EventHandler(this.sil_ado2_Click);
            // 
            // ekle_adosp2
            // 
            this.ekle_adosp2.Location = new System.Drawing.Point(264, 76);
            this.ekle_adosp2.Name = "ekle_adosp2";
            this.ekle_adosp2.Size = new System.Drawing.Size(75, 23);
            this.ekle_adosp2.TabIndex = 18;
            this.ekle_adosp2.Text = "Ekle (Ado SP)";
            this.ekle_adosp2.UseVisualStyleBackColor = true;
            this.ekle_adosp2.Click += new System.EventHandler(this.ekle_adosp2_Click);
            // 
            // ekle_ado2
            // 
            this.ekle_ado2.Location = new System.Drawing.Point(264, 47);
            this.ekle_ado2.Name = "ekle_ado2";
            this.ekle_ado2.Size = new System.Drawing.Size(75, 23);
            this.ekle_ado2.TabIndex = 17;
            this.ekle_ado2.Text = "Ekle(Ado)";
            this.ekle_ado2.UseVisualStyleBackColor = true;
            this.ekle_ado2.Click += new System.EventHandler(this.ekle_ado2_Click);
            // 
            // dersid
            // 
            this.dersid.AutoSize = true;
            this.dersid.Location = new System.Drawing.Point(27, 24);
            this.dersid.Name = "dersid";
            this.dersid.Size = new System.Drawing.Size(43, 13);
            this.dersid.TabIndex = 27;
            this.dersid.Text = "Ders ID";
            // 
            // txt_did
            // 
            this.txt_did.Location = new System.Drawing.Point(97, 17);
            this.txt_did.Name = "txt_did";
            this.txt_did.Size = new System.Drawing.Size(100, 20);
            this.txt_did.TabIndex = 28;
            // 
            // txtbolid
            // 
            this.txtbolid.Location = new System.Drawing.Point(97, 131);
            this.txtbolid.Name = "txtbolid";
            this.txtbolid.Size = new System.Drawing.Size(100, 20);
            this.txtbolid.TabIndex = 29;
            // 
            // bolid
            // 
            this.bolid.AutoSize = true;
            this.bolid.Location = new System.Drawing.Point(35, 138);
            this.bolid.Name = "bolid";
            this.bolid.Size = new System.Drawing.Size(36, 13);
            this.bolid.TabIndex = 30;
            this.bolid.Text = "Bol ID";
            // 
            // dersfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bolid);
            this.Controls.Add(this.txtbolid);
            this.Controls.Add(this.txt_did);
            this.Controls.Add(this.dersid);
            this.Controls.Add(this.sil_adosp2);
            this.Controls.Add(this.sil_ado2);
            this.Controls.Add(this.ekle_adosp2);
            this.Controls.Add(this.ekle_ado2);
            this.Controls.Add(this.txt_kodu);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.nmrc_kredi);
            this.Controls.Add(this.d_kredisi);
            this.Controls.Add(this.d_kodu);
            this.Controls.Add(this.dgders);
            this.Controls.Add(this.d_adi);
            this.Name = "dersfrm";
            this.Text = "DERS";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_kredi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label d_adi;
        private System.Windows.Forms.DataGridView dgders;
        private System.Windows.Forms.Label d_kodu;
        private System.Windows.Forms.Label d_kredisi;
        private System.Windows.Forms.NumericUpDown nmrc_kredi;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_kodu;
        private System.Windows.Forms.Button sil_adosp2;
        private System.Windows.Forms.Button sil_ado2;
        private System.Windows.Forms.Button ekle_adosp2;
        private System.Windows.Forms.Button ekle_ado2;
        private System.Windows.Forms.Label dersid;
        private System.Windows.Forms.TextBox txt_did;
        private System.Windows.Forms.TextBox txtbolid;
        private System.Windows.Forms.Label bolid;
    }
}