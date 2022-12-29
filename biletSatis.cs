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
    public partial class biletSatiscs : Form
    {
        public biletSatiscs()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglan = new NpgsqlConnection("Server = localhost; Port=5432;User Id = postgres; Password=Bolu2002*;Database=sinema;");
        private void biletSatiscs_Load(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select film_adi from \"Film\" ", baglan);
            NpgsqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                comboBox1.Items.Add(read["film_adi"]);
            }
            baglan.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = label1.Text + button1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = label1.Text + button7.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = label1.Text + button14.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = label1.Text + button22.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox2.Text = label1.Text + button29.Text;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            textBox2.Text = label1.Text + button60.Text;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            textBox2.Text = label1.Text + button54.Text;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox2.Text = label1.Text + button48.Text;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox2.Text = label1.Text + button42.Text;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox2.Text = label1.Text + button36.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text + button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text + button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text + button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text + button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text + button8.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text + button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text + button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text + button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text + button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text + button2.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox2.Text = label3.Text + button24.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text = label3.Text + button23.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = label3.Text + button21.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = label3.Text + button20.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = label3.Text + button19.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = label3.Text + button18.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = label3.Text + button17.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = label3.Text + button16.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = label3.Text + button15.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = label3.Text + button13.Text;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox2.Text = label4.Text + button35.Text;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox2.Text = label4.Text + button34.Text;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox2.Text = label4.Text + button33.Text;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox2.Text = label4.Text + button32.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox2.Text = label4.Text + button31.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox2.Text = label4.Text + button30.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox2.Text = label4.Text + button28.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox2.Text = label4.Text + button27.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox2.Text = label4.Text + button26.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox2.Text = label4.Text + button25.Text;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            textBox2.Text = label5.Text + button47.Text;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox2.Text = label5.Text + button46.Text;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBox2.Text = label5.Text + button45.Text;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox2.Text = label5.Text + button44.Text;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox2.Text = label5.Text + button43.Text;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox2.Text = label5.Text + button41.Text;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox2.Text = label5.Text + button40.Text;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox2.Text = label5.Text + button39.Text;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox2.Text = label5.Text + button38.Text;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox2.Text = label5.Text + button37.Text;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text + button59.Text;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text + button58.Text;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text + button57.Text;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text + button56.Text;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text + button55.Text;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text + button53.Text;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text + button52.Text;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text + button51.Text;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text + button50.Text;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text + button49.Text;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "A1")
            {
                button1.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "A2")
            {
                button7.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "A3")
            {
                button14.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "A4")
            {
                button22.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "A5")
            {
                button29.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "A6")
            {
                button60.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "A7")
            {
                button54.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "A8")
            {
                button48.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "A9")
            {
                button42.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "A10")
            {
                button36.BackColor = Color.Red; button1.Enabled = false;
            }

            if (textBox2.Text == "B1")
            {
                button12.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "B2")
            {
                button11.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "B3")
            {
                button10.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "B4")
            {
                button9.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "B5")
            {
                button8.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "B6")
            {
                button6.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "B7")
            {
                button5.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "B8")
            {
                button4.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "B9")
            {
                button3.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "B10")
            {
                button2.BackColor = Color.Red; button1.Enabled = false;
            }

            if (textBox2.Text == "C1")
            {
                button24.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "C2")
            {
                button23.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "C3")
            {
                button21.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "C4")
            {
                button20.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "C5")
            {
                button19.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "C6")
            {
                button18.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "C7")
            {
                button17.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "C8")
            {
                button16.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "C9")
            {
                button15.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "C10")
            {
                button13.BackColor = Color.Red; button1.Enabled = false;
            }

            if (textBox2.Text == "D1")
            {
                button35.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "D2")
            {
                button34.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "D3")
            {
                button33.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "D4")
            {
                button32.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "D5")
            {
                button31.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "D6")
            {
                button30.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "D7")
            {
                button28.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "D8")
            {
                button27.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "D9")
            {
                button26.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "D10")
            {
                button25.BackColor = Color.Red; button1.Enabled = false;
            }

            if (textBox2.Text == "E1")
            {
                button47.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "E2")
            {
                button46.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "E3")
            {
                button45.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "E4")
            {
                button44.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "E5")
            {
                button43.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "E6")
            {
                button41.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "E7")
            {
                button40.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "E8")
            {
                button39.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "E9")
            {
                button38.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "E10")
            {
                button37.BackColor = Color.Red; button1.Enabled = false;
            }

            if (textBox2.Text == "F1")
            {
                button59.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "F2")
            {
                button58.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "F3")
            {
                button57.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "F4")
            {
                button56.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "F5")
            {
                button55.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "F6")
            {
                button53.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "F7")
            {
                button52.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "F8")
            {
                button51.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "F9")
            {
                button50.BackColor = Color.Red; button1.Enabled = false;
            }
            if (textBox2.Text == "F10")
            {
                button49.BackColor = Color.Red; button1.Enabled = false;
            }

            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into \"Bilet\" (bilet_id,koltuk_no) values (@bi,@kn)", baglan);
            komut.Parameters.AddWithValue("@bi", int.Parse(textBox1.Text));
            komut.Parameters.AddWithValue("@kn", (textBox2.Text));
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Bilet satildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }

}
