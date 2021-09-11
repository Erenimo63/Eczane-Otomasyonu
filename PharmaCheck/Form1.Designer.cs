namespace PharmaCheck
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btngiris = new System.Windows.Forms.Button();
            this.btnkayıtol = new System.Windows.Forms.Button();
            this.txtgörevli = new System.Windows.Forms.TextBox();
            this.txttckimlik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.White;
            this.btngiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.Color.ForestGreen;
            this.btngiris.Location = new System.Drawing.Point(78, 178);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(75, 30);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btnkayıtol
            // 
            this.btnkayıtol.BackColor = System.Drawing.Color.White;
            this.btnkayıtol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkayıtol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıtol.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnkayıtol.Location = new System.Drawing.Point(187, 178);
            this.btnkayıtol.Name = "btnkayıtol";
            this.btnkayıtol.Size = new System.Drawing.Size(75, 30);
            this.btnkayıtol.TabIndex = 3;
            this.btnkayıtol.Text = "Kayıt Ol";
            this.btnkayıtol.UseVisualStyleBackColor = false;
            this.btnkayıtol.Click += new System.EventHandler(this.btnkayıtol_Click);
            // 
            // txtgörevli
            // 
            this.txtgörevli.Location = new System.Drawing.Point(178, 33);
            this.txtgörevli.Name = "txtgörevli";
            this.txtgörevli.Size = new System.Drawing.Size(100, 20);
            this.txtgörevli.TabIndex = 0;
            // 
            // txttckimlik
            // 
            this.txttckimlik.Location = new System.Drawing.Point(178, 122);
            this.txttckimlik.Name = "txttckimlik";
            this.txttckimlik.Size = new System.Drawing.Size(100, 20);
            this.txttckimlik.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Görevli NO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "T.C Kimlik :";
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.White;
            this.btncikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.ForestGreen;
            this.btncikis.Location = new System.Drawing.Point(131, 214);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(75, 30);
            this.btncikis.TabIndex = 4;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(341, 256);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttckimlik);
            this.Controls.Add(this.txtgörevli);
            this.Controls.Add(this.btnkayıtol);
            this.Controls.Add(this.btngiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PharmaCheck";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btnkayıtol;
        private System.Windows.Forms.TextBox txtgörevli;
        private System.Windows.Forms.TextBox txttckimlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncikis;
    }
}

