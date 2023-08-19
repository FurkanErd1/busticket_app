using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otobüsbilet
{
    public partial class Adminpanel : Form
    {
        public Adminpanel()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=Furkanerd\SQLEXPRESS;Initial Catalog=OtobüsRezerv;Integrated Security=True");
        public void seferekleme()
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("insert into TBLSEFERBİLGİ (SEFERNO,KALKIS,VARIS,TARİH,SAAT,FİYAT) values (@Q1,@P1,@P2,@P3,@P4,@P5)", bgl);
            kmt.Parameters.AddWithValue("@Q1", maskedTextBox1.Text);
            kmt.Parameters.AddWithValue("@P1", textBox1.Text);
            kmt.Parameters.AddWithValue("@P2", textBox2.Text);
            kmt.Parameters.AddWithValue("@P3", maskedTextBox2.Text);
            kmt.Parameters.AddWithValue("@P4", maskedTextBox3.Text);
            kmt.Parameters.AddWithValue("@P5", textBox3.Text);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Sefer Eklendi","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.Close();

        }
        public void seferdüzenle()
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("update TBLSEFERBİLGİ set KALKIS=@P1,VARIS=@P2,TARİH=@P3,SAAT=@P4,FİYAT=@P5 where SEFERNO=@P6",bgl);
            kmt.Parameters.AddWithValue("@P6", maskedTextBox6.Text);
            kmt.Parameters.AddWithValue("@P1", textBox6.Text);
            kmt.Parameters.AddWithValue("@P2", textBox5.Text);
            kmt.Parameters.AddWithValue("@P3", maskedTextBox5.Text);
            kmt.Parameters.AddWithValue("@P4", maskedTextBox4.Text);
            kmt.Parameters.AddWithValue("@P5", textBox4.Text);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Sefer güncellendi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.Close() ;
        }
       
        private void Adminpanel_Load(object sender, EventArgs e)
        {
            //DATAGRİD VİEWE SEFER BİLGİLREİNİ ÇEKME
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLSEFERBİLGİ", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //DATAGRİDVİEW YOLCU
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from TBLYOLCU", bgl);
            DataTable dt2 = new DataTable();
            da1.Fill(dt2);
            dataGridView2.DataSource = dt2;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            Random rnd = new Random();
            sayi = rnd.Next(0, 1000000000);
            maskedTextBox1.Text = sayi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seferekleme();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            //DATAGRİD VİEWE SEFER BİLGİLREİNİ ÇEKME
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLSEFERBİLGİ", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            seferdüzenle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            maskedTextBox6.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox6.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox5.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox5.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            maskedTextBox4.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox4.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}
