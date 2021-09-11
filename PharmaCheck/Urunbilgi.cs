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
    public partial class Urunbilgi : Form
    {
        public Urunbilgi()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.Show();
            
        }
        string referans;
        private void Urunbilgi_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand isim = new SQLiteCommand("select urun_adi from Urun_bilgi", baglan))
                {
                    baglan.Open();
                    using (SQLiteDataReader isimoku = isim.ExecuteReader())
                    {
                        try
                        { 
                            while (isimoku.Read())
                            {
                                combourunadi.Items.Add(isimoku["urun_adi"].ToString());
                            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source =db/PharmaCheck.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand("select urun_resmi,urun_adi,urun_kodu,sgk_durumu,urun_fiyati from Urun_bilgi where urun_adi=@urunadi", baglan))
                {
                    SQLiteParameter prm = new SQLiteParameter("@urunadi", combourunadi.Text);
                    getir.Parameters.Add(prm);

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(getir))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            try
                            {
                                baglan.Open();
                                da.Fill(ds);
                                dataGridView1.DataSource = ds.Tables[0];
                                dataGridView1.Columns[0].HeaderText = "Ürün Resmi";
                                dataGridView1.Columns[1].HeaderText = "Ürün Adı";
                                dataGridView1.Columns[2].HeaderText = "Ürün Kodu";
                                dataGridView1.Columns[3].HeaderText = "SGK Durumu";
                                dataGridView1.Columns[3].HeaderText = "Ürün Fiyatı";
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

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG Dosyaları |*.jpg| PNG Dosyaları|*.png";
            file.FilterIndex = 2;
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
            txtresim.Text = file.FileName;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtresim.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtkod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            combosgk.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            referans = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source = db/PharmaCheck.db"))
            {
                using (SQLiteCommand güncelle= new SQLiteCommand($"Update Urun_bilgi set urun_resmi='{txtresim.Text}',urun_adi='{txtisim.Text}',urun_kodu='{txtkod.Text}',sgk_durumu='{combosgk.Text}',urun_fiyati='{txtfiyat.Text}' where urun_adi='{referans}'",baglan))
                {
                    try
                    {
                        baglan.Open();
                        güncelle.ExecuteNonQuery();
                        MessageBox.Show("Güncellendi");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata : \n " + hata);
                    }
                    finally
                    {
                        baglan.Close();
                    }
                }
            }
        }

        private void combourunadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source =db/PharmaCheck.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand("select urun_resmi,urun_adi,urun_kodu,sgk_durumu,urun_fiyati from Urun_bilgi where urun_adi=@urunadi", baglan))
                {
                    SQLiteParameter prm = new SQLiteParameter("@urunadi", combourunadi.Text);
                    getir.Parameters.Add(prm);

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(getir))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            try
                            {
                                baglan.Open();
                                da.Fill(ds);
                                dataGridView1.DataSource = ds.Tables[0];
                                dataGridView1.Columns[0].HeaderText = "Ürün Resmi";
                                dataGridView1.Columns[1].HeaderText = "Ürün Adı";
                                dataGridView1.Columns[2].HeaderText = "Ürün Kodu";
                                dataGridView1.Columns[3].HeaderText = "SGK Durumu";
                                dataGridView1.Columns[3].HeaderText = "Ürün Fiyatı";
                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show(" " + hata);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand sil = new SQLiteCommand($"delete from Urun_bilgi where urun_adi='{referans}'",baglan))
                {
                    try
                    {
                        baglan.Open();
                        sil.ExecuteNonQuery();
                        MessageBox.Show("Silindi");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata : \n"+hata);
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
