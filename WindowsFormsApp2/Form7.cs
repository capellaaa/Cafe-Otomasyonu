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
    public partial class Form7 : Form
    {


        public Form7()
        {
            {
                //oolean izin = false;
                InitializeComponent();

            }
        }

        void windowNewMenu_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void ana_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //yönetici için masa işlemlerini aç
            form2.MdiParent = this;
            form2.Show();

        }

        private void masa_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3(); //yönetici için masa işlemlerini aç
            form3.MdiParent = this;
            form3.Show();


        }

        private void eleman_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4(); //yönetici için masa işlemlerini aç
            form4.MdiParent = this;
            form4.Show();

        }

        private void urun_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); //yönetici için masa işlemlerini aç
            form5.MdiParent = this;
            form5.Show();



        }

        private void Form7_Load(object sender, EventArgs e)
        {


            // mdi parent oluştur 
            this.IsMdiContainer = true;

            //toolstrip contol oluştur 
            ToolStripPanel tspTop = new ToolStripPanel();


            // toolstrip menu nerde olacak
            tspTop.Dock = DockStyle.Top;





            // menustrip oluştur 
            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem windowMenu = new ToolStripMenuItem("Dosya");
            ToolStripMenuItem windowNewMenu = new ToolStripMenuItem("ÇIK", null, new EventHandler(windowNewMenu_Click));

            ToolStripMenuItem yoneticiMenu = new ToolStripMenuItem("Yonetici");
            ToolStripMenuItem eleman = new ToolStripMenuItem("ELEMAN", null, new EventHandler(eleman_Click));
            ToolStripMenuItem urun = new ToolStripMenuItem("ÜRÜN", null, new EventHandler(urun_Click));
            ToolStripMenuItem masa = new ToolStripMenuItem("MASA", null, new EventHandler(masa_Click));

            ToolStripMenuItem ana = new ToolStripMenuItem("MASA DURUMU", null, new EventHandler(ana_Click));




            //childları ekliyoruz 
            windowMenu.DropDownItems.Add(windowNewMenu);
            ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowCheckMargin = true;




            if ((string)label1.Text != "1") //yönetici değilse 
            {

                yoneticiMenu.DropDownItems.Add(ana);

            }
            else
            {

                yoneticiMenu.DropDownItems.Add(eleman);
                yoneticiMenu.DropDownItems.Add(urun);
                yoneticiMenu.DropDownItems.Add(masa);
                yoneticiMenu.DropDownItems.Add(ana);
            }


            // child form listesi
            ms.MdiWindowListItem = windowMenu;
            ms.MdiWindowListItem = yoneticiMenu;

            //main menuler 
            ms.Items.Add(windowMenu);
            ms.Items.Add(yoneticiMenu);


            // formun neresinde 
            ms.Dock = DockStyle.Top;


            this.MainMenuStrip = ms;


            this.Controls.Add(tspTop);

            // Add the MenuStrip last.
            // This is important for correct placement in the z-order.
            this.Controls.Add(ms);

            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}