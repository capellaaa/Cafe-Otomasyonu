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
    public partial class Form4 : Form
    {

        string form_durum = ""; //form da güncelleme işlemi yapacağımız değişken
        public Form4()
        {
            InitializeComponent();
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeDataSet.userTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.userTableTableAdapter.Fill(this.cafeDataSet.userTable);
            textBox2.Text = DateTime.Now.ToString("yyyy/MM/dd");
            dateTimePicker1.Format = DateTimePickerFormat.Custom; //dateTimePicker1 Format değiştirme
            dateTimePicker1.CustomFormat = "yyyy/MM/dd"; //bu biçimde yazmamızı sağlıyor
            label5.Visible = false; //güncelleme işleminin kullanıcıya gösterilmesini engellemek için

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = ""; //kişinin id sini tutmak için değişken
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) // datagridview in içerisinde seçili satırdaki butun verileri gezer  
            {
               id = row.Cells[0].Value.ToString();
                //sadece kişi id sini almamız onu silmek için yeterli
               
            }
            

            // kullanıcı silme işlemi verilen id deki kullanıcıyı siler 
            userTableTableAdapter.deleteuser(id:Convert.ToInt32(id));
            //datagridview i tazeleyelim ki değişikleri kullanıcı görebilsin
            dataGridView1.DataSource= userTableTableAdapter.GetData(); //veri tabanındaki verileri tekrar alır
            dataGridView1.Refresh(); //yenileme
            dataGridView1.Update();

        }

        private void button3_Click(object sender, EventArgs e) //datagrdview den seçilen satırın textbox lara aktarılması
        {
            string id = "";
            string isim = "";
            string username= "";
            string password = "";
            string b_tar = "";
            string yetki = "";
            //datagridview de seçili olan satır sonuna kadar dönüp içindeki her şeyi değişkenlere atadım
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) 
            {
                id = row.Cells[0].Value.ToString();
                isim = row.Cells[3].Value.ToString();
                username = row.Cells[1].Value.ToString();
                password = row.Cells[2].Value.ToString();
                b_tar = row.Cells[4].Value.ToString();
                yetki = row.Cells[5].Value.ToString();
             
            }

           
            //datagridviewden gelen verileri textboxlara yazarak kullanıcının düzenlemesine izin verdim
            textBox1.Text = isim;
            textBox2.Text = b_tar;
            textBox3.Text = username;
            textBox4.Text = password;
            textBox2.Text = b_tar;
            label5.Text = id;
            //textbox da kişi yetkili ise checked olsun
            if (yetki == "1")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            //formun nerden geldiğini anlamak için
            form_durum = "guncelle";
            //kullanıcı ne yaptığını bilsin
            button1.Text = "GÜNCELLE";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         //  datetime picker üzerinde değişiklik yapılırsa textboxa da yansısın 
            textBox2.Text = dateTimePicker1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //checkbox ı kontrol edelim yetki kullanıcı tarafından değiştirilmişse atama yaptık
            int cyetki = 0;
            if (checkBox1.Checked)
            {

                cyetki = 1;

            }
            else
            {

                cyetki = 0;
            }

            // form a veriler datagridviewden gelmişse kişi güncelleme işlemi yapıyoruz
            if (form_durum=="guncelle")
            {
       

                //textboxlardaki verileri veritabanına bastım (id ye göre) 
                userTableTableAdapter.updateuser(userName: textBox3.Text, password: textBox4.Text, isim: textBox1.Text, iseBaslangicTarihi: textBox2.Text, yetki:cyetki, gid: Convert.ToInt32(label5.Text));

                //datagridview i güncelleyeyim ki değişikleri kullanıcı görebilsin
                dataGridView1.DataSource = userTableTableAdapter.GetData();
                dataGridView1.Refresh();
                dataGridView1.Update();
                //formu da temizleyelim
                form_durum = "";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                label5.Text = "";
                button1.Text = "KAYDET"; //yeni kişi eklemek için butonu tekrar kaydet butonu yaptık

            }
            else
            //veriler kullanıcı tarafından girilmiştir insert işlemi yapılacak yani yeni bir kişi oluşturmuş oluyoruz
            {


                userTableTableAdapter.insertuser(userName: textBox3.Text, password: textBox4.Text, isim: textBox1.Text, iseBaslangicTarihi: textBox2.Text, yetki: cyetki);



                //datagridview i güncelliyeyim ki değişikleri kullanıcı görebilsin.
                dataGridView1.DataSource = userTableTableAdapter.GetData();
                dataGridView1.Refresh();
                dataGridView1.Update();
                //formu da temizledim
                form_durum = "";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                label5.Text = "";
                button1.Text = "KAYDET";

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
