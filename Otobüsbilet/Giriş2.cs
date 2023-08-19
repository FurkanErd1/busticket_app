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
    public partial class Giriş2 : Form
    {
        public Giriş2()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=Furkanerd\SQLEXPRESS;Initial Catalog=OtobüsRezerv;Integrated Security=True");
        public string seferno;
        public string kalkıs;
        public string varıs;
        public string tarih;
        public string saat;
        string koltuk;
        string cinsiyet;
        string cinsiyettt;
        public void cinsiyett(Button id)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Cinsiyetisiniz Erkek ise = EVET, Kadın ise = HAYIR Seçiniz !!", "CİNSİYET", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                id.BackColor = Color.Blue;
                cinsiyet = "Erkek";
            }
            if (dr == DialogResult.No)
            {
                id.BackColor = Color.Red;
                cinsiyet = "Kadın";
            }
        }
        public void Dolubos(Button id, string koltuk)
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("Select KOLTUK,Cinsiyett from TBLYOLCULUK where SEFERNO=@P1", bgl);
            kmt.Parameters.AddWithValue("@P1",lblseferno.Text);
            SqlDataReader rdr = kmt.ExecuteReader();
             while (rdr.Read())
            {
                cinsiyettt = rdr[1].ToString();
                if (koltuk == rdr[0].ToString())
                {
                    if (cinsiyettt == "Erkek")
                    {
                        id.BackColor = Color.Blue;
                        id.Enabled = false;
                    }
                    if (cinsiyettt == "Kadın")
                    {
                        id.BackColor = Color.Red;
                        id.Enabled = false;
                    }
                    
                    
                }
            }
            bgl.Close();

        }
        private void Giriş2_Load(object sender, EventArgs e)
        {
            //Bilgileri getirme
            lblseferno.Text = seferno;
            lblkalkıs.Text = kalkıs;
            lblvarıs.Text = varıs;
            lbltarih.Text = tarih;
            lblzaman.Text = saat;
            //Dolubos icin
            Dolubos(btn1, "1");
            Dolubos(btn2, "2");
            Dolubos(btn3, "3");
            Dolubos(btn4, "4");
            Dolubos(btn5, "5");
            Dolubos(btn6, "6");
            Dolubos(btn7, "7");
            Dolubos(btn8, "8");
            Dolubos(btn9, "9");
            Dolubos(btn10, "10");
            Dolubos(btn11, "11");
            Dolubos(btn12,"12");
            Dolubos(btn13, "13");
            Dolubos(btn14, "14");
            Dolubos(btn15, "15");
            Dolubos(btn16, "16");
            Dolubos(btn17, "17");
            Dolubos(btn18, "18");
            Dolubos(btn19, "19");
            Dolubos(btn20, "20");
            Dolubos(btn21, "21");
            Dolubos(btn22, "22");
            

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn1.Text;
            cinsiyett(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn2.Text;
            cinsiyett(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn3.Text;
            cinsiyett(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn4.Text;
            cinsiyett(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn5.Text;
            cinsiyett(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn6.Text;
            cinsiyett(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn7.Text;
            cinsiyett(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn8.Text;
            cinsiyett(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn9.Text;
            cinsiyett(btn9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn10.Text;
            cinsiyett(btn10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn11.Text;
            cinsiyett(btn11);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn12.Text;
            cinsiyett(btn12);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn13.Text;
            cinsiyett(btn13);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn14.Text;
            cinsiyett(btn14);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn15.Text;
            cinsiyett(btn15);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn16.Text;
            cinsiyett(btn16);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn17.Text;
            cinsiyett(btn17);
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn18.Text;
            cinsiyett(btn18);
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn19.Text;
            cinsiyett(btn19);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn20.Text;
            cinsiyett(btn20);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn21.Text;
            cinsiyett(btn21);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            lblkoltuk.Text = btn22.Text;
            cinsiyett(btn22);
        }

        private void btnrezerveet_Click(object sender, EventArgs e)
        {
             bgl.Open();
            SqlCommand kmt1 = new SqlCommand("insert into TBLYOLCULUK (SEFERNO,YOLCUTC,KOLTUK,Cinsiyett) values (@Q1,@Q2,@Q3,@Q4)",bgl);
            kmt1.Parameters.AddWithValue("@Q1", seferno);
            kmt1.Parameters.AddWithValue("@Q2", msktc.Text);
            kmt1.Parameters.AddWithValue("@Q3", lblkoltuk.Text);
            kmt1.Parameters.AddWithValue("@Q4", cinsiyet);
            kmt1.ExecuteNonQuery();
            bgl.Close();

            bgl.Open();
            SqlCommand kmt = new SqlCommand("insert into TBLYOLCU (ADSOYAD,SEFERNO,TC,TELEFON,MAİL,CİNSİYET) values (@P1,@P2,@P3,@P4,@P5,@P6)", bgl);
            kmt.Parameters.AddWithValue("@P1", txtadsoyad.Text);
            kmt.Parameters.AddWithValue("@P2", seferno);
            kmt.Parameters.AddWithValue("@P3", msktc.Text);
            kmt.Parameters.AddWithValue("@P4", msktel.Text);
            kmt.Parameters.AddWithValue("@P5", txtmail.Text);
            kmt.Parameters.AddWithValue("@P6", cinsiyet);
            kmt.ExecuteNonQuery();
            bgl.Close();
            DialogResult dr1 = new DialogResult();
            dr1 = MessageBox.Show("Rezerve edilmiştir lütfen belirtilen tarih ve saatte " + kalkıs + " otogarında olunuz !!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr1 == DialogResult.OK)
            {
                başlangıç b = new başlangıç();
                b.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          MessageBox.Show("Tüm boş alanların doldurulması gerekmektedir aksi takdirde rezerv işlemi geçersiz sayılacaktır !!","UYARI",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
