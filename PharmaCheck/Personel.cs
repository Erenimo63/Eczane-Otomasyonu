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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        int referans;
        private void Personel_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand("select * from Personel", baglan))
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
                                dataGridView1.Columns[0].HeaderText = "Personel Numarası";
                                dataGridView1.Columns[1].HeaderText = "Personel Adı";
                                dataGridView1.Columns[2].HeaderText = "Personel Soyadı";
                                dataGridView1.Columns[3].HeaderText = "Personel Kimlik";
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

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpersonelnumara.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttcnumarasi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            referans= int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand güncelle=new SQLiteCommand($"update Personel set personel_numarasi ='{txtpersonelnumara.Text}', personel_adi ='{txtadi.Text}', personel_soyadi='{txtsoyadi.Text}', personel_tc_numarasi='{txttcnumarasi.Text}' where personel_tc_numarasi = '{referans}'",baglan))
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

        private void button3_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                using (SQLiteCommand sil = new SQLiteCommand($"delete from Personel Where personel_tc_numarasi='{referans}'", baglan))
                {
                    try
                    {
                        baglan.Open();
                        sil.ExecuteNonQuery();
                        MessageBox.Show("Silindi");
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
    }
}
