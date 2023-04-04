using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriT
{
    internal class KullancıFormu
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=FATMANUR\MSSQLSERVER01;Initial Catalog=Odev1;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        frmSifre yeni = new frmSifre();



        public SqlDataReader kullanıcı(TextBox KullanıcıAdı,TextBox Parola)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from TableHasta where KullanıcıAdı='"+KullanıcıAdı.Text+"'";
            read = komut.ExecuteReader();
            if (read.Read()==true)
            {
                if (Parola.Text == read["Parola"].ToString())
                {
                    MessageBox.Show("Giriş başarılı");
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz","Hata1");
                }
                
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz","Hata2");
            }
            baglanti.Close();
            return read;
        }
        public void Yenikullanıcı(TextBox BolumId, TextBox Ad, TextBox Soyad, TextBox KullanıcıAdı, TextBox parola,TextBox parolaTekrar, TextBox TC, GroupBox grup)
        {
            if(parola.Text==parolaTekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText= "insert into TableHasta(BölümId,Ad,Soyad,KullanıcıAdı,Parola,TCNo) " +
                "values('" + BolumId.Text + "','"+ Ad.Text + "','"+Soyad.Text+"','"+KullanıcıAdı.Text+"','"+parola.Text+"','"+TC.Text+"')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("üye eklendi");
                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";


            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor","Hata");
            }
        }
    }
}
