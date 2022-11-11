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
    public partial class dersfrm : Form
    {
        public string constr = "Server=DESKTOP-Q34RTV3;database=db_okul;integrated security=true;";

        public dersfrm()
        {
            InitializeComponent();
        }

        void grdtazele()
        {
            // baglanti stringi oluştur
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string sondurum = "select*from ders order by did desc";
            SqlDataAdapter sdp = new SqlDataAdapter(sondurum, conn);
            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgders.DataSource = dt;
            conn.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            grdtazele();
        }

        private void ekle_ado2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string strkomut = "insert into ders (dadi,dkodu,kredi,bid) values (@vdadi,@vdkodu,@vkredi,@vbid)";

            SqlCommand komutekle = new SqlCommand(strkomut, conn);

            komutekle.Parameters.AddWithValue("@vdadi", txt_adi.Text);
            komutekle.Parameters.AddWithValue("@vdkodu", txt_kodu.Text);
            komutekle.Parameters.AddWithValue("@vkredi", nmrc_kredi.Value);
            komutekle.Parameters.AddWithValue("@vbid", txtbolid.Text);  




            komutekle.ExecuteNonQuery();
            // kayıt ekleme bitti tablodaki son durum gride aktarılıyor

            conn.Close();
            grdtazele();
        }

        private void ekle_adosp2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "spdersekle";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@vdid", txt_did.Text);
            cmd.Parameters.AddWithValue("@vdadi", txt_adi.Text);
            cmd.Parameters.AddWithValue("@vkredi", nmrc_kredi.Value);
            cmd.Parameters.AddWithValue("@vdkodu", txt_kodu.Text);
            cmd.Parameters.AddWithValue("@vbid", txtbolid.Text);

            cmd.ExecuteNonQuery();

            conn.Close();
            grdtazele();



        }

        private void sil_ado2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand komutsil = new SqlCommand();
            komutsil.Connection = conn;
            komutsil.CommandText = "delete from ders where did=" + Convert.ToInt32(dgders.CurrentRow.Cells[0].Value);
            komutsil.ExecuteNonQuery();
            conn.Close();
            grdtazele();

        }

        private void sil_adosp2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand cnd = new SqlCommand();
            cnd.Connection = conn;

            cnd.CommandText = "spderssil";
            cnd.CommandType = CommandType.StoredProcedure;

            cnd.Parameters.AddWithValue("@vdid", txt_did.Text);
            cnd.Parameters.AddWithValue("@vdadi", txt_adi.Text);
            cnd.Parameters.AddWithValue("@vkredi", nmrc_kredi.Value);
            cnd.Parameters.AddWithValue("@vdkodu", txt_kodu.Text);
            cnd.Parameters.AddWithValue("@vbid", txtbolid.Text);

            cnd.ExecuteNonQuery();
            conn.Close();
            grdtazele();


        }

        private void ara_ado2_Click(object sender, EventArgs e)
        {

        }

        private void enty_ekle_Click(object sender, EventArgs e)
        {

        }

        private void guncelle_ado2_Click(object sender, EventArgs e)
        {

        }

        private void guncelle_adosp2_Click(object sender, EventArgs e)
        {

        }

        private void ara_adosp2_Click(object sender, EventArgs e)
        {

        }
    }
}
