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
    public partial class UrunSatis : Form
    {
        public UrunSatis()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan = new SQLiteConnection();

        private void UrunSatis_Load(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (radiopesin.Checked==true)
            {
                using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
                {
                    using (SQLiteCommand ekle = new SQLiteCommand($"insert into Satilan_urunler (urun_adi,urun_kodu,sgk_durumu,urun_fiyati,urun_kdv,genel_toplam,hasta_kimlik_numarasi,hasta_adi,hasta_soyadi,alan_kisi,tarih) values ('{txtürünisim.Text}','{txtürünkod.Text}','{txtsgk.Text}','{txtürünfiyat.Text}','{txtkdv.Text}','{txtgeneltoplam.Text}','{txtkimlik.Text}','{txthastaadi.Text}','{txthastasoyadi.Text}','{comboalankişi.Text}','{tarih.Text}')",baglan))
                    {
                        try
                        {
                            baglan.Open();
                            ekle.ExecuteNonQuery();
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
            else if (radioveresiye.Checked==true)
            {
                using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
                {
                    using (SQLiteCommand ekle = new SQLiteCommand($"insert into Veresiye (urun_adi,urun_kodu,sgk_durumu,urun_fiyati,urun_kdv,genel_toplam,hasta_kimlik_numarasi,hasta_adi,hasta_soyadi,alan_kisi,tarih) values ('{txtürünisim.Text}','{txtürünkod.Text}','{txtsgk.Text}','{txtürünfiyat.Text}','{txtkdv.Text}','{txtgeneltoplam.Text}','{txtkimlik.Text}','{txthastaadi.Text}','{txthastasoyadi.Text}','{comboalankişi.Text}','{tarih.Text}')", baglan))
                    {
                        try
                        {
                            baglan.Open();
                            ekle.ExecuteNonQuery();
                            MessageBox.Show("Kayıt Yapıldı");
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



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtürünisim0_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double kdv,fiyat;
            urunresim.ImageLocation = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtürünisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtürünkod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsgk.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtürünfiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fiyat = Convert.ToDouble(txtürünfiyat.Text);
            kdv = (fiyat* 0.18);
            txtkdv.Text = kdv.ToString();
            txtürünisim1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtürünkod1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsgk1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtürünfiyat1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtgeneltoplam.Text = (kdv + fiyat).ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void combourunadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand($"select urun_resmi,urun_adi,urun_kodu,sgk_durumu,urun_fiyati from Urun_bilgi where urun_adi = '{combourunadi.Text}'", baglan))
                {
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
                                dataGridView1.Columns[2].HeaderText = "Hasta Kodu";
                                dataGridView1.Columns[3].HeaderText = "SGK";
                                dataGridView1.Columns[4].HeaderText = "Ürün Fiyatı";
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
}
