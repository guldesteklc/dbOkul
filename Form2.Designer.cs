
namespace dbOkul
{
    partial class bolumfrm
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
            this.dgbolum = new System.Windows.Forms.DataGridView();
            this.bolad = new System.Windows.Forms.Label();
            this.ekle_ado = new System.Windows.Forms.Button();
            this.aciklama = new System.Windows.Forms.Label();
            this.posta = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.txtposta = new System.Windows.Forms.TextBox();
            this.ekle_adosp = new System.Windows.Forms.Button();
            this.sil_ado = new System.Windows.Forms.Button();
            this.sil_adosp = new System.Windows.Forms.Button();
            this.ara_ado = new System.Windows.Forms.Button();
            this.guncelle_ado = new System.Windows.Forms.Button();
            this.txtbolid = new System.Windows.Forms.TextBox();
            this.bolid = new System.Windows.Forms.Label();
            this.bolcombo = new System.Windows.Forms.ComboBox();
            this.enty_ekle = new System.Windows.Forms.Button();
            this.enty_search = new System.Windows.Forms.Button();
            this.enty_delete = new System.Windows.Forms.Button();
            this.list_enty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbolum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbolum
            // 
            this.dgbolum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbolum.Location = new System.Drawing.Point(12, 186);
            this.dgbolum.Name = "dgbolum";
            this.dgbolum.Size = new System.Drawing.Size(763, 182);
            this.dgbolum.TabIndex = 0;
            // 
            // bolad
            // 
            this.bolad.AutoSize = true;
            this.bolad.Location = new System.Drawing.Point(38, 58);
            this.bolad.Name = "bolad";
            this.bolad.Size = new System.Drawing.Size(54, 13);
            this.bolad.TabIndex = 1;
            this.bolad.Text = "Bolum Adi";
            // 
            // ekle_ado
            // 
            this.ekle_ado.Location = new System.Drawing.Point(269, 27);
            this.ekle_ado.Name = "ekle_ado";
            this.ekle_ado.Size = new System.Drawing.Size(92, 23);
            this.ekle_ado.TabIndex = 2;
            this.ekle_ado.Text = "Ekle(Ado)";
            this.ekle_ado.UseVisualStyleBackColor = true;
            this.ekle_ado.Click += new System.EventHandler(this.ekle_ado_Click);
            // 
            // aciklama
            // 
            this.aciklama.AutoSize = true;
            this.aciklama.Location = new System.Drawing.Point(38, 85);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(50, 13);
            this.aciklama.TabIndex = 3;
            this.aciklama.Text = "Aciklama";
            // 
            // posta
            // 
            this.posta.AutoSize = true;
            this.posta.Location = new System.Drawing.Point(38, 114);
            this.posta.Name = "posta";
            this.posta.Size = new System.Drawing.Size(43, 13);
            this.posta.TabIndex = 4;
            this.posta.Text = "E-posta";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(113, 85);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(121, 20);
            this.txtaciklama.TabIndex = 6;
            // 
            // txtposta
            // 
            this.txtposta.Location = new System.Drawing.Point(113, 112);
            this.txtposta.Name = "txtposta";
            this.txtposta.Size = new System.Drawing.Size(121, 20);
            this.txtposta.TabIndex = 7;
            // 
            // ekle_adosp
            // 
            this.ekle_adosp.Location = new System.Drawing.Point(269, 58);
            this.ekle_adosp.Name = "ekle_adosp";
            this.ekle_adosp.Size = new System.Drawing.Size(92, 23);
            this.ekle_adosp.TabIndex = 8;
            this.ekle_adosp.Text = "Ekle (Ado SP)";
            this.ekle_adosp.UseVisualStyleBackColor = true;
            this.ekle_adosp.Click += new System.EventHandler(this.ekle_adosp_Click);
            // 
            // sil_ado
            // 
            this.sil_ado.Location = new System.Drawing.Point(389, 27);
            this.sil_ado.Name = "sil_ado";
            this.sil_ado.Size = new System.Drawing.Size(80, 23);
            this.sil_ado.TabIndex = 11;
            this.sil_ado.Text = "Sil(Ado)";
            this.sil_ado.UseVisualStyleBackColor = true;
            this.sil_ado.Click += new System.EventHandler(this.sil_ado_Click);
            // 
            // sil_adosp
            // 
            this.sil_adosp.Location = new System.Drawing.Point(389, 56);
            this.sil_adosp.Name = "sil_adosp";
            this.sil_adosp.Size = new System.Drawing.Size(80, 23);
            this.sil_adosp.TabIndex = 12;
            this.sil_adosp.Text = "Sil(Ado SP)";
            this.sil_adosp.UseVisualStyleBackColor = true;
            this.sil_adosp.Click += new System.EventHandler(this.sil_adosp_Click);
            // 
            // ara_ado
            // 
            this.ara_ado.Location = new System.Drawing.Point(490, 27);
            this.ara_ado.Name = "ara_ado";
            this.ara_ado.Size = new System.Drawing.Size(86, 23);
            this.ara_ado.TabIndex = 13;
            this.ara_ado.Text = "Ara (Ado)";
            this.ara_ado.UseVisualStyleBackColor = true;
            this.ara_ado.Click += new System.EventHandler(this.ara_ado_Click);
            // 
            // guncelle_ado
            // 
            this.guncelle_ado.Location = new System.Drawing.Point(582, 29);
            this.guncelle_ado.Name = "guncelle_ado";
            this.guncelle_ado.Size = new System.Drawing.Size(85, 23);
            this.guncelle_ado.TabIndex = 15;
            this.guncelle_ado.Text = "Güncelle(Ado)";
            this.guncelle_ado.UseVisualStyleBackColor = true;
            this.guncelle_ado.Click += new System.EventHandler(this.guncelle_ado_Click);
            // 
            // txtbolid
            // 
            this.txtbolid.Location = new System.Drawing.Point(113, 32);
            this.txtbolid.Name = "txtbolid";
            this.txtbolid.Size = new System.Drawing.Size(121, 20);
            this.txtbolid.TabIndex = 17;
            // 
            // bolid
            // 
            this.bolid.AutoSize = true;
            this.bolid.Location = new System.Drawing.Point(41, 33);
            this.bolid.Name = "bolid";
            this.bolid.Size = new System.Drawing.Size(36, 13);
            this.bolid.TabIndex = 18;
            this.bolid.Text = "Bol ID";
            // 
            // bolcombo
            // 
            this.bolcombo.FormattingEnabled = true;
            this.bolcombo.Location = new System.Drawing.Point(113, 58);
            this.bolcombo.Name = "bolcombo";
            this.bolcombo.Size = new System.Drawing.Size(121, 21);
            this.bolcombo.TabIndex = 5;
            // 
            // enty_ekle
            // 
            this.enty_ekle.Location = new System.Drawing.Point(269, 87);
            this.enty_ekle.Name = "enty_ekle";
            this.enty_ekle.Size = new System.Drawing.Size(92, 23);
            this.enty_ekle.TabIndex = 19;
            this.enty_ekle.Text = "Entity Ekle";
            this.enty_ekle.UseVisualStyleBackColor = true;
            this.enty_ekle.Click += new System.EventHandler(this.enty_ekle_Click);
            // 
            // enty_search
            // 
            this.enty_search.Location = new System.Drawing.Point(491, 58);
            this.enty_search.Name = "enty_search";
            this.enty_search.Size = new System.Drawing.Size(85, 23);
            this.enty_search.TabIndex = 20;
            this.enty_search.Text = "Entity Arama";
            this.enty_search.UseVisualStyleBackColor = true;
            this.enty_search.Click += new System.EventHandler(this.enty_search_Click);
            // 
            // enty_delete
            // 
            this.enty_delete.Location = new System.Drawing.Point(389, 87);
            this.enty_delete.Name = "enty_delete";
            this.enty_delete.Size = new System.Drawing.Size(80, 23);
            this.enty_delete.TabIndex = 21;
            this.enty_delete.Text = "Entity Sil";
            this.enty_delete.UseVisualStyleBackColor = true;
            this.enty_delete.Click += new System.EventHandler(this.enty_delete_Click);
            // 
            // list_enty
            // 
            this.list_enty.Location = new System.Drawing.Point(582, 58);
            this.list_enty.Name = "list_enty";
            this.list_enty.Size = new System.Drawing.Size(85, 23);
            this.list_enty.TabIndex = 23;
            this.list_enty.Text = "listele";
            this.list_enty.UseVisualStyleBackColor = true;
            this.list_enty.Click += new System.EventHandler(this.list_enty_Click);
            // 
            // bolumfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.list_enty);
            this.Controls.Add(this.enty_delete);
            this.Controls.Add(this.enty_search);
            this.Controls.Add(this.enty_ekle);
            this.Controls.Add(this.bolid);
            this.Controls.Add(this.txtbolid);
            this.Controls.Add(this.guncelle_ado);
            this.Controls.Add(this.ara_ado);
            this.Controls.Add(this.sil_adosp);
            this.Controls.Add(this.sil_ado);
            this.Controls.Add(this.ekle_adosp);
            this.Controls.Add(this.txtposta);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.bolcombo);
            this.Controls.Add(this.posta);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.ekle_ado);
            this.Controls.Add(this.bolad);
            this.Controls.Add(this.dgbolum);
            this.Name = "bolumfrm";
            this.Text = "BOLUM";
            this.Load += new System.EventHandler(this.bolumfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbolum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbolum;
        private System.Windows.Forms.Label bolad;
        private System.Windows.Forms.Button ekle_ado;
        private System.Windows.Forms.Label aciklama;
        private System.Windows.Forms.Label posta;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.TextBox txtposta;
        private System.Windows.Forms.Button ekle_adosp;
        private System.Windows.Forms.Button sil_ado;
        private System.Windows.Forms.Button sil_adosp;
        private System.Windows.Forms.Button ara_ado;
        private System.Windows.Forms.Button guncelle_ado;
        private System.Windows.Forms.TextBox txtbolid;
        private System.Windows.Forms.Label bolid;
        private System.Windows.Forms.ComboBox bolcombo;
        private System.Windows.Forms.Button enty_ekle;
        private System.Windows.Forms.Button enty_search;
        private System.Windows.Forms.Button enty_delete;
        private System.Windows.Forms.Button list_enty;
    }
}