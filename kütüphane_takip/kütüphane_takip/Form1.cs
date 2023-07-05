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
    public partial class anaform : Form
    {
        public okuyucu_ekle okuyucu;
        public emanet_kayit e_kayit;
        public kitap_ekle k_ekle;
        public kitap_teslim k_teslim;
        public kitap_bilgi_guncelleme k_guncelleme;
        public okuyucu_bilgi_guncelleme oku_guncelle;
        public gecikenkitap g_kitap;
        public anaform()
        {
            InitializeComponent();
            okuyucu = new okuyucu_ekle();
            okuyucu.ana = this;
            e_kayit = new emanet_kayit();
            e_kayit.ana = this;
            k_ekle = new kitap_ekle();
            k_ekle.ana = this;
            k_teslim = new kitap_teslim();
            k_teslim.ana = this;
            k_guncelleme = new kitap_bilgi_guncelleme();
            k_guncelleme.ana = this;
            oku_guncelle = new okuyucu_bilgi_guncelleme();
            oku_guncelle.ana = this;
            g_kitap = new gecikenkitap();
            g_kitap.ana = this;
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=kütüphane.mdb");
        public OleDbCommand komut = new OleDbCommand();
        DataTable kitapbilgi = new DataTable();
        DataTable okuyucubilgi = new DataTable();
        DataTable emanetler = new DataTable();
        DataTable gecikenler = new DataTable();
        DataTable teslim_edilenler = new DataTable();
        public void kitapyenile()
        {
            OleDbDataAdapter verigetir = new OleDbDataAdapter("select * from kitap_bilgi", baglanti);
            kitapbilgi.Clear();
            verigetir.Fill(kitapbilgi);
            dataGridView1.DataSource = kitapbilgi;
        }
        public void okuyenile()
        {
            OleDbDataAdapter verigetir = new OleDbDataAdapter("select * from okuyucu", baglanti);
            okuyucubilgi.Clear();
            verigetir.Fill(okuyucubilgi);
            dataGridView1.DataSource = okuyucubilgi;
        }
        public void emanetyenile()
        {
            OleDbDataAdapter verigetir = new OleDbDataAdapter("select * from emanet_kitaplar", baglanti);
            emanetler.Clear();
            verigetir.Fill(emanetler);
            dataGridView1.DataSource = emanetler;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
            label1.Text = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString();
        }
        private void anaform_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;    

            OleDbDataAdapter geciken = new OleDbDataAdapter("Select * from emanet_kitaplar where iade_tarihi = (date())-1", baglanti);
            DataTable gecikenler = new DataTable();
            geciken.Fill(gecikenler);
            if (gecikenler.Rows.Count > 0)
            {
                var liste = gecikenler.Rows.Cast<DataRow>().Select(x => x[1].ToString()).Aggregate((i, x) => i + Environment.NewLine + x);
                MessageBox.Show(liste, "İade Tarihi Geçenlerin Üyelik Numaraları");
                //int a = Convert.ToInt16(liste);
                dataGridView1.Visible = true;
                dataGridView1.GridColor = Color.Red;
                OleDbDataAdapter verigetir = new OleDbDataAdapter("SELECT * FROM emanet_kitaplar where uyelik_no=" + liste , baglanti);
                emanetler.Clear();
                verigetir.Fill(emanetler);
                dataGridView1.DataSource = emanetler;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "ÜYELİK NO";
                dataGridView1.Columns[2].HeaderText = "KİTABIN ADI";
                dataGridView1.Columns[3].HeaderText = "YAZARIN ADI";
                dataGridView1.Columns[4].HeaderText = "YAYINEVİ";
                dataGridView1.Columns[5].HeaderText = "KİTABIN TÜRÜ";
                dataGridView1.Columns[6].HeaderText = "KİTABIN KONUSU";
                dataGridView1.Columns[7].HeaderText = "BASKI YERİ";
                dataGridView1.Columns[8].HeaderText = "BASKI SAYISI";
                dataGridView1.Columns[9].HeaderText = "VERİLEN KİTAP SAYISI";
                dataGridView1.Columns[10].HeaderText = "VERİLME TARİHİ";
                dataGridView1.Columns[11].HeaderText = "İADE TARİHİ";
                geciken_sil.Visible = true;
            }
            baglanti.Close();
            
        }
        private void emanet_kayit_Click(object sender, EventArgs e)
        {            
            e_kayit.ShowDialog();
        }
        private void kitap_teslim_Click(object sender, EventArgs e)
        {
            kitap_teslim.Visible = false;
            label2.Text = "";
            k_teslim.ShowDialog();
        }
        private void anaform_Shown(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from emanet_kitaplar where iade_tarihi = (date())", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                var liste = dt.Rows.Cast<DataRow>().Select(x => x[1].ToString()).Aggregate((i, x) => i + Environment.NewLine + x);
                MessageBox.Show(liste, "Kitapları İade Etmesi Gerekenlerin Üyelik Numaraları");
            }
            baglanti.Close();
        }       
       

        private void kitap_ara_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter verigetir = new OleDbDataAdapter("select * from kitap_bilgi where kitap_adi like '%" + kitap_ara.Text + "%'", baglanti);
            kitapbilgi.Clear();
            verigetir.Fill(kitapbilgi);
            dataGridView1.DataSource = kitapbilgi;
        }

        private void okuyucu_ara_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter verigetir = new OleDbDataAdapter("select * from okuyucu where uye_adi like '%" + okuyucu_ara.Text + "%'", baglanti);
            okuyucubilgi.Clear();
            verigetir.Fill(okuyucubilgi);
            dataGridView1.DataSource = okuyucubilgi;
        }

        private void emanet_ara_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter verigetir = new OleDbDataAdapter("select * from emanet_kitaplar where uyelik_no like '%" + emanet_ara.Text + "%'", baglanti);
            emanetler.Clear();
            verigetir.Fill(emanetler);
            dataGridView1.DataSource = emanetler;
        }

        private void arsiv_ara_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter verigetir = new OleDbDataAdapter("select * from teslim_edilen_kitap where uyelik_no like '%" + arsiv_ara.Text + "%'", baglanti);
            teslim_edilenler.Clear();
            verigetir.Fill(teslim_edilenler);
            dataGridView1.DataSource = teslim_edilenler;
        }

        private void kitap_guncelle_Click(object sender, EventArgs e)
        {
            k_guncelleme.ShowDialog();
        }

        private void kitap_sil_Click(object sender, EventArgs e)
        {
            komut.CommandText = "delete from kitap_bilgi where ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kitapyenile();
        }

        private void okuyucu_guncelle_Click(object sender, EventArgs e)
        {
            oku_guncelle.ShowDialog();            
        }

        private void geciken_sil_Click(object sender, EventArgs e)
        {
            g_kitap.ShowDialog();            
        }
        private void kitaplarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.GridColor = Color.Black;
            OleDbDataAdapter verigetir = new OleDbDataAdapter("SELECT * FROM kitap_bilgi", baglanti);
            kitapbilgi.Clear();
            verigetir.Fill(kitapbilgi);
            dataGridView1.DataSource = kitapbilgi;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "KİTAP ADI";
            dataGridView1.Columns[2].HeaderText = "YAZAR ADI";
            dataGridView1.Columns[3].HeaderText = "YAYINEVİ";
            dataGridView1.Columns[4].HeaderText = "KİTAP TÜRÜ";
            dataGridView1.Columns[5].HeaderText = "KİTABIN KONUSU";
            dataGridView1.Columns[6].HeaderText = "BASKI YERİ";
            dataGridView1.Columns[7].HeaderText = "BASKI SAYISI";
            dataGridView1.Columns[8].HeaderText = "STOK DURUMU";
            baglanti.Close();
            emanet_kayit.Visible = true;
            kitap_guncelle.Visible = true;
            kitap_sil.Visible = true;
            okuyucu_guncelle.Visible = false;
            okuyucu_sil.Visible = false;
            kitap_ara.Visible = true;
            okuyucu_ara.Visible = false;
            emanet_ara.Visible = false;
            arsiv_ara.Visible = false;
            kitap_teslim.Visible = false;
            geciken_sil.Visible = false;
            label2.Text = "Kitap Ara";
            kitap_ara.Focus();
        }
        private void okuyucuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.GridColor = Color.Black;
            OleDbDataAdapter verigetir = new OleDbDataAdapter("SELECT * FROM okuyucu", baglanti);
            okuyucubilgi.Clear();
            verigetir.Fill(okuyucubilgi);
            dataGridView1.DataSource = okuyucubilgi;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ÜYENİN ADI";
            dataGridView1.Columns[2].HeaderText = "ÜYENİN SOYADI";
            dataGridView1.Columns[3].HeaderText = "T.C. NO";
            dataGridView1.Columns[4].HeaderText = "ÜYELİK NO";
            dataGridView1.Columns[5].HeaderText = "TELEFON NUMARASI";
            dataGridView1.Columns[6].HeaderText = "ADRES";
            dataGridView1.Columns[7].HeaderText = "KAYIT FORMU";
            dataGridView1.Columns[8].HeaderText = "NÜFUS CÜZDANI";
            dataGridView1.Columns[9].HeaderText = "İKAMETGAH";
            dataGridView1.Columns[10].HeaderText = "FOTOĞRAF";
            dataGridView1.Columns[11].HeaderText = "ÜYELİK ÜCRETİ";
            baglanti.Close();
            kitap_ara.Visible = false;
            okuyucu_ara.Visible = true;
            kitap_guncelle.Visible = false;
            kitap_sil.Visible = false;
            okuyucu_guncelle.Visible = true;
            okuyucu_sil.Visible = true;
            emanet_ara.Visible = false;
            arsiv_ara.Visible = false;
            kitap_teslim.Visible = false;
            emanet_kayit.Visible = false;
            geciken_sil.Visible = false;
            label2.Text = "Okuyucu Ara";
            okuyucu_ara.Focus();
        }
        private void emanetKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.GridColor = Color.Black;
            OleDbDataAdapter verigetir = new OleDbDataAdapter("SELECT * FROM emanet_kitaplar", baglanti);
            emanetler.Clear();
            verigetir.Fill(emanetler);
            dataGridView1.DataSource = emanetler;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ÜYELİK NO";
            dataGridView1.Columns[2].HeaderText = "KİTABIN ADI";
            dataGridView1.Columns[3].HeaderText = "YAZARIN ADI";
            dataGridView1.Columns[4].HeaderText = "YAYINEVİ";
            dataGridView1.Columns[5].HeaderText = "KİTABIN TÜRÜ";
            dataGridView1.Columns[6].HeaderText = "KİTABIN KONUSU";
            dataGridView1.Columns[7].HeaderText = "BASKI YERİ";
            dataGridView1.Columns[8].HeaderText = "BASKI SAYISI";
            dataGridView1.Columns[9].HeaderText = "VERİLEN KİTAP SAYISI";
            dataGridView1.Columns[10].HeaderText = "VERİLME TARİHİ";
            dataGridView1.Columns[11].HeaderText = "İADE TARİHİ";
            baglanti.Close();
            kitap_teslim.Visible = true;
            kitap_guncelle.Visible = false;
            kitap_sil.Visible = false;
            okuyucu_guncelle.Visible = false;
            okuyucu_sil.Visible = false;
            kitap_ara.Visible = false;
            okuyucu_ara.Visible = false;
            emanet_ara.Visible = true;
            arsiv_ara.Visible = false;
            emanet_kayit.Visible = false;
            geciken_sil.Visible = false;
            label2.Text = "Üyelik Numarasına \nGöre Emanet Ara";
            emanet_ara.Focus();
        }
        private void teslimEdilenKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.GridColor = Color.Green;
            OleDbDataAdapter verigetir = new OleDbDataAdapter("SELECT * FROM teslim_edilen_kitap", baglanti);
            teslim_edilenler.Clear();
            verigetir.Fill(teslim_edilenler);
            dataGridView1.DataSource = teslim_edilenler;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ÜYELİK NO";
            dataGridView1.Columns[2].HeaderText = "KİTABIN ADI";
            dataGridView1.Columns[3].HeaderText = "YAZARIN ADI";
            dataGridView1.Columns[4].HeaderText = "YAYINEVİ";
            dataGridView1.Columns[5].HeaderText = "KİTABIN TÜRÜ";
            dataGridView1.Columns[6].HeaderText = "KİTABIN KONUSU";
            dataGridView1.Columns[7].HeaderText = "BASKI YERİ";
            dataGridView1.Columns[8].HeaderText = "BASKI SAYISI";
            dataGridView1.Columns[9].HeaderText = "VERİLEN KİTAP SAYISI";
            baglanti.Close();
            kitap_guncelle.Visible = false;
            kitap_sil.Visible = false;
            okuyucu_guncelle.Visible = false;
            okuyucu_sil.Visible = false;
            kitap_ara.Visible = false;
            okuyucu_ara.Visible = false;
            emanet_ara.Visible = false;
            arsiv_ara.Visible = true;
            kitap_teslim.Visible = false;
            emanet_kayit.Visible = false;
            geciken_sil.Visible = false;
            label2.Text = "Üyelik Numarasına \nGöre Arşiv Ara";
            arsiv_ara.Focus();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitap_guncelle.Visible = false;
            kitap_sil.Visible = false;
            okuyucu_guncelle.Visible = false;
            okuyucu_sil.Visible = false;
            kitap_ara.Visible = false;
            okuyucu_ara.Visible = false;
            emanet_ara.Visible = false;
            arsiv_ara.Visible = false;
            kitap_teslim.Visible = false;
            emanet_kayit.Visible = false;
            geciken_sil.Visible = false;
            label2.Text = "";
            dataGridView1.Visible = false;
            k_ekle.ShowDialog();
        }

        private void okuyucuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okuyucu.textBox2.Text = "";
            okuyucu.textBox3.Text = "";
            okuyucu.textBox4.Text = "";
            okuyucu.textBox5.Text = "";
            okuyucu.textBox6.Text = "";
            kitap_guncelle.Visible = false;
            kitap_sil.Visible = false;
            okuyucu_guncelle.Visible = false;
            okuyucu_sil.Visible = false;
            kitap_ara.Visible = false;
            okuyucu_ara.Visible = false;
            emanet_ara.Visible = false;
            arsiv_ara.Visible = false;
            kitap_teslim.Visible = false;
            emanet_kayit.Visible = false;
            geciken_sil.Visible = false;
            label2.Text = "";
            dataGridView1.Visible = false;
            okuyucu.ShowDialog();
        }

        private void tarihiGeçenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true; 
            dataGridView1.GridColor = Color.Red;
            OleDbDataAdapter verigetir = new OleDbDataAdapter("SELECT * FROM geciken_kitap", baglanti);
            gecikenler.Clear();
            verigetir.Fill(gecikenler);
            dataGridView1.DataSource = gecikenler;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ÜYELİK NO";
            dataGridView1.Columns[2].HeaderText = "ÜYENİN ADI";
            dataGridView1.Columns[3].HeaderText = "ÜYENİN SOYADI";
            dataGridView1.Columns[4].HeaderText = "KİTAP ADI";
            dataGridView1.Columns[5].HeaderText = "YAYINEVİ";
            dataGridView1.Columns[6].HeaderText = "KİTABIN TÜRÜ";
            dataGridView1.Columns[7].HeaderText = "BASKI SAYISI";
            dataGridView1.Columns[8].HeaderText = "VERİLEN KİTAP SAYISI";
            dataGridView1.Columns[9].HeaderText = "VERİLME TARİHİ";
            dataGridView1.Columns[10].HeaderText = "İADE TARİHİ";
            baglanti.Close();
            kitap_guncelle.Visible = false;
            kitap_sil.Visible = false;
            okuyucu_guncelle.Visible = false;
            okuyucu_sil.Visible = false;
            kitap_ara.Visible = false;
            okuyucu_ara.Visible = false;
            emanet_ara.Visible = false;
            arsiv_ara.Visible = false;
            kitap_teslim.Visible = false;
            emanet_kayit.Visible = false;
            geciken_sil.Visible = false;
            label2.Text = "";
        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Program kapatılacak. Emin misin?", "Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cevap == DialogResult.Yes)
                this.Close();
        }

        private void okuyucu_sil_Click(object sender, EventArgs e)
        {
            komut.CommandText = "delete from okuyucu where ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            okuyenile();
        }
    }
}
