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
    public partial class okuyucu_ekle : Form
    {
        public anaform ana;
        public okuyucu_ekle()
        {
            InitializeComponent();
        }

        private void okuyucu_ekle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            OleDbDataReader oku;
            ana.komut.CommandText = "select max(ID) from okuyucu";
            ana.komut.Connection = ana.baglanti;
            ana.baglanti.Close();
            ana.baglanti.Open();
            oku = ana.komut.ExecuteReader();
            while (oku.Read())
            {
                int a = Convert.ToInt16(oku[0].ToString());
                a = a + 1;
                textBox1.Text = a.ToString();
            }
            ana.baglanti.Close();
        }
        private void uyeyi_kaydet_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
            textBox3.Text = textBox3.Text.ToUpper();
            textBox6.Text = textBox6.Text.ToUpper();

            ana.baglanti.Close();
            ana.baglanti.Open();
            ana.komut.CommandText = " Select * From geciken_kitap"; 
            ana.komut.Connection = ana.baglanti;
            OleDbDataReader oku = ana.komut.ExecuteReader();

            while (oku.Read())
            {
                if (textBox2.Text == oku[2].ToString() && textBox3.Text == oku[3].ToString())
                {
                    MessageBox.Show("Bu Kişi Kayıt Edilemez! İade Etmediği Kitaplar Var!","Uyarı!!");
                    return;
                }
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=kütüphane.mdb");
                OleDbCommand komut = new OleDbCommand();
                komut.CommandText = "insert into okuyucu (kayit_formu,nufus_cuzdan,ikametgah,fotograf,uyelik_ucreti,ID,uye_adi,uye_soyadi,tc_no,tel_no,adres) values (1,1,1,1,1,'" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' ,'" + textBox6.Text + "')";
                komut.Connection = baglanti;
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Okuyucu Başarıyla Kaydedildi.", "Bilgilendirme");
                ana.okuyenile();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bilgiler Boş Girilemez!!");
            }
        }
    }
}
