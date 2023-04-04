using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace veriT
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlDataReader okuyucu;
        SqlCommand komut;


        public Form1()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = textBox1.Text;
            string password= textBox2.Text;
            baglanti = new SqlConnection(@"Data Source=FATMANUR\MSSQLSERVER01;Initial Catalog=Odev1;Integrated Security=True");
            komut = new SqlCommand();
            baglanti.Open();

            komut.Connection = baglanti;
            komut.CommandText = "Select * from TableHasta where KullanıcıAdı='" + textBox1.Text + "'And Parola='" + textBox2.Text + "'";

            okuyucu = komut.ExecuteReader();

            if (okuyucu.Read())
            {
                MessageBox.Show("başarılı giriş");

                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }

            baglanti.Close();
        }

       readonly KullancıFormu k = new KullancıFormu();
        

        private void button2_Click(object sender, EventArgs e)
        {
            k.Yenikullanıcı(BolumIdtxt,Adtxt,Soyadtxt,KullanıcıAdıtxt,parolatxt,parolattxt,tctxt,groupBox2);
        }

















        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
