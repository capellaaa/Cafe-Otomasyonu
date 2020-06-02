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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            masa_olustur();
        }

        public void masa_olustur()


        {
            try
            {
                ImageList resimListesi = new ImageList();
                resimListesi.Images.Add("bos", Image.FromFile("bos.png"));
                resimListesi.Images.Add("dolu", Image.FromFile("dolu.png"));
                resimListesi.ImageSize = new Size(128, 128);
                listView1.LargeImageList = resimListesi; //listview in resim listesini resimListesine esitledik
            }
            catch { MessageBox.Show("Kaynaklar yüklenirken Sorun oluştu Program Düzgün görüntelenmeyebilir"); }


            for (int i = 0; i <= masaTableAdapter.masasayisi(); i++) //count sql sorgusunu çekerek masa sayısı kadar yeni masa oluşturduk  SELECT COUNT(*) FROM masa  sorgusu ile çalıştırdık 
            {

                string baglanti = "Data Source =LAPTOP-D1QEC82E; Initial Catalog =cafe; Integrated Security = true;";
                SqlConnection conn = new SqlConnection(baglanti);
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand sorgula = new SqlCommand("SELECT * FROM [masa] WHERE masa_no = '" + (i+1) + "' ", conn); //masa numarasına göre bilgi çekme 
                SqlDataReader dr = sorgula.ExecuteReader();

                if (dr.Read())
                {
                                                          
                   int durum = dr.GetInt32(1); //masanın dolu mu bos mu oldugu
                    listView1.Items.Insert(i, (i+1).ToString(), durum); //listenin i. elemanına i yi 1 artırarak masa no oluşturduk masanın durumuna före resim atar
                    


                }
                conn.Close(); 

            }


           


            

        }
  

        private void listView1_DoubleClick(object sender, EventArgs e) //masaya iki kez tıklama
        
        {
            ListViewItem tiklanan = listView1.SelectedItems[0]; //secilen masayı degişkene atıyoruz
                string masano = tiklanan.Text; //masa no atandı
                masano = masano.ToString();

            
            Form6 form6 = new Form6(); //masa no bilmemiz için
            form6.label1.Text = masano;
            form6.Show();
            //listView1.Clear();
            //masa_olustur();
        }

        private void çIKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uygulamayı tamamen kapat
            Application.Exit();

        }

        private void masaToolStripMenuItem_Click(object sender, EventArgs e)

        {
            Form3 form3 = new Form3(); //yönetici için masa işlemlerini aç
            form3.Show();
        }

        private void elemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); //eleman ekleme çıkarma silme
            form4.Show();
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); //urun ekle çıkarma silme
            form5.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if ((string)label1.Text != "1") //yönetici değilse 
            {
                //MessageBox.Show(label1.Text);
                this.masaTableAdapter.Fill(this.cafeDataSet.masa);
                yönetimToolStripMenuItem.Enabled = false; //yetki 1 değilse yönetim yetkisini kapatır
            
            }
        
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text=DateTime.Now.ToLongTimeString();

        }
    }
}
