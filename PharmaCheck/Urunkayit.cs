using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PharmaCheck
{
    public partial class Urunkayit : Form
    {
        public Urunkayit()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG Dosyaları |*.jpg| PNG Dosyaları|*.png";
            file.FilterIndex = 2;
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
            txtresim.Text = file.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void Urunkayit_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                baglan.Open();
                using (SQLiteCommand kayit = new SQLiteCommand($"insert into Urun_bilgi (urun_resmi,urun_adi,urun_kodu,sgk_durumu,urun_fiyati,urun_adedi) values ('{txtresim.Text}','{txtisim.Text}','{txtkod.Text}','{combosgk.Text}','{txtfiyat.Text}','{txtadet.Text}')", baglan))
                {

                    try
                    {
                        kayit.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Yapıldı");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(" "+hata);
                    }
                    finally
                    {
                        baglan.Close();
                    }

                }
            }

        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan=new SQLiteConnection("data source = db/PharmaCheck.db"))
            {
                baglan.Open();
                int adet, urun;
                using (SQLiteCommand getir = new SQLiteCommand($"select urun_adi,urun_adedi from Urun_bilgi where urun_adi ='{txtisim.Text}'",baglan))
                {
                    using (SQLiteDataReader oku = getir.ExecuteReader())
                    {
                        oku.Read();
                        adet = Convert.ToInt32(oku["urun_adedi"]);
                        urun = int.Parse(txtadet.Text);
                        adet = adet + urun;
                        using (SQLiteCommand güncelle = new SQLiteCommand($"update Urun_bilgi set urun_adedi ='{adet}' where urun_adi ='{txtisim.Text}'",baglan))
                        {
                            try
                            {
                                güncelle.ExecuteNonQuery();
                                MessageBox.Show("Stok Eklendi");
                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show(" "+hata);
                            }
                            finally
                            {
                                baglan.Close();
                            }
                        }
                    }

                }
            }
        }
    }
}
