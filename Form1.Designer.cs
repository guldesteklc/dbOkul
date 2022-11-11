
namespace dbOkul
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dbOKULToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogretmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbOKULToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dbOKULToolStripMenuItem
            // 
            this.dbOKULToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolumToolStripMenuItem,
            this.dersToolStripMenuItem,
            this.ogrenciToolStripMenuItem,
            this.ogretmenToolStripMenuItem});
            this.dbOKULToolStripMenuItem.Name = "dbOKULToolStripMenuItem";
            this.dbOKULToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.dbOKULToolStripMenuItem.Text = "dbOKUL";
            this.dbOKULToolStripMenuItem.Click += new System.EventHandler(this.dbOKULToolStripMenuItem_Click);
            // 
            // bolumToolStripMenuItem
            // 
            this.bolumToolStripMenuItem.Name = "bolumToolStripMenuItem";
            this.bolumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bolumToolStripMenuItem.Text = "Bolum";
            this.bolumToolStripMenuItem.Click += new System.EventHandler(this.bolumToolStripMenuItem_Click);
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dersToolStripMenuItem.Text = "Ders";
            this.dersToolStripMenuItem.Click += new System.EventHandler(this.dersToolStripMenuItem_Click);
            // 
            // ogrenciToolStripMenuItem
            // 
            this.ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            this.ogrenciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ogrenciToolStripMenuItem.Text = "Ogrenci";
            this.ogrenciToolStripMenuItem.Click += new System.EventHandler(this.ogrenciToolStripMenuItem_Click);
            // 
            // ogretmenToolStripMenuItem
            // 
            this.ogretmenToolStripMenuItem.Name = "ogretmenToolStripMenuItem";
            this.ogretmenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ogretmenToolStripMenuItem.Text = "Ogretmen";
            this.ogretmenToolStripMenuItem.Click += new System.EventHandler(this.ogretmenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dbOKULToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogretmenToolStripMenuItem;
    }
}

