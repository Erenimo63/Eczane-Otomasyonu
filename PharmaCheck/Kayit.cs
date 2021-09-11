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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
            
            
        }
        
        private void Kayit_Load(object sender, EventArgs e)
        {
            
        }

        private void txtkaydet_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source = db/PharmaCheck.db"))
            {
                baglan.Open();
                using (SQLiteCommand kayit = new SQLiteCommand($"insert into Personel (personel_numarasi,personel_adi,personel_soyadi,personel_tc_numarasi) values ('{txtpersonelnumara.Text}','{txtadi.Text}','{txtsoyadi.Text}','{txttcnumarasi.Text}')",baglan))
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
    }
}
