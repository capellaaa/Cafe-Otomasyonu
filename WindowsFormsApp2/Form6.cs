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
    {
        int masano = 0;
        string hesap_top ="";
        string urun_urun = "";
        string urun_fiyat = "";

        public Form6()
        {
            InitializeComponent();
            urun_listele();
        }
        int sayi = 0;
 
        private void Form6_Load(object sender, EventArgs e)
        {

            // TODO: Bu kod satırı 'cafeDataSet.siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparisTableAdapter.Fill(this.cafeDataSet.siparis);
            this.masaTableAdapter.Fill(this.cafeDataSet.masa);
            this.urunTableAdapter1.Fill(this.cafeDataSet.urun);

            masano = Convert.ToInt32(label1.Text);
            tablo_refresh();
        }
        public void urun_listele()
        {
            try
            {
                string baglanti = "Data Source =LAPTOP-D1QEC82E; Initial Catalog =cafe; Integrated Security = true;";
                SqlConnection conn = new SqlConnection(baglanti);
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand sorgula = new SqlCommand("SELECT * FROM [urun]", conn);
                SqlDataReader dr = sorgula.ExecuteReader();
                try
                {

                    ImageList resimListesi = new ImageList();


                    for (int j = 0; j < urunTableAdapter1.urunsayisi(); j++)
                    {


                        if (dr.Read())
                        {
                            int ida = dr.GetInt32(2);
                            string resim_dir = dr.GetString(3);


                            resimListesi.Images.Add(j.ToString(), Image.FromFile(resim_dir));
                            urunTableAdapter1.updateurunresim(image_key: j, id: ida);

                        }
                    }
                    conn.Close();
                    resimListesi.ImageSize = new Size(64, 64);
                    listView1.LargeImageList = resimListesi;
                }
                catch { MessageBox.Show("Kaynaklar yüklenirken Sorun oluştu Program Düzgün görüntelenmeyebilir"); }


                conn.Open();
                SqlCommand sorgulaa = new SqlCommand("SELECT * FROM [urun]", conn);
                SqlDataReader drr = sorgulaa.ExecuteReader();
                string isim = "";


                for (int k = 0; k < urunTableAdapter1.urunsayisi(); k++)
                {

                    if (drr.Read())
                    {

                        Double fiyat = drr.GetDouble(1);
                        isim = drr.GetString(0);
                        int imageq = drr.GetInt32(4);

                        listView1.Items.Insert(k, isim + "~" + fiyat, imageq);

                    }

                }
                conn.Close();
            }
            catch
            {

                MessageBox.Show("ürün kaynaklarını kontrol edin!");

            }
        }

        public void tablo_refresh()
        {

            dataGridView1.DataSource = siparisTableAdapter.siparis_detay(masa_no: masano);
            dataGridView1.Refresh();
            dataGridView1.Update();

            // toplam fiyat güncelle (select sum(total_fiyat) from siparis where masano = @masano )
            label4.Text = "Toplam Hesap" + Convert.ToString(siparisTableAdapter.hesap_toplam(masano: masano));
            hesap_top = Convert.ToString(siparisTableAdapter.hesap_toplam(masano: masano));

        }


        private void button4_Click(object sender, EventArgs e)
        {
            siparisTableAdapter.DeleteHesap(masa_no: masano);
            tablo_refresh();
            masaTableAdapter.masadurumupdate(durum:0, masa_no: masano);
            Form6.ActiveForm.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem tiklanan = listView1.SelectedItems[0];
            string urun = tiklanan.Text;
            urun = urun.ToString();


            String[] urundetay = urun.Split('~');// su~1.5 şeklindeki yazımı su ve 1.5 ayıran kısım 
            urun_urun = urundetay[0];   //ürünün ismi
            urun_fiyat = urundetay[1];  // ürünün fiyatı


        }

        private void button1_Click(object sender, EventArgs e)

        {

            urun_fiyat = Convert.ToString(Convert.ToDouble(urun_fiyat) * Convert.ToInt32(textBox1.Text));//ürün toplam fiyatını textbo0xdaki veri ve split ediilen veri ile çarpıyoruz 

            //masa numarasına göre sipariş insert
            siparisTableAdapter.siparisinsert(urun: urun_urun, total_fiyat: Convert.ToDouble(urun_fiyat), adet: Convert.ToInt32(textBox1.Text), masa_no: masano);


            //değişiklikleri görebilelelim 
            tablo_refresh();



        }
        private void button1_Click_1(object sender, EventArgs e)

        {
            try
            {
                urun_fiyat = Convert.ToString(Convert.ToDouble(urun_fiyat) * Convert.ToInt32(textBox1.Text));//ürün toplam fiyatını textbo0xdaki veri ve split ediilen veri ile çarpıyoruz 
                //masa numarasına göre sipariş insert
                siparisTableAdapter.siparisinsert(urun: urun_urun, total_fiyat: Convert.ToDouble(urun_fiyat), adet: Convert.ToInt32(textBox1.Text), masa_no: masano);
                urun_fiyat = Convert.ToString(Convert.ToDouble(urun_fiyat) * Convert.ToInt32(textBox1.Text));//ürün toplam fiyatını textboxdaki veri ve split edilen veri ile çarpıyoruz 

            }
            catch
            {
                MessageBox.Show("Beklenmeyen İşlem!"); 
            }
            tablo_refresh();
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    id = row.Cells[3].Value.ToString();
                    //sadece urun id sini almamız onusilmek için yeterli
                }

                // siparis silme işlemi verilen id deki urunu siler 
                siparisTableAdapter.DeleteSiparis(id: Convert.ToInt32(id));
            }
            catch
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu!");
            }
           
            tablo_refresh();
            Form2 form2 = new Form2();
            form2.masa_Guncelle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                gecmisTableAdapter1.InsertGecmis(masa_no: masano, total_fiyat: Convert.ToDouble(hesap_top), tarih: DateTime.Now.ToString());
                siparisTableAdapter.DeleteHesap(masa_no: masano);
                tablo_refresh();
                masaTableAdapter.masadurumupdate(durum: 0, masa_no: masano);
                Form6.ActiveForm.Close();

            }
            catch
            {
                MessageBox.Show("Beklenmeyen Hata Oluştu!");
            }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text = "1";
            sayi = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + "1";


        }

        private void button6_Click(object sender, EventArgs e)
        {
         
            textBox1.Text = textBox1.Text + "2";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           
        }
    }
}
