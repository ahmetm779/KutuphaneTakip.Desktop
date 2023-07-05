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
    public partial class emanet_kayit : Form
    {
        public anaform ana;
        public emanet_kayit()
        {
            InitializeComponent();
        }
        DataTable okuyucubilgi = new DataTable();
        string stok;
        private void emanet_kayit_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dateTimePicker2.Value = DateTime.Today.AddDays(15);
            textBox9.Text = "1";

            OleDbDataReader oku;
            ana.komut.CommandText = "select * from kitap_bilgi where ID =" + ana.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            ana.komut.Connection = ana.baglanti;
            ana.baglanti.Open();
            oku = ana.komut.ExecuteReader();
            while (oku.Read())
            {
                textBox2.Text = oku[1].ToString();
                textBox3.Text = oku[2].ToString();
                textBox4.Text = oku[3].ToString();
                textBox5.Text = oku[4].ToString();
                textBox6.Text = oku[5].ToString();
                textBox7.Text = oku[6].ToString();
                textBox8.Text = oku[7].ToString();
                stok = oku[8].ToString();
            }
            ana.baglanti.Close();
            if (Convert.ToUInt16(stok) < 3 && Convert.ToUInt16(stok) != 0)
                MessageBox.Show("Stok Azaldı!", "Bilgilendirme");
            if (Convert.ToUInt16(stok) == 0)
                MessageBox.Show(textBox2.Text + " Kitabının Stokları Tükendi!", "Uyarı");
        }
        private void emaneti_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
                {
                    var uyelikbulma = textBox1.Text;
                    ana.baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu where uyelik_no=@uyelik_no1", ana.baglanti);
                    OleDbCommand kmt = new OleDbCommand("select * from kitap_bilgi", ana.baglanti);
                    komut.Parameters.AddWithValue("@uyelik_no1", uyelikbulma);
                    OleDbDataReader oku = komut.ExecuteReader();
                    if (oku.HasRows)
                    {
                        int a = int.Parse(stok);
                        a -= int.Parse(textBox9.Text);
                        ana.komut.CommandText = "insert into emanet_kitaplar ([uyelik_no],kitap_adi,yazar_adi,yayinevi,kitap_turu,kitap_konu,baski_yeri,[baski_sayisi],[verilen_kitap],verilme_tarihi,iade_tarihi) values (" + textBox1.Text + " , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' ,'" + textBox5.Text + "' ,'" + textBox6.Text + "','" + textBox7.Text + "'," + textBox8.Text + "," + textBox9.Text + ",'" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
                        kmt.CommandText = "update kitap_bilgi set stok=" + a.ToString() + " where ID=" + ana.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                        ana.komut.Connection = ana.baglanti;
                        kmt.Connection = ana.baglanti;
                        ana.baglanti.Close();
                        ana.baglanti.Open();
                        ana.komut.ExecuteNonQuery();
                        kmt.ExecuteNonQuery();
                        ana.baglanti.Close();
                        MessageBox.Show("Emanet Başarıyla Kaydedildi.", "Bilgilendirme");
                        textBox1.Clear();
                        textBox9.Clear();
                        this.Close();
                        ana.dataGridView1.Visible = false;
                        ana.kitap_guncelle.Visible = false;
                        ana.kitap_sil.Visible = false;
                        ana.kitap_ara.Visible = false;
                        ana.label2.Text = "";
                        ana.emanet_kayit.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Böyle Bir Üyelik Numarası Bulunamadı!!", "Uyarı!");
                        DialogResult cevap;
                        cevap = MessageBox.Show("Yeni Üyelik Oluşturulsun mu?", "Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cevap == DialogResult.Yes)
                            ana.okuyucu.ShowDialog();
                        else
                            this.Close();
                        ana.baglanti.Close();
                    }
                }
                else
                {
                    textBox1.Text = "";
                    MessageBox.Show("Bilgiler Boş Girilemez!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu üyede zaten bir kitap mevcut!", "Uyarı!");
            }
        }
    }
}

