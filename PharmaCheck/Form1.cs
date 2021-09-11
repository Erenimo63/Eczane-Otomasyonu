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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/PharmaCheck.db"))
            {
                baglan.Open();
                string personel, kimlik;
                personel = txtgörevli.Text;
                kimlik = txttckimlik.Text;
                using (SQLiteCommand getir = new SQLiteCommand("select * from Personel where personel_numarasi=@numara AND personel_tc_numarasi=@kimlik", baglan))
                {
                    SQLiteParameter prm = new SQLiteParameter("@numara", personel);
                    SQLiteParameter prm1 = new SQLiteParameter("@kimlik", kimlik);
                    getir.Parameters.Add(prm1);
                    getir.Parameters.Add(prm);
                    using (SQLiteDataReader oku = getir.ExecuteReader())
                    {
                        if (oku.Read())
                        {
                            baglan.Close();
                            AnaSayfa anasayfa = new AnaSayfa();
                            this.Hide();
                            anasayfa.Show();

                        }
                        else
                        {
                            MessageBox.Show("Personel Numarası ve Kimlik Numarası Yanlış");
                        }
                    }
                }
            }
            

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            this.Hide();
            kayit.Show();
            
            
        }
    }
}
