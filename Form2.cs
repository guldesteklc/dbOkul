using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbOkul
{
    public partial class bolumfrm : Form
    {

        public string constr = "Server=DESKTOP-Q34RTV3;database=db_okul;integrated security=true;";

        public bolumfrm()
        {
            InitializeComponent();
        }

        void grdtazele()
        {
           
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string sondurum = "select*from bolum order by bid desc";
            SqlDataAdapter sdp = new SqlDataAdapter(sondurum, conn);
            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgbolum.DataSource = dt;
            conn.Close();

        }

        private void ekle_ado_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string strkomut = "insert into bolum (bid,badi,aciklama,eposta) values(@vbid,@vbadi,@vaciklama,@veposta)";

            SqlCommand komutekle = new SqlCommand(strkomut, conn);

            komutekle.Parameters.AddWithValue("@vbid", txtbolid.Text);
            komutekle.Parameters.AddWithValue("@vbadi", bolcombo.SelectedValue);
            komutekle.Parameters.AddWithValue("@vaciklama", txtaciklama.Text);
            komutekle.Parameters.AddWithValue("@veposta", txtposta.Text);

            komutekle.ExecuteNonQuery();
            // kayıt ekleme bitti tablodaki son durum gride aktarılıyor

                conn.Close();

            grdtazele();
        }

        void cmbdoldur()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string strted = "Select * from bolum order by badi ";
            SqlDataAdapter sdp = new SqlDataAdapter(strted, conn);
            DataTable dtbolum = new DataTable();
            sdp.Fill(dtbolum);
            bolcombo.DisplayMember = "badi";
            bolcombo.ValueMember = "badi";
            bolcombo.DataSource = dtbolum;

            conn.Close();

        }

        private void bolumfrm_Load(object sender, EventArgs e)
        {
            cmbdoldur();
            grdtazele();

        }

        private void ekle_adosp_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "spbolumekle";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@vbid", txtbolid.Text);
            cmd.Parameters.AddWithValue("@vbadi", bolcombo.SelectedValue);
            cmd.Parameters.AddWithValue("@vaciklama", txtaciklama.Text);
            cmd.Parameters.AddWithValue("@veposta", txtposta.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            grdtazele();

        

        }

        private void enty_search_Click(object sender, EventArgs e)
        {
            db_okulEntities db = new db_okulEntities();
            if(bolcombo.Text!=null)
            {
                var sonuc = db.bolum.Where(x => x.badi.Contains(bolcombo.Text)).ToList();
                dgbolum.DataSource = sonuc;
            }
            else
            {
                dgbolum.DataSource = db.bolum.ToList();
            }
        }

        private void enty_ekle_Click(object sender, EventArgs e)
        {
            db_okulEntities db = new db_okulEntities();
            bolum bol = new bolum();
            bol.bid = Convert.ToInt32(txtbolid.Text);
            bol.badi = bolcombo.Text;
            bol.aciklama = txtaciklama.Text;
            bol.eposta = txtposta.Text;
            db.bolum.Add(bol);
            db.SaveChanges();

            dgbolum.DataSource = db.bolum.ToList();
        }

        private void enty_delete_Click(object sender, EventArgs e)
        {
            //satır seçip silebiliyorsun
            db_okulEntities db = new db_okulEntities();
            int xbolid = Convert.ToInt32(dgbolum.CurrentRow.Cells[0].Value);
            bolum silinecek = db.bolum.FirstOrDefault(x => x.bid == xbolid);

            db.bolum.Remove(silinecek);
            db.SaveChanges();
            dgbolum.DataSource = db.bolum.ToList();
        }

        private void sil_ado_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(constr);
            connect.Open();

            SqlCommand komutsil = new SqlCommand();
            komutsil.Connection = connect;
            komutsil.CommandText = "delete from bolum where bid=" + Convert.ToInt32(dgbolum.CurrentRow.Cells[0].Value);

            komutsil.ExecuteNonQuery();
            connect.Close();
            grdtazele();

        }


        private void sil_adosp_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand cnd = new SqlCommand();
            cnd.Connection = conn;

            cnd.CommandText = "spbolumsil";
            cnd.CommandType = CommandType.StoredProcedure;

            cnd.Parameters.AddWithValue("@vbid", txtbolid.Text);
            cnd.Parameters.AddWithValue("@vbadi", bolcombo.SelectedValue);
            cnd.Parameters.AddWithValue("@vaciklama", txtaciklama.Text);
            cnd.Parameters.AddWithValue("@veposta", txtposta.Text);

            cnd.ExecuteNonQuery();
            conn.Close();
            grdtazele();
        }

        

        private void ara_ado_Click(object sender, EventArgs e)
        {
           /*SqlConnection connect = new SqlConnection(constr);
            connect.Open();

            SqlCommand komutara = new SqlCommand();
            komutara.Connection = connect;
            komutara.CommandText = "select*from bolum where bid=" + Convert.ToInt32(txtbolid.Text);
            komutara.ExecuteNonQuery();
            connect.Close();
            grdtazele();*/
        }
        private void guncelle_ado_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(constr);
            //conn.Open();

            //SqlCommand kmtyenile = new SqlCommand();
            //kmtyenile.Connection = conn;
            //kmtyenile.CommandText = "update bolum set badi = @vbadi where bid = @vbid";
            //kmtyenile.Parameters.AddWithValue("@vbid", txtbolid.Text);
            //kmtyenile.Parameters.AddWithValue("@vbadi", bolcombo.SelectedValue);

            //kmtyenile.ExecuteNonQuery();
            //conn.Close();
           // grdtazele();
           //bu yazdıklarım olmadı yinede dursun
            
        }

        private void list_enty_Click(object sender, EventArgs e)
        {
            db_okulEntities context = new db_okulEntities();
            var result = context.bolum.ToList();
            dgbolum.DataSource = result;

        }
    }
}


