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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeDataSet1.masa' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.masaTableAdapter.Fill(this.cafeDataSet1.masa); 


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                masaTableAdapter.tummasadel(); //tüm masaları sil (delete From masa sorgusu)
            }
            catch {
                MessageBox.Show("Bilinmeyen bir hata oldu!");
            }
            try
            {
                for (int i = 0; i < Convert.ToInt32(sayitext.Text); i++) // textboxdan girilen sayı kadar masa oluştur
                {

                    masaTableAdapter.masainsert(masa_no: i + 1, durum: 0, siparis_id: 0); //boş masa oluşturmuş oldum

                }
            }
            catch
            {

                MessageBox.Show("Bilinmeyen bir hata oldu!");
            }


            MessageBox.Show("İşlem Başarılı,değişiklerin etkili olabilmesi için program yeniden başlatılıyor");
            Application.Restart();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
