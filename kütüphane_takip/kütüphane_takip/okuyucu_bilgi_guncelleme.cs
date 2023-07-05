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
    public partial class okuyucu_bilgi_guncelleme : Form
    {
        public anaform ana;
        public okuyucu_bilgi_guncelleme()
        {
            InitializeComponent();
        }

        private void okuyucu_bilgi_guncelleme_Load(object sender, EventArgs e)
        {
            ana.baglanti.Close();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            OleDbDataReader oku;
            ana.komut.CommandText = "select uyelik_no,uye_adi,uye_soyadi,tc_no,tel_no,adres from okuyucu where ID =" + ana.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
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
            }
            ana.baglanti.Close();
        }

        private void guncellee_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
            textBox3.Text = textBox3.Text.ToUpper();
            textBox6.Text = textBox6.Text.ToUpper();
            ana.baglanti.Open();
            ana.komut.CommandText = "update okuyucu set uye_adi='" + textBox2.Text + "',uye_soyadi='" + textBox3.Text + "',tc_no='" + textBox4.Text + "',tel_no='" + textBox5.Text + "',adres='" + textBox6.Text + "' where uyelik_no=" + Convert.ToInt16(textBox1.Text) + "";
            ana.komut.ExecuteNonQuery();
            ana.baglanti.Close();
            ana.okuyenile();
        }
    }
}
