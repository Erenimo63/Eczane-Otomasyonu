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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
            
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            UrunSatis urunsatis = new UrunSatis();
            this.Hide();
            urunsatis.Show();
            
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            Urunkayit urunkayit = new Urunkayit();
            this.Hide();
            urunkayit.Show();
            
        }

        private void btniade_Click(object sender, EventArgs e)
        {
            Uruniade uruniade = new Uruniade();
            this.Hide();
            uruniade.Show();
            
        }

        private void btnsatilanürünler_Click(object sender, EventArgs e)
        {
            Satılanurunler satilanurunler = new Satılanurunler();
            this.Hide();
            satilanurunler.Show();
            
        }

        private void btnürünbilgi_Click(object sender, EventArgs e)
        {
            Urunbilgi urunbilgi = new Urunbilgi();
            this.Hide();
            urunbilgi.Show();
            
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            Stok stok = new Stok();
            this.Hide();
            stok.Show();
            
        }

        private void btnveresiye_Click(object sender, EventArgs e)
        {
            Veresiye veresiye = new Veresiye();
            this.Hide();
            veresiye.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            this.Hide();
            personel.Show();
        }
    }
}
