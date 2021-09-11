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
    public partial class Uruniade : Form
    {
        public Uruniade()
        {
            InitializeComponent();
        }

        string satis_numarasi;

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.Show();
            
        }

        private void Uruniade_Load(object sender, EventArgs e)
        {
            
        }

        private void txtürünisim0_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand($"select satis_numarasi,urun_adi,urun_kodu,sgk_durumu,urun_fiyati,urun_kdv,genel_toplam,hasta_kimlik_numarasi,hasta_adi,hasta_soyadi,alan_kisi,tarih from Satilan_urunler where hasta_kimlik_numarasi = '{txtürünisim0.Text}'", baglan))
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
                                dataGridView1.Columns[0].HeaderText = "Satış Numarası";
                                dataGridView1.Columns[1].HeaderText = "Ürün Adı";
                                dataGridView1.Columns[2].HeaderText = "Ürün Kodu";
                                dataGridView1.Columns[3].HeaderText = "SGK Durumu";
                                dataGridView1.Columns[4].HeaderText = "Ürün Fiyatı";
                                dataGridView1.Columns[5].HeaderText = "KDV";
                                dataGridView1.Columns[6].HeaderText = "Toplam Ücret";
                                dataGridView1.Columns[7].HeaderText = "Hasta Kimlik";
                                dataGridView1.Columns[8].HeaderText = "Hasta Adı";
                                dataGridView1.Columns[9].HeaderText = "Hasta Soyadı";
                                dataGridView1.Columns[10].HeaderText = "Alan Kişi";
                                dataGridView1.Columns[11].HeaderText = "Tarih";
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

        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            satis_numarasi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtürünisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtürünkod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsgk.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtürünfiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtkdv.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtgeneltoplam.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtkimlik.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txthastaadi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txthastasoyadi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboalankişi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tarih.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand sil = new SQLiteCommand($"delete from Satilan_urunler where satis_numarasi='{satis_numarasi}'",baglan))
                {
                    try
                    {
                        baglan.Open();
                        sil.ExecuteNonQuery();
                        MessageBox.Show("İade Yapıldı");
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
