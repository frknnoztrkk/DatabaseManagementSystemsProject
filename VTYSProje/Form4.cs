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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DI1RP56\\MSSQLSERVER1;Initial Catalog=Galeri;Integrated Security=True");
        SqlCommand komut;
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO KULLANICI(kullanıcıAdı,şifre) VALUES (@kullanıcıAdı,@şifre)";
            cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@kullanıcıAdı", textBox1.Text);
            cmd.Parameters.AddWithValue("@şifre", textBox2.Text);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();

            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }
    }
}
