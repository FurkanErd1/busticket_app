using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobüsbilet
{
    public partial class başlangıç : Form
    {
        public başlangıç()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminpanel ap = new Adminpanel();
            ap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giriş1 gr1 = new Giriş1();
            gr1.Show();
            this.Hide();
        }

        private void başlangıç_Load(object sender, EventArgs e)
        {

        }
    }
}
