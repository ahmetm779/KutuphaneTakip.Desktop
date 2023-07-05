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
    public partial class kitap_ekle : Form
    {
        public anaform ana;
        public kitap_ekle()
        {
            InitializeComponent();
        }

        private void kitap_ekle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void kitabi_kaydet_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox2.Text = textBox2.Text.ToUpper();
            textBox3.Text = textBox3.Text.ToUpper();
            textBox4.Text = textBox4.Text.ToUpper();
            textBox5.Text = textBox5.Text.ToUpper();
            textBox6.Text = textBox6.Text.ToUpper();
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=kütüphane.mdb");
                    OleDbCommand komut = new OleDbCommand();
                    komut.CommandText = "insert into kitap_bilgi (kitap_adi,yazar_adi,yayinevi,kitap_turu,kitap_konu,baski_yeri,[baski_sayisi],[stok]) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' ,'" + textBox5.Text + "' ,'" + textBox6.Text + "'," + textBox7.Text + "," + textBox8.Text + ")";
                    komut.Connection = baglanti;
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kitap Başarıyla Kaydedildi.", "Bilgilendirme");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bilgiler Boş Girilemez!!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
