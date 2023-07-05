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
    public partial class gecikenkitap : Form
    {
        public anaform ana;
        public gecikenkitap()
        {
            InitializeComponent();
        }

        private void gecikenkitap_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            OleDbDataReader oku;
            ana.komut.CommandText = "select * from emanet_kitaplar where ID =" + ana.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            ana.komut.Connection = ana.baglanti;
            ana.baglanti.Open();
            oku = ana.komut.ExecuteReader();
            while (oku.Read())
            {
                textBox1.Text = oku[1].ToString();
                textBox2.Text = oku[2].ToString();
                textBox4.Text = oku[4].ToString();
                textBox5.Text = oku[5].ToString();
                textBox8.Text = oku[8].ToString();
                textBox9.Text = oku[9].ToString();
                dateTimePicker1.Text= oku[10].ToString();
                dateTimePicker2.Text = oku[11].ToString();
            }
            ana.baglanti.Close();

            OleDbDataReader oku2;
            ana.komut.CommandText="select uye_adi,uye_soyadi from okuyucu where uyelik_no="+ana.dataGridView1.CurrentRow.Cells[1].Value.ToString() + "";
            ana.komut.Connection = ana.baglanti;
            ana.baglanti.Open();
            oku2 = ana.komut.ExecuteReader();
            while (oku2.Read())
            {
                textBox10.Text = oku2[0].ToString();
                textBox11.Text = oku2[1].ToString();
            }
            ana.baglanti.Close();
        }

        private void geciken_kitaplar_Click(object sender, EventArgs e)
        {            
            ana.komut.CommandText = "delete from emanet_kitaplar where ID=" + ana.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            ana.komut.Connection = ana.baglanti;
            ana.baglanti.Open();
            ana.komut.ExecuteNonQuery();
            ana.baglanti.Close();
            ana.emanetyenile();
            ana.komut.CommandText = "delete from okuyucu where uyelik_no=" + textBox1.Text + "";
            ana.komut.Connection = ana.baglanti;
            ana.baglanti.Open();
            ana.komut.ExecuteNonQuery();
            ana.baglanti.Close();
            ana.komut.CommandText = "insert into geciken_kitap ([uyelik_no],uye_adi,uye_soyadi,kitap_adi,yayinevi,kitap_turu,[baski_sayisi],[verilen_kitap],verilme_tarihi,iade_tarihi) values (" + textBox1.Text + " ,'" + textBox10.Text + "', '" + textBox11.Text + "', '" + textBox2.Text + "' , '" + textBox4.Text + "' ,'" + textBox5.Text + "' ," + textBox8.Text + "," + textBox9.Text + ",'" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
            ana.komut.Connection = ana.baglanti;
            ana.baglanti.Open();
            ana.komut.ExecuteNonQuery();
            ana.baglanti.Close();
            MessageBox.Show("Geciken Kitaplar Listesine Eklendi! Üyelik Silindi!", "Uyarı");
            this.Close();
        }
    }
}
