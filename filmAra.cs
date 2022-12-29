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
    public partial class filmAra : Form
    {
        public filmAra()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("Server = localhost; Port=5432;User Id = postgres; Password=Bolu2002*;Database=sinema;");

       
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            DataTable tablo = new DataTable();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select * from \"Film\" where film_adi like'%" + textBox1.Text + "%'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }

    }
}
