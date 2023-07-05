using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kütüphane_takip
{
    public partial class kitap_bilgi_guncelleme : Form
    {
        public anaform ana;
        public kitap_bilgi_guncelleme()
        {
            InitializeComponent();
        }

        private void kitap_bilgi_guncelleme_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            OleDbDataReader oku;
            ana.komut.CommandText = "select * from kitap_bilgi where ID =" + ana.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            ana.komut.Connection = ana.baglanti;
            ana.baglanti.Open();
            oku = ana.komut.ExecuteReader();
            while (oku.Read())
            {
                textBox1.Text = oku[0].ToString();
                textBox2.Text = oku[1].ToString();
                textBox3.Text = oku[2].ToString();
                textBox4.Text = oku[3].ToString();
                textBox5.Text = oku[4].ToString();
                textBox6.Text = oku[5].ToString();
                textBox7.Text = oku[6].ToString();
                textBox8.Text = oku[7].ToString();
                textBox9.Text = oku[8].ToString();
            }
            ana.baglanti.Close();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
            textBox3.Text = textBox3.Text.ToUpper();
            textBox4.Text = textBox4.Text.ToUpper();
            textBox5.Text = textBox5.Text.ToUpper();
            textBox6.Text = textBox6.Text.ToUpper();
            textBox7.Text = textBox7.Text.ToUpper();
            ana.baglanti.Open();
            ana.komut.CommandText = "update kitap_bilgi set kitap_adi='" + textBox2.Text + "',yazar_adi='" + textBox3.Text + "',yayinevi='" + textBox4.Text + "',kitap_turu='" + textBox5.Text + "',kitap_konu='" + textBox6.Text + "',baski_yeri='" + textBox7.Text + "',baski_sayisi=" + Convert.ToInt16(textBox8.Text) + ",stok=" + Convert.ToInt16(textBox9.Text) + " where ID=" + Convert.ToInt16(textBox1.Text) + "";
            ana.komut.ExecuteNonQuery();
            ana.baglanti.Close();
            ana.kitapyenile();
        }
    }
}
