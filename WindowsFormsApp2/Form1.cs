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
                //Kullaniciya ait verileri getir
                SqlCommand sorgula = new SqlCommand("SELECT * FROM [userTable] WHERE username = '" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
                SqlDataReader dr = sorgula.ExecuteReader(); //verileri oku
          
            if (dr.Read())  //boyle bir sey var mi yok mu ona bakiyor
            {
                    userTableTableAdapter1.hatirla(hatirla1: checkBox1.Checked,id : dr.GetInt32(4));
                    Form7 form7 = new Form7();
                    form7.label1.Text = dr.GetInt32(5).ToString();//2. forma giriş yapanın yetkisini gönderiyoruz 
                    //MessageBox.Show(dr.GetInt32(5).ToString());
                    form7.Text = "18010011021-Esra-DEMİR";
                    Form1.ActiveForm.Visible = false;
                    form7.Show();


                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                conn.Close(); //veri tabani baglantisini kapattim
          }
           catch { MessageBox.Show("Veritabanı baglantısı kurulamadı veya sorgu çalıştırılamadı."); } //try da sorun varsa bu döner
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            try
            {
                string baglanti = "Data Source =LAPTOP-D1QEC82E; Initial Catalog =cafe; Integrated Security = true;";
                SqlConnection conn = new SqlConnection(baglanti);
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open(); //veri tabani baglantisini actim
                //Kullaniciya ait verileri getir
                SqlCommand sorgula = new SqlCommand("SELECT * FROM [userTable] WHERE hatirla = 1", conn);
                SqlDataReader dr = sorgula.ExecuteReader(); //verileri oku

                if (dr.Read())  //boyle bir sey var mi yok mu ona bakiyor
                {
                    textBox1.Text = dr.GetString(0);
                    textBox2.Text = dr.GetString(1);
                    checkBox1.Checked = true;
                }
                
    
                else
                {
                    checkBox1.Checked = false;
                }
                conn.Close(); //veri tabani baglantisini kapattim
            }
            catch { MessageBox.Show("Veritabanı baglantısı kurulamadı veya sorgu çalıştırılamadı."); } //try da sorun varsa bu döner
        }

    }
}
