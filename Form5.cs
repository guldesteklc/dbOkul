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
    public partial class ogrtmnfrm : Form
    {
        public string constr = "Server=DESKTOP-Q34RTV3;Database=db_okul;integrated security=true;";

        public ogrtmnfrm()
        {
            InitializeComponent();
        }

        void grdtazele()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string sondurum = "select*from ogretmen order by oid desc";
            SqlDataAdapter sdp = new SqlDataAdapter(sondurum,conn);
            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgogretmen.DataSource = dt;
            conn.Close();


        }

        private void ekle_ado4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            string strkomut = " insert into ogretmen (oid,adi,soyadi,dyeri,bid) values (@void,@vadi,@vsoyadi,@vdyeri,@vbid) ";

            SqlCommand komutekle = new SqlCommand(strkomut,conn);

            komutekle.Parameters.AddWithValue("@void", txtogretmnıd.Text);
            komutekle.Parameters.AddWithValue("@vadi", txtogrtadi.Text);
            komutekle.Parameters.AddWithValue("@vsoyadi", txtogrtsoyadi.Text);
            komutekle.Parameters.AddWithValue("@vdyeri", txtdyeri.Text);
            komutekle.Parameters.AddWithValue("@vbid", txtbolid.Text);

            komutekle.ExecuteNonQuery();

            conn.Close();
            grdtazele();
        }

        private void ekle_adosp4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "spogretmenekle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@void", txtogretmnıd.Text);
            cmd.Parameters.AddWithValue("@vadi", txtogrtadi.Text);
            cmd.Parameters.AddWithValue("@vsoyadi", txtogrtsoyadi.Text);
            cmd.Parameters.AddWithValue("@vdyeri", txtdyeri.Text);
            cmd.Parameters.AddWithValue("@vbid", txtbolid.Text);

            cmd.ExecuteNonQuery();

            conn.Close();
            grdtazele();

        }

        private void sil_ado4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand komutsil = new SqlCommand();
            komutsil.Connection = conn;
            komutsil.CommandText= "delete from ogretmen where oid=" + Convert.ToInt32(dgogretmen.CurrentRow.Cells[0].Value);


        }

        private void ogrtmnfrm_Load(object sender, EventArgs e)
        {
            grdtazele();

        }

        private void ara_ado4_Click(object sender, EventArgs e)
        {

        }

        private void sil_adosp4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "spogretmensil";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@void", txtogretmnıd.Text);
            cmd.Parameters.AddWithValue("@vadi", txtogrtadi.Text);
            cmd.Parameters.AddWithValue("@vsoyadi", txtogrtsoyadi.Text);
            cmd.Parameters.AddWithValue("@vdyeri", txtdyeri.Text);
            cmd.Parameters.AddWithValue("@vbid", txtbolid.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            grdtazele();
        }
    }
}
