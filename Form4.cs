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
    public partial class ogrencifrm : Form
    {

        public string constr = "Server=DESKTOP-Q34RTV3;Database=db_okul;integrated security=true;";

        

        public ogrencifrm()
        {
            InitializeComponent();
        }

        void grdtazele()
        {
            // baglanti stringi oluştur
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string sondurum = "select*from ogrenci order by ono desc";
            SqlDataAdapter sdp = new SqlDataAdapter(sondurum, conn);
            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgogrenci.DataSource = dt;
            conn.Close();

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            grdtazele();
        }

        private void o_adi_Click(object sender, EventArgs e)
        {

        }

        private void o_kodu_Click(object sender, EventArgs e)
        {

        }

        private void d_yeri_Click(object sender, EventArgs e)
        {

        }

        private void ekle_ado3_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string strkomut = "insert into ogrenci(ono,adi,soyadi,dyeri,bid) values (@vono,@vadi,@vsoyadi,@vdyeri,@vbid)";

            SqlCommand komutekle = new SqlCommand(strkomut, conn);

            komutekle.Parameters.AddWithValue("@vono", ogrencinotxt.Text);
            komutekle.Parameters.AddWithValue("@vadi", txt_ogrncadi.Text);
            komutekle.Parameters.AddWithValue("@vsoyadi",txt_soyadi.Text);
            komutekle.Parameters.AddWithValue("@vdyeri", txt_dyeri.Text);
            komutekle.Parameters.AddWithValue("@vbid", txtbolid.Text);

            komutekle.ExecuteNonQuery();
            // kayıt ekleme bitti tablodaki son durum gride aktarılıyor

            conn.Close();
            grdtazele();

        }

        private void ekle_adosp3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "spogrenciekle";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@vono", ogrencinotxt.Text);
            cmd.Parameters.AddWithValue("@vadi", txt_ogrncadi.Text);
            cmd.Parameters.AddWithValue("@vsoyadi", txt_soyadi.Text);
            cmd.Parameters.AddWithValue("@vdyeri", txt_dyeri.Text);
            cmd.Parameters.AddWithValue("@vbid", txtbolid.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            grdtazele();


        }

        private void sil_ado3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand komutsil = new SqlCommand();
            komutsil.Connection = conn;

            komutsil.CommandText = "delete from ogrenci where ono=" + Convert.ToInt32(dgogrenci.CurrentRow.Cells[0].Value);
            komutsil.ExecuteNonQuery();
            conn.Close();
            grdtazele();

        }

        private void sil_adosp3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "spogrencisil";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@vono", ogrencinotxt.Text);
            cmd.Parameters.AddWithValue("@vadi", txt_ogrncadi.Text);
            cmd.Parameters.AddWithValue("@vsoyadi", txt_soyadi.Text);
            cmd.Parameters.AddWithValue("@vdyeri", txt_dyeri.Text);
            cmd.Parameters.AddWithValue("@vbid", txtbolid.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            grdtazele();

        }

        private void ara_ado3_Click(object sender, EventArgs e)
        {

        }

        private void guncelle_adosp3_Click(object sender, EventArgs e)
        {

        }

        private void guncelle_ado3_Click(object sender, EventArgs e)
        {

        }

        private void ara_adosp3_Click(object sender, EventArgs e)
        {

        }
    }
}
