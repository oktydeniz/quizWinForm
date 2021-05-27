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

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-7RQ7VJ29\SQLEXPRESS;Initial Catalog=bilgi;Integrated Security=True");
        int soru = 0;
        int dogru=0, yanlis=0, puan = 0,time=10;

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button4.Text == label3.Text)
            {
                puan += 10;
                label9.Text = puan.ToString();
                button4.BackColor = Color.Green;
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
                button4.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button3.Text == label3.Text)
            {
                puan += 10;
                label9.Text = puan.ToString();
                button3.BackColor = Color.Green;
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
                button3.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1 ;
            label11.Text = time.ToString();
            if (time == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Oyun Bitti !");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text="";
                textBox1.Clear();
                label2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button2.Text == label3.Text)
            {
                puan += 10;
                label9.Text = puan.ToString();
                button2.BackColor = Color.Green;
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
                button2.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            soru++;
            label2.Text = soru.ToString();
            label11.Text = time.ToString();
            time = 10;
            connection.Open();
            SqlCommand command = new SqlCommand("select * from sorular order by NEWId()", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                button1.Text = reader["a"].ToString();
                button4.Text = reader["b"].ToString();
                button3.Text = reader["c"].ToString();
                button2.Text = reader["d"].ToString();
                textBox1.Text = reader["soru"].ToString();
                label3.Text = reader["cevap"].ToString();
            }
            connection.Close();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button1.Text == label3.Text)
            {
                puan += 10;
                label9.Text = puan.ToString();
                button1.BackColor = Color.Green;
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
                button1.BackColor = Color.Red;
            }
        }
    }
}
