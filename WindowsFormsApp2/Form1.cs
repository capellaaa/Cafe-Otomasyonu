using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           try
            {
                
                string baglanti = "Data Source =LAPTOP-D1QEC82E; Initial Catalog =cafe; Integrated Security = true;";
                SqlConnection conn = new SqlConnection(baglanti);
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open(); //veri tabani baglantisini actim
                //Kullaniciya ait verileri getir, cek
                SqlCommand sorgula = new SqlCommand("SELECT * FROM [userTable] WHERE username = '" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
                SqlDataReader dr = sorgula.ExecuteReader(); //verrileri oku
          
            if (dr.Read())  //boyle bir sey var mi yok mu ona bakiyor
            {

                   
                    Form2 form2 = new Form2();
                    form2.label1.Text = dr.GetInt32(4).ToString();//2. forma giriş yapanın yetkisini gönderiyoruz 
                    //MessageBox.Show(dr.GetInt32(4).ToString());
                    form2.Show();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                conn.Close(); //veri tabani baglantisini kapattim
          }
           catch { MessageBox.Show("Veritabanı baglantısı kurulamadı veya sorgu çalıştırılamadı."); } //try da sorun varsa bu döner
        }

    }
}
