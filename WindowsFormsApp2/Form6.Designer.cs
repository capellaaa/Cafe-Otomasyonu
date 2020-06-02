namespace WindowsFormsApp2
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.siparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new WindowsFormsApp2.cafeDataSet();
            this.siparisTableAdapter = new WindowsFormsApp2.cafeDataSetTableAdapters.siparisTableAdapter();
            this.masaTableAdapter = new WindowsFormsApp2.cafeDataSetTableAdapters.masaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet1 = new WindowsFormsApp2.cafeDataSet();
            this.siparisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter1 = new WindowsFormsApp2.cafeDataSetTableAdapters.urunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(731, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 85);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 84);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 77);
            this.button3.TabIndex = 5;
            this.button3.Text = "Hesabı Kapat";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 494);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 77);
            this.button4.TabIndex = 6;
            this.button4.Text = "Hesap İptal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "adet";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(569, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(463, 370);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(793, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 37);
            this.button5.TabIndex = 9;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(845, 434);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 37);
            this.button6.TabIndex = 10;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(897, 434);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 37);
            this.button7.TabIndex = 11;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(793, 477);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 37);
            this.button8.TabIndex = 12;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(845, 477);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 37);
            this.button9.TabIndex = 13;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(897, 477);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 37);
            this.button10.TabIndex = 14;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(793, 520);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 37);
            this.button11.TabIndex = 15;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(845, 520);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 37);
            this.button12.TabIndex = 16;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(897, 520);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(46, 37);
            this.button13.TabIndex = 17;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(793, 563);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(98, 38);
            this.button14.TabIndex = 18;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button15.Location = new System.Drawing.Point(897, 563);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(46, 38);
            this.button15.TabIndex = 19;
            this.button15.Text = "<---";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // siparisBindingSource
            // 
            this.siparisBindingSource.DataMember = "siparis";
            this.siparisBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisTableAdapter
            // 
            this.siparisTableAdapter.ClearBeforeFill = true;
            // 
            // masaTableAdapter
            // 
            this.masaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunDataGridViewTextBoxColumn,
            this.totalfiyatDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.id});
            this.dataGridView1.DataSource = this.siparisBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(367, 325);
            this.dataGridView1.TabIndex = 20;
            // 
            // urunDataGridViewTextBoxColumn
            // 
            this.urunDataGridViewTextBoxColumn.DataPropertyName = "urun";
            this.urunDataGridViewTextBoxColumn.HeaderText = "urun";
            this.urunDataGridViewTextBoxColumn.Name = "urunDataGridViewTextBoxColumn";
            this.urunDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalfiyatDataGridViewTextBoxColumn
            // 
            this.totalfiyatDataGridViewTextBoxColumn.DataPropertyName = "total_fiyat";
            this.totalfiyatDataGridViewTextBoxColumn.HeaderText = "total_fiyat";
            this.totalfiyatDataGridViewTextBoxColumn.Name = "totalfiyatDataGridViewTextBoxColumn";
            this.totalfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // siparisBindingSource2
            // 
            this.siparisBindingSource2.DataMember = "siparis";
            this.siparisBindingSource2.DataSource = this.cafeDataSet1;
            // 
            // cafeDataSet1
            // 
            this.cafeDataSet1.DataSetName = "cafeDataSet";
            this.cafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisBindingSource1
            // 
            this.siparisBindingSource1.DataMember = "siparis";
            this.siparisBindingSource1.DataSource = this.cafeDataSet1;
            // 
            // urunTableAdapter1
            // 
            this.urunTableAdapter1.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private cafeDataSetTableAdapters.siparisTableAdapter siparisTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        public System.Windows.Forms.Label label1;
        private cafeDataSetTableAdapters.masaTableAdapter masaTableAdapter;
        private System.Windows.Forms.BindingSource siparisBindingSource;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cafeDataSet cafeDataSet1;
        private System.Windows.Forms.BindingSource siparisBindingSource1;
        private System.Windows.Forms.BindingSource siparisBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private cafeDataSetTableAdapters.urunTableAdapter urunTableAdapter1;
    }
}