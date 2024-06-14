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

namespace VTYSProje
{
    public partial class Form1 : Form

    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-DI1RP56\\MSSQLSERVER1;Initial Catalog=Galeri;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From KULLANICI where kullanıcıAdı='" + textBox1.Text + "'And şifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Başarılı Bir Şekilde Giriş Yaptınız... ");
                Form2 gecis = new Form2();
                gecis.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Lütfen Bilgilerinizi Kontrol Ediniz... ");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 gecis = new Form3();
            gecis.Show();
            this.Hide();
        }
    }
}
