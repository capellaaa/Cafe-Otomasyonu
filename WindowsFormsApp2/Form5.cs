using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {

       string form_durum="";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeDataSet.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter.Fill(this.cafeDataSet.urun);
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string id = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                //sadece urun id sini almamız onusilmek için yeterli
            }

            // urun silme işlemi verilen id deki urunu siler 
            urunTableAdapter.deleteurun(id: Convert.ToInt32(id));
        }   catch
            {
                MessageBox.Show("beklenmyen bir hata oluştu.");
            }
            //datagridview i tazeleyelim ki değişikleri kullanıcı görebilsin
            dataGridView1.DataSource = urunTableAdapter.GetData();
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // file dialog aç 
            OpenFileDialog ac = new OpenFileDialog();
            ac.Filter = " JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"; //resmin uzantısını kısıtladık
            ac.ShowDialog();


            string res_dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);//sistemin pictures klasörünü otomatik bulalım 

            // resmi picture konumuna kopyalayalımm 
            string source = ac.FileName.ToString();  //açılan dosyanın tam adı path ile baraber 
            string[] s = (ac.FileName.ToString()).Split('\\'); // dosya ismini pathdan ayıralım ki hedefe yapıştırabilelim 
            int count = s.Length; // parçaladığımız dosya yoılunun uzunluğunu alalım 
            string dosya = s[count - 1]; // dosya isminiş listeyi ters yazarak direk alalım 
            System.IO.File.Copy(source, res_dir + dosya, true); //  dosyayı üstüne yazma modunda kopyala
            textBox3.Text = res_dir + dosya; // dosyanın kopyalanan adını ve yolunu textboca basalım 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string id = "";
            string isim = "";
            string resim = "";
            string fiyat = "";
       

            
            //datagridview de seçili olan satır sonuna kadar dönüp içindeki herşeyi değişkenlere atayalım
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                isim = row.Cells[1].Value.ToString();
                resim = row.Cells[3].Value.ToString();
                fiyat = row.Cells[2].Value.ToString();

            }


            //datagridviewden gelen verileri textboxlara yazarak kullanıcının düzenlemesine izin verelim
            textBox1.Text = isim;
            textBox2.Text = fiyat;
            textBox3.Text = resim;
           
            label5.Text = id;
       

            //formun nerden geldiğinni anlamak için
            form_durum = "guncelle";
            //kullanıcı ne yaptığını bilsin
            button4.Text = "GÜNCELLE";

        }

        private void button4_Click(object sender, EventArgs e)
        {

            // form a veriler datagridviewden gelmişse kişi güncelleme işlemiyapıyoruz
            if (form_durum == "guncelle")
            {

                try { 

                //textboxlardaki verileri veritabanına basalım (id ye göre) 
                urunTableAdapter.updateurun(urun_ismi: textBox1.Text, fiyat: Convert.ToDouble(textBox2.Text), resim: textBox3.Text, gid: Convert.ToInt32(label5.Text));
            }catch
                {
                    MessageBox.Show("beklenmyen bir hata oluştu.");
                }
                //datagridview i tazeleyelim ki değişikleri kullanıcı görebilsin
                dataGridView1.DataSource = urunTableAdapter.GetData();
                dataGridView1.Refresh();
                dataGridView1.Update();
                //formu da temizleyelim
                form_durum = "";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
   
                label5.Text = "";
                button4.Text = "KAYDET";

            }
            else
            //veriler kullannıcı tarafından girilmiştir insert işlemi yapılacak
            {

                try
                {
                    urunTableAdapter.inserturun(urun_ismi: textBox1.Text, fiyat: Convert.ToDouble(textBox2.Text), resim: textBox3.Text);
                }
                catch
                {
                    MessageBox.Show("beklenmyen bir hata oluştu.");
                }


                //datagridview i tazeleyelim ki değişikleri kullanıcı görebilsin
                dataGridView1.DataSource = urunTableAdapter.GetData();
                dataGridView1.Refresh();
                dataGridView1.Update();
                //formu da temizleyelim
                form_durum = "";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
         
                label5.Text = "";
                button4.Text = "KAYDET";

            }
        }

        private void button5_Click(object sender, EventArgs e) //dosyadan veri ekleme kısmı
        {

            OpenFileDialog ac = new OpenFileDialog();
            ac.Filter = " Metin Dosyaları |*.txt";
            ac.ShowDialog();
            string dosya = ac.FileName.ToString();
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@dosya); //burada okuduğu tüm verileri lines adında bir array e atar
                foreach (string line in lines) //butun satırları tutan liste lines la, bütün satırlar line ile gezilir
                {

                    string[] veri = line.Split('&'); //okunan satırdaki verileri split et
                    try
                    {
                        urunTableAdapter.inserturun(urun_ismi: veri[0], fiyat: Convert.ToDouble(veri[1]), resim: veri[2]);
                    }
                    catch
                    {
                        MessageBox.Show(line, "hatalı satır");
                        MessageBox.Show("dosyanın verileri \"&\" ile ayırdığından emin olunuz! Diğer satırlar okunmaya çalışacak..."); 
                    }
                }
            }
            catch
            {

                MessageBox.Show("dosya okunurken hata oluştu.");
            }
            dataGridView1.DataSource = urunTableAdapter.GetData(); //datagrid viewi tekrar günceller
            dataGridView1.Refresh();
            dataGridView1.Update();
            MessageBox.Show("İşlem Tamamlandı");
        }
    }
}
