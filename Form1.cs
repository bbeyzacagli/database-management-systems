using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtys
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglan = new NpgsqlConnection("Server = localhost; Port=5432;User Id = postgres; Password=Bolu2002*;Database=sinema;");

        private void button1_Click_1(object sender, EventArgs e)
        {
            filmAra ara = new filmAra();
            ara.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            filmEkle ekle = new filmEkle();
            ekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            biletSatiscs sat = new biletSatiscs();
            sat.Show();
        }
    }
}
