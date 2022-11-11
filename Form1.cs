using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbOkul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bolumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bolumfrm frmbol = new bolumfrm();
            frmbol.Show();
        }

        private void dersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersfrm frmderss = new dersfrm();
            frmderss.Show();
        }

        private void ogrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrencifrm frmogrenci = new ogrencifrm();
            frmogrenci.Show();
        }

        private void ogretmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrtmnfrm frmogretmen = new ogrtmnfrm();
            frmogretmen.Show();
        }

        private void dbOKULToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
