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
    public partial class kitap_teslim : Form
    {
        public anaform ana;
        public kitap_teslim()
        {
            InitializeComponent();
        }
        string iade;
        private void kitap_teslim_Load(object sender, EventArgs e)
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
                textBox3.Text = oku[3].ToString();
                textBox4.Text = oku[4].ToString();
                textBox5.Text = oku[5].ToString();
                textBox6.Text = oku[6].ToString();
                textBox7.Text = oku[7].ToString();
                textBox8.Text = oku[8].ToString();
                textBox9.Text = oku[9].ToString();                
            }
            ana.baglanti.Close();
            
            OleDbDataReader oku1;
            ana.komut.CommandText = "select * from kitap_bilgi where kitap_adi = '" + textBox2.Text + "'";
            ana.komut.Connection = ana.baglanti;
            ana.baglanti.Open();
            oku1 = ana.komut.ExecuteReader();
            while (oku1.Read())
            {
                iade = oku1[8].ToString();
            }
            ana.baglanti.Close();
        }

        private void kitap_teslim_et_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand kmt = new OleDbCommand("select * from kitap_bilgi", ana.baglanti);
                int a = int.Parse(iade);
                a += int.Parse(textBox9.Text);
                ana.komut.CommandText = "delete from emanet_kitaplar where [ID]= " + ana.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                kmt.CommandText = "update kitap_bilgi set stok=" + a.ToString() + " where kitap_adi='" + textBox2.Text + "'";
                ana.komut.Connection = ana.baglanti;
                kmt.Connection = ana.baglanti;
                ana.baglanti.Open();
                ana.komut.ExecuteNonQuery();
                kmt.ExecuteNonQuery();
                ana.baglanti.Close();
                ana.emanetyenile();
                ana.komut.CommandText = "insert into teslim_edilen_kitap ([uyelik_no],kitap_adi,yazar_adi,yayinevi,kitap_turu,kitap_konu,baski_yeri,[baski_sayisi],[geri_verilen_kitap]) values (" + textBox1.Text + " , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' ,'" + textBox5.Text + "' ,'" + textBox6.Text + "','" + textBox7.Text + "'," + textBox8.Text + "," + textBox9.Text + ")";
                ana.komut.Connection = ana.baglanti;
                ana.baglanti.Close();
                ana.baglanti.Open();
                ana.komut.ExecuteNonQuery();
                ana.baglanti.Close();
                MessageBox.Show("Emanet Başarıyla İade Edildi.","Bigilendirme");
                this.Close();
                ana.dataGridView1.Visible = false;
                ana.kitap_teslim.Visible = false;
                ana.emanet_ara.Visible = false;
                label2.Text = "";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
