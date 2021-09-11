namespace PharmaCheck
{
    partial class Uruniade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uruniade));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtürünisim0 = new System.Windows.Forms.TextBox();
            this.comboalankişi = new System.Windows.Forms.ComboBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkdv = new System.Windows.Forms.TextBox();
            this.txtürünfiyat = new System.Windows.Forms.TextBox();
            this.txtsgk = new System.Windows.Forms.TextBox();
            this.txthastasoyadi = new System.Windows.Forms.TextBox();
            this.txtürünkod = new System.Windows.Forms.TextBox();
            this.txthastaadi = new System.Windows.Forms.TextBox();
            this.txtürünisim = new System.Windows.Forms.TextBox();
            this.txtkimlik = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtgeneltoplam = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(12, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(792, 58);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(259, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Hasta Kimlik Numarası : ";
            // 
            // txtürünisim0
            // 
            this.txtürünisim0.Location = new System.Drawing.Point(431, 19);
            this.txtürünisim0.Name = "txtürünisim0";
            this.txtürünisim0.Size = new System.Drawing.Size(100, 20);
            this.txtürünisim0.TabIndex = 26;
            this.txtürünisim0.TextChanged += new System.EventHandler(this.txtürünisim0_TextChanged);
            // 
            // comboalankişi
            // 
            this.comboalankişi.Enabled = false;
            this.comboalankişi.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboalankişi.FormattingEnabled = true;
            this.comboalankişi.Items.AddRange(new object[] {
            "Anne",
            "Baba",
            "Abi/Abla",
            "Kardeş"});
            this.comboalankişi.Location = new System.Drawing.Point(510, 173);
            this.comboalankişi.Name = "comboalankişi";
            this.comboalankişi.Size = new System.Drawing.Size(100, 23);
            this.comboalankişi.TabIndex = 48;
            // 
            // tarih
            // 
            this.tarih.Cursor = System.Windows.Forms.Cursors.No;
            this.tarih.Enabled = false;
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.Location = new System.Drawing.Point(640, 174);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(100, 20);
            this.tarih.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(641, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(510, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Alan Kişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(380, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Hastanın Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Hastanın Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(380, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "SGK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(641, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "KDV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(510, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Ürün Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(249, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Ürün Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ürün İsmi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Hasta Kimlik Numarası";
            // 
            // txtkdv
            // 
            this.txtkdv.Cursor = System.Windows.Forms.Cursors.No;
            this.txtkdv.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkdv.Location = new System.Drawing.Point(640, 253);
            this.txtkdv.Name = "txtkdv";
            this.txtkdv.ReadOnly = true;
            this.txtkdv.Size = new System.Drawing.Size(100, 22);
            this.txtkdv.TabIndex = 35;
            // 
            // txtürünfiyat
            // 
            this.txtürünfiyat.Cursor = System.Windows.Forms.Cursors.No;
            this.txtürünfiyat.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtürünfiyat.Location = new System.Drawing.Point(510, 253);
            this.txtürünfiyat.Name = "txtürünfiyat";
            this.txtürünfiyat.ReadOnly = true;
            this.txtürünfiyat.Size = new System.Drawing.Size(100, 22);
            this.txtürünfiyat.TabIndex = 34;
            // 
            // txtsgk
            // 
            this.txtsgk.Cursor = System.Windows.Forms.Cursors.No;
            this.txtsgk.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsgk.Location = new System.Drawing.Point(380, 253);
            this.txtsgk.Name = "txtsgk";
            this.txtsgk.ReadOnly = true;
            this.txtsgk.Size = new System.Drawing.Size(100, 22);
            this.txtsgk.TabIndex = 33;
            // 
            // txthastasoyadi
            // 
            this.txthastasoyadi.Cursor = System.Windows.Forms.Cursors.No;
            this.txthastasoyadi.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthastasoyadi.Location = new System.Drawing.Point(380, 174);
            this.txthastasoyadi.Name = "txthastasoyadi";
            this.txthastasoyadi.ReadOnly = true;
            this.txthastasoyadi.Size = new System.Drawing.Size(100, 22);
            this.txthastasoyadi.TabIndex = 32;
            // 
            // txtürünkod
            // 
            this.txtürünkod.Cursor = System.Windows.Forms.Cursors.No;
            this.txtürünkod.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtürünkod.Location = new System.Drawing.Point(250, 253);
            this.txtürünkod.Name = "txtürünkod";
            this.txtürünkod.ReadOnly = true;
            this.txtürünkod.Size = new System.Drawing.Size(100, 22);
            this.txtürünkod.TabIndex = 31;
            // 
            // txthastaadi
            // 
            this.txthastaadi.Cursor = System.Windows.Forms.Cursors.No;
            this.txthastaadi.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthastaadi.Location = new System.Drawing.Point(250, 174);
            this.txthastaadi.Name = "txthastaadi";
            this.txthastaadi.ReadOnly = true;
            this.txthastaadi.Size = new System.Drawing.Size(100, 22);
            this.txthastaadi.TabIndex = 30;
            // 
            // txtürünisim
            // 
            this.txtürünisim.Cursor = System.Windows.Forms.Cursors.No;
            this.txtürünisim.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtürünisim.Location = new System.Drawing.Point(74, 253);
            this.txtürünisim.Name = "txtürünisim";
            this.txtürünisim.ReadOnly = true;
            this.txtürünisim.Size = new System.Drawing.Size(146, 22);
            this.txtürünisim.TabIndex = 36;
            // 
            // txtkimlik
            // 
            this.txtkimlik.Cursor = System.Windows.Forms.Cursors.No;
            this.txtkimlik.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkimlik.Location = new System.Drawing.Point(74, 174);
            this.txtkimlik.Name = "txtkimlik";
            this.txtkimlik.ReadOnly = true;
            this.txtkimlik.Size = new System.Drawing.Size(146, 22);
            this.txtkimlik.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(610, 291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 15);
            this.label17.TabIndex = 51;
            this.label17.Text = "İade Toplam";
            // 
            // txtgeneltoplam
            // 
            this.txtgeneltoplam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtgeneltoplam.Cursor = System.Windows.Forms.Cursors.No;
            this.txtgeneltoplam.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgeneltoplam.Location = new System.Drawing.Point(601, 313);
            this.txtgeneltoplam.Multiline = true;
            this.txtgeneltoplam.Name = "txtgeneltoplam";
            this.txtgeneltoplam.ReadOnly = true;
            this.txtgeneltoplam.Size = new System.Drawing.Size(100, 39);
            this.txtgeneltoplam.TabIndex = 50;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(707, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 49;
            this.button2.Text = "İade Al";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Uruniade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(816, 370);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtgeneltoplam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboalankişi);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkdv);
            this.Controls.Add(this.txtürünfiyat);
            this.Controls.Add(this.txtsgk);
            this.Controls.Add(this.txthastasoyadi);
            this.Controls.Add(this.txtürünkod);
            this.Controls.Add(this.txthastaadi);
            this.Controls.Add(this.txtürünisim);
            this.Controls.Add(this.txtkimlik);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtürünisim0);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uruniade";
            this.Text = "PharmaCheck";
            this.Load += new System.EventHandler(this.Uruniade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtürünisim0;
        private System.Windows.Forms.ComboBox comboalankişi;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkdv;
        private System.Windows.Forms.TextBox txtürünfiyat;
        private System.Windows.Forms.TextBox txtsgk;
        private System.Windows.Forms.TextBox txthastasoyadi;
        private System.Windows.Forms.TextBox txtürünkod;
        private System.Windows.Forms.TextBox txthastaadi;
        private System.Windows.Forms.TextBox txtürünisim;
        private System.Windows.Forms.TextBox txtkimlik;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtgeneltoplam;
        private System.Windows.Forms.Button button2;
    }
}