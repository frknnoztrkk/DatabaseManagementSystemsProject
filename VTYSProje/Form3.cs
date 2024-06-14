using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Markup;

namespace VTYSProje
{
    public partial class Form3 : Form
    {
        string cinsiyet;
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DI1RP56\\MSSQLSERVER1;Initial Catalog=Galeri;Integrated Security=True");
        SqlCommand komut;
        SqlCommand cmd; 
        SqlDataAdapter da;

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Bayan";
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO MÜŞTERİ(isim,soyisim,cinsiyet,telefon) VALUES (@ad,@soyisim,@cinsiyet,@telefon)";
            cmd= new SqlCommand(sql,baglanti);
            cmd.Parameters.AddWithValue("@ad",textBox1.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox2.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@telefon", textBox3.Text);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            

            Form4 gecis = new Form4();
            gecis.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();  
            this.Hide();
        }
    }
}
