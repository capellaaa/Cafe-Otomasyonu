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
    public partial class Form6 : Form
    {   int masano=0; //global masa no değişkeni
        public Form6()
        {
            InitializeComponent();
            urun_listele();
        }

        private void Form6_Load(object sender, EventArgs e) //sipariş, ürün, masa ile çalışılacağı için table adapter eklenir
        {
   
            // TODO: Bu kod satırı 'cafeDataSet.siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparisTableAdapter.Fill(this.cafeDataSet.siparis);
            this.masaTableAdapter.Fill(this.cafeDataSet.masa);
            this.urunTableAdapter1.Fill(this.cafeDataSet.urun);

            masano = Convert.ToInt32(label1.Text); //form 2 den gelen masa no yu label1 den masa no değişkenine atar
            tablo_refresh();
          
 

        }
        public void urun_listele()
        {
            string baglanti = "Data Source =LAPTOP-D1QEC82E; Initial Catalog =cafe; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(baglanti);
            conn.Close();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand sorgula = new SqlCommand("SELECT * FROM [urun]", conn); //butun urunleri sec
            SqlDataReader dr = sorgula.ExecuteReader();
           // try
            // {

            ImageList resimListesi = new ImageList(); //urunlerin resimleri
      

                for (int j = 1; j < urunTableAdapter1.urunsayisi(); j++) //urun sayısı kadar doner
            {
            

                if (dr.Read()) //veri tabanından gelen id ve resim yolu alınır
                {
                    int ida = dr.GetInt32(2);
                    string resim_dir = dr.GetString(3);


                    resimListesi.Images.Add("aa", Image.FromFile(resim_dir)); //veri tabanından alınan resim yolunu resim olarak ımage liste ekledik
                    urunTableAdapter1.updateurunresim(image_key:j,id:ida); //masa no ile image_key  i eşleştiriyoruz

                }


            }
            conn.Close();
            resimListesi.ImageSize = new Size(64, 64);
                listView1.LargeImageList = resimListesi;
           // }
            //catch { MessageBox.Show("Kaynaklar yüklenirken Sorun oluştu Program Düzgün görüntelenmeyebilir"); }


            conn.Open();
            SqlCommand sorgulaa = new SqlCommand("SELECT * FROM [urun]", conn);
            SqlDataReader drr = sorgulaa.ExecuteReader();
            string isim = "";
            //int id = 0;
         


            for (int k = 0; k < urunTableAdapter1.urunsayisi(); k++) //urun sayısı kadar döner
            {

                if (drr.Read()) //veri tabanından gelen veri varsa id, ismi, image key aldık
                {

                    //id = drr.GetInt32(2);
                    isim = drr.GetString(0);
                   int imagekey = drr.GetInt32(4);



                    listView1.Items.Insert(k, isim, imagekey); //veri tabanından okunan ismi ve o isme ait imagekey

                }
          

            }
            conn.Close();
        }

        public void tablo_refresh()
        {

            dataGridView1.DataSource = siparisTableAdapter.siparis_detay(masa_no: masano); 
            dataGridView1.Refresh();
            dataGridView1.Update();

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem tiklanan = listView1.SelectedItems[0];
            string urun = tiklanan.Text;
            urun = urun.ToString(); 
            MessageBox.Show(urun); //hangi urune tıklandıysak onu gösterir
        }
    }
}
