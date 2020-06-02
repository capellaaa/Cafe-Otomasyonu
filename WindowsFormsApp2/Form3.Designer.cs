namespace WindowsFormsApp2
{
    partial class Form3
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
            this.sayitext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cafeDataSet = new WindowsFormsApp2.cafeDataSet();
            this.masaTableAdapter = new WindowsFormsApp2.cafeDataSetTableAdapters.masaTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp2.cafeDataSetTableAdapters.TableAdapterManager();
            this.cafeDataSet1 = new WindowsFormsApp2.cafeDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sayitext
            // 
            this.sayitext.Location = new System.Drawing.Point(196, 85);
            this.sayitext.MaxLength = 2;
            this.sayitext.Name = "sayitext";
            this.sayitext.ShortcutsEnabled = false;
            this.sayitext.Size = new System.Drawing.Size(135, 20);
            this.sayitext.TabIndex = 1;
            this.sayitext.Text = "1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(196, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Masa sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dikkat masa sayısı değiştirmek kayıtlı tüm siparişleri iptal edecektir ";
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masaTableAdapter
            // 
            this.masaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.gecmisTableAdapter = null;
            this.tableAdapterManager1.masaTableAdapter = this.masaTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp2.cafeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.urunTableAdapter = null;
            this.tableAdapterManager1.userTableTableAdapter = null;
            // 
            // cafeDataSet1
            // 
            this.cafeDataSet1.DataSetName = "cafeDataSet";
            this.cafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form3
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sayitext);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sayitext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private cafeDataSet cafeDataSet;
        private cafeDataSetTableAdapters.masaTableAdapter masaTableAdapter;
        private cafeDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private cafeDataSet cafeDataSet1;
    }
}