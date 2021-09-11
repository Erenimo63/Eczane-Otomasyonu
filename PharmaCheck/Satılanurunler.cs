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
    public partial class Satılanurunler : Form
    {
        public Satılanurunler()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.Show();
            

        }

        private void Satılanurunler_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand("select * from Satilan_urunler", baglan))
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
                                dataGridView1.Columns[1].HeaderText = "Ürün Adı";
                                dataGridView1.Columns[2].HeaderText = "Ürün Kodu";
                                dataGridView1.Columns[3].HeaderText = "SGK Durumu";
                                dataGridView1.Columns[4].HeaderText = "KDV";
                                dataGridView1.Columns[5].HeaderText = "Ürün Fiyatı";
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand($"select * from Satilan_urunler where hasta_kimlik_numarasi ='{txthastakimlik.Text}'", baglan))
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
                                dataGridView1.Columns[1].HeaderText = "Ürün Adı";
                                dataGridView1.Columns[2].HeaderText = "Ürün Kodu";
                                dataGridView1.Columns[3].HeaderText = "SGK Durumu";
                                dataGridView1.Columns[4].HeaderText = "KDV";
                                dataGridView1.Columns[5].HeaderText = "Ürün Fiyatı";
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
    }
}
