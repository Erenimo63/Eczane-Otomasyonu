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
    public partial class Veresiye : Form
    {
        public Veresiye()
        {
            InitializeComponent();
        }

        string satis_id, hasta_kimlik, hasta_adi, hasta_soyadi, alan_kisi, tarih, urun_adi, urun_kodu, sgk, genel_toplam,urun_fiyati,urun_kdv;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            satis_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            hasta_kimlik = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            hasta_adi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hasta_soyadi = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            alan_kisi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tarih = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            urun_adi = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            urun_kodu = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            sgk = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            urun_kdv = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            urun_fiyati = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            genel_toplam = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void Veresiye_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand("select * from Veresiye", baglan))
                {
                    baglan.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(getir))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            try
                            {
                                da.Fill(ds);
                                dataGridView1.DataSource = ds.Tables[0];
                                dataGridView1.Columns[0].HeaderText = "Satış Numarası";
                                dataGridView1.Columns[1].HeaderText = "Hasta Kimlik";
                                dataGridView1.Columns[2].HeaderText = "Hasta Adı";
                                dataGridView1.Columns[3].HeaderText = "Hasta Soyadı";
                                dataGridView1.Columns[4].HeaderText = "Alan Kişi";
                                dataGridView1.Columns[5].HeaderText = "Tarih";
                                dataGridView1.Columns[6].HeaderText = "Ürün Adı";
                                dataGridView1.Columns[7].HeaderText = "Ürün Kodu";
                                dataGridView1.Columns[8].HeaderText = "SGK Durumu";
                                dataGridView1.Columns[9].HeaderText = "KDV";
                                dataGridView1.Columns[10].HeaderText = "Ürün Fiyatı";
                                dataGridView1.Columns[11].HeaderText = "Genel Toplam";
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

        private void txtürünisim0_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand($"select * from Veresiye where hasta_kimlik_numarasi ='{txtürünisim0.Text}'", baglan))
                {
                    baglan.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(getir))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            try
                            {
                                da.Fill(ds);
                                dataGridView1.DataSource = ds.Tables[0];
                                dataGridView1.Columns[0].HeaderText = "Hasta Kimlik";
                                dataGridView1.Columns[1].HeaderText = "Hasta Adı";
                                dataGridView1.Columns[2].HeaderText = "Hasta Soyadı";
                                dataGridView1.Columns[3].HeaderText = "Alan Kişi";
                                dataGridView1.Columns[4].HeaderText = "Tarih";
                                dataGridView1.Columns[5].HeaderText = "Ürün Adı";
                                dataGridView1.Columns[6].HeaderText = "Ürün Kodu";
                                dataGridView1.Columns[7].HeaderText = "SGK Durumu";
                                dataGridView1.Columns[8].HeaderText = "Ücret";
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source = db/PharmaCheck.db"))
            {
                using (SQLiteCommand sil = new SQLiteCommand($"delete from Veresiye where satis_numarasi='{satis_id}'",baglan))
                {
                    using (SQLiteCommand ekle = new SQLiteCommand($"insert into Satilan_urunler (urun_adi,urun_kodu,sgk_durumu,urun_fiyati,urun_kdv,genel_toplam,hasta_kimlik_numarasi,hasta_adi,hasta_soyadi,alan_kisi,tarih) values ('{urun_adi}','{urun_kodu}','{sgk}','{urun_fiyati}','{urun_kdv}','{genel_toplam}','{hasta_kimlik}','{hasta_adi}','{hasta_soyadi}','{alan_kisi}','{tarih}')", baglan))
                    {
                        try
                        {
                            baglan.Open();
                            sil.ExecuteNonQuery();
                            ekle.ExecuteNonQuery();
                            MessageBox.Show("Borç Silindi");
                            Veresiye_Load(sender, e);
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
}
