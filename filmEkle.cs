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
    public partial class filmEkle : Form
    {
        public filmEkle()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglan = new NpgsqlConnection("Server = localhost; Port=5432;User Id = postgres; Password=Bolu2002*;Database=sinema;");
        private void filmEkle_Load(object sender, EventArgs e)
        {

        }

        public int Listele()
        {
            string sorgu = "select * from \"Film\" "; 
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand ekle = new NpgsqlCommand("insert into \"Film\" (film_adi,film_id) values (@fa,@fi)", baglan);
            ekle.Parameters.AddWithValue("@fa", (textBox3.Text));
            ekle.Parameters.AddWithValue("@fi", int.Parse(textBox1.Text));
            ekle.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Film listeye eklendi","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand silme = new NpgsqlCommand("Delete from \"Film\" where film_id=@fi", baglan);
            silme.Parameters.AddWithValue("@fi", int.Parse(textBox1.Text));
            silme.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Film listeden cikarildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }
}
