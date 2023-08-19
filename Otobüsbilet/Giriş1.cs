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
    public partial class Giriş1 : Form
    {
        public Giriş1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=Furkanerd\SQLEXPRESS;Initial Catalog=OtobüsRezerv;Integrated Security=True");
        public void biletbul()
        {
            //ÖNEMLİ Bİ KISIM
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLSEFERBİLGİ where KALKIS='"+comboBox1.Text+"'"+"and VARIS='"+comboBox2.Text+"'"+"and TARİH='"+maskedTextBox1.Text+"'",bgl);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Giriş1_Load(object sender, EventArgs e)
        {
            string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Konya", "İstanbul" } ;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(sehirler);
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(sehirler);
            comboBox2.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text;
            label5.Text = comboBox2.Text;
            comboBox2.Text = label4.Text;
            comboBox1.Text=label5.Text;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            biletbul();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblsefer.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            lbltarih.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblsaat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            Giriş2 g2 = new Giriş2();
            g2.seferno = lblsefer.Text;
            g2.tarih = lbltarih.Text;
            g2.saat = lblsaat.Text;
            g2.kalkıs = comboBox1.Text;
            g2.varıs= comboBox2.Text;
            g2.Show();
            this.Hide();
        }
    }
}
