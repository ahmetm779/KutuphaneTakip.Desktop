namespace kütüphane_takip
{
    partial class anaform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.emanet_kayit = new System.Windows.Forms.Button();
            this.kitap_teslim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitap_ara = new System.Windows.Forms.TextBox();
            this.okuyucu_ara = new System.Windows.Forms.TextBox();
            this.emanet_ara = new System.Windows.Forms.TextBox();
            this.arsiv_ara = new System.Windows.Forms.TextBox();
            this.kitap_guncelle = new System.Windows.Forms.Button();
            this.okuyucu_guncelle = new System.Windows.Forms.Button();
            this.kitap_sil = new System.Windows.Forms.Button();
            this.geciken_sil = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitaplarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okuyucuListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimEdilenKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okuyucuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tarihiGeçenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.okuyucu_sil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // emanet_kayit
            // 
            this.emanet_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanet_kayit.Location = new System.Drawing.Point(12, 398);
            this.emanet_kayit.Name = "emanet_kayit";
            this.emanet_kayit.Size = new System.Drawing.Size(93, 69);
            this.emanet_kayit.TabIndex = 3;
            this.emanet_kayit.Text = "Emaneti Kaydet";
            this.emanet_kayit.UseVisualStyleBackColor = true;
            this.emanet_kayit.Visible = false;
            this.emanet_kayit.Click += new System.EventHandler(this.emanet_kayit_Click);
            // 
            // kitap_teslim
            // 
            this.kitap_teslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitap_teslim.Location = new System.Drawing.Point(111, 398);
            this.kitap_teslim.Name = "kitap_teslim";
            this.kitap_teslim.Size = new System.Drawing.Size(113, 69);
            this.kitap_teslim.TabIndex = 4;
            this.kitap_teslim.Text = "Kitap Teslim";
            this.kitap_teslim.UseVisualStyleBackColor = true;
            this.kitap_teslim.Visible = false;
            this.kitap_teslim.Click += new System.EventHandler(this.kitap_teslim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(392, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tarih / Saat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1123, 189);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            // 
            // kitap_ara
            // 
            this.kitap_ara.Location = new System.Drawing.Point(12, 183);
            this.kitap_ara.Name = "kitap_ara";
            this.kitap_ara.Size = new System.Drawing.Size(127, 20);
            this.kitap_ara.TabIndex = 19;
            this.kitap_ara.Visible = false;
            this.kitap_ara.TextChanged += new System.EventHandler(this.kitap_ara_TextChanged);
            // 
            // okuyucu_ara
            // 
            this.okuyucu_ara.Location = new System.Drawing.Point(12, 183);
            this.okuyucu_ara.Name = "okuyucu_ara";
            this.okuyucu_ara.Size = new System.Drawing.Size(127, 20);
            this.okuyucu_ara.TabIndex = 21;
            this.okuyucu_ara.Visible = false;
            this.okuyucu_ara.TextChanged += new System.EventHandler(this.okuyucu_ara_TextChanged);
            // 
            // emanet_ara
            // 
            this.emanet_ara.Location = new System.Drawing.Point(12, 183);
            this.emanet_ara.Name = "emanet_ara";
            this.emanet_ara.Size = new System.Drawing.Size(127, 20);
            this.emanet_ara.TabIndex = 23;
            this.emanet_ara.Visible = false;
            this.emanet_ara.TextChanged += new System.EventHandler(this.emanet_ara_TextChanged);
            // 
            // arsiv_ara
            // 
            this.arsiv_ara.Location = new System.Drawing.Point(12, 183);
            this.arsiv_ara.Name = "arsiv_ara";
            this.arsiv_ara.Size = new System.Drawing.Size(128, 20);
            this.arsiv_ara.TabIndex = 25;
            this.arsiv_ara.Visible = false;
            this.arsiv_ara.TextChanged += new System.EventHandler(this.arsiv_ara_TextChanged);
            // 
            // kitap_guncelle
            // 
            this.kitap_guncelle.Location = new System.Drawing.Point(164, 170);
            this.kitap_guncelle.Name = "kitap_guncelle";
            this.kitap_guncelle.Size = new System.Drawing.Size(107, 33);
            this.kitap_guncelle.TabIndex = 26;
            this.kitap_guncelle.Text = "Kitap Güncelle";
            this.kitap_guncelle.UseVisualStyleBackColor = true;
            this.kitap_guncelle.Visible = false;
            this.kitap_guncelle.Click += new System.EventHandler(this.kitap_guncelle_Click);
            // 
            // okuyucu_guncelle
            // 
            this.okuyucu_guncelle.Location = new System.Drawing.Point(164, 170);
            this.okuyucu_guncelle.Name = "okuyucu_guncelle";
            this.okuyucu_guncelle.Size = new System.Drawing.Size(107, 33);
            this.okuyucu_guncelle.TabIndex = 27;
            this.okuyucu_guncelle.Text = "Okuyucu Güncelle";
            this.okuyucu_guncelle.UseVisualStyleBackColor = true;
            this.okuyucu_guncelle.Visible = false;
            this.okuyucu_guncelle.Click += new System.EventHandler(this.okuyucu_guncelle_Click);
            // 
            // kitap_sil
            // 
            this.kitap_sil.Location = new System.Drawing.Point(277, 170);
            this.kitap_sil.Name = "kitap_sil";
            this.kitap_sil.Size = new System.Drawing.Size(107, 33);
            this.kitap_sil.TabIndex = 28;
            this.kitap_sil.Text = "Kitap Sil";
            this.kitap_sil.UseVisualStyleBackColor = true;
            this.kitap_sil.Visible = false;
            this.kitap_sil.Click += new System.EventHandler(this.kitap_sil_Click);
            // 
            // geciken_sil
            // 
            this.geciken_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geciken_sil.Location = new System.Drawing.Point(230, 398);
            this.geciken_sil.Name = "geciken_sil";
            this.geciken_sil.Size = new System.Drawing.Size(112, 69);
            this.geciken_sil.TabIndex = 30;
            this.geciken_sil.Text = "Geciken Kitabı Sil";
            this.geciken_sil.UseVisualStyleBackColor = true;
            this.geciken_sil.Visible = false;
            this.geciken_sil.Click += new System.EventHandler(this.geciken_sil_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarıListeleToolStripMenuItem,
            this.okuyucuListesiToolStripMenuItem,
            this.emanetKitaplarToolStripMenuItem,
            this.teslimEdilenKitaplarToolStripMenuItem,
            this.kitapEkleToolStripMenuItem,
            this.okuyucuEkleToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.tarihiGeçenlerToolStripMenuItem,
            this.programıKapatToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1147, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitaplarıListeleToolStripMenuItem
            // 
            this.kitaplarıListeleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.kitaplarıListeleToolStripMenuItem.Image = global::kütüphane_takip.Properties.Resources.icon_books;
            this.kitaplarıListeleToolStripMenuItem.Name = "kitaplarıListeleToolStripMenuItem";
            this.kitaplarıListeleToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.kitaplarıListeleToolStripMenuItem.Text = "Kitapları Listele";
            this.kitaplarıListeleToolStripMenuItem.Click += new System.EventHandler(this.kitaplarıListeleToolStripMenuItem_Click);
            // 
            // okuyucuListesiToolStripMenuItem
            // 
            this.okuyucuListesiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.okuyucuListesiToolStripMenuItem.Image = global::kütüphane_takip.Properties.Resources.okuyucu_listele;
            this.okuyucuListesiToolStripMenuItem.Name = "okuyucuListesiToolStripMenuItem";
            this.okuyucuListesiToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.okuyucuListesiToolStripMenuItem.Text = "Okuyucu Listesi";
            this.okuyucuListesiToolStripMenuItem.Click += new System.EventHandler(this.okuyucuListesiToolStripMenuItem_Click);
            // 
            // emanetKitaplarToolStripMenuItem
            // 
            this.emanetKitaplarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.emanetKitaplarToolStripMenuItem.Image = global::kütüphane_takip.Properties.Resources.emanet_liste;
            this.emanetKitaplarToolStripMenuItem.Name = "emanetKitaplarToolStripMenuItem";
            this.emanetKitaplarToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.emanetKitaplarToolStripMenuItem.Text = "Emanet Kitaplar";
            this.emanetKitaplarToolStripMenuItem.Click += new System.EventHandler(this.emanetKitaplarToolStripMenuItem_Click);
            // 
            // teslimEdilenKitaplarToolStripMenuItem
            // 
            this.teslimEdilenKitaplarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.teslimEdilenKitaplarToolStripMenuItem.Image = global::kütüphane_takip.Properties.Resources.Clipper_System_1_Go;
            this.teslimEdilenKitaplarToolStripMenuItem.Name = "teslimEdilenKitaplarToolStripMenuItem";
            this.teslimEdilenKitaplarToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.teslimEdilenKitaplarToolStripMenuItem.Text = "Teslim Edilen Kitaplar";
            this.teslimEdilenKitaplarToolStripMenuItem.Click += new System.EventHandler(this.teslimEdilenKitaplarToolStripMenuItem_Click);
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.kitapEkleToolStripMenuItem.Image = global::kütüphane_takip.Properties.Resources.book_add;
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // okuyucuEkleToolStripMenuItem
            // 
            this.okuyucuEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.okuyucuEkleToolStripMenuItem.Image = global::kütüphane_takip.Properties.Resources.user;
            this.okuyucuEkleToolStripMenuItem.Name = "okuyucuEkleToolStripMenuItem";
            this.okuyucuEkleToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.okuyucuEkleToolStripMenuItem.Text = "Okuyucu Ekle";
            this.okuyucuEkleToolStripMenuItem.Click += new System.EventHandler(this.okuyucuEkleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.Image = global::kütüphane_takip.Properties.Resources.geciken;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(139, 24);
            this.toolStripMenuItem2.Text = "Tarihi Geçenler";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.tarihiGeçenlerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Image = global::kütüphane_takip.Properties.Resources.Comic_Icons_3_button_cancel1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 24);
            this.toolStripMenuItem1.Text = "Programı Kapat";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.programıKapatToolStripMenuItem_Click);
            // 
            // tarihiGeçenlerToolStripMenuItem
            // 
            this.tarihiGeçenlerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihiGeçenlerToolStripMenuItem.Image = global::kütüphane_takip.Properties.Resources.geciken;
            this.tarihiGeçenlerToolStripMenuItem.Name = "tarihiGeçenlerToolStripMenuItem";
            this.tarihiGeçenlerToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.tarihiGeçenlerToolStripMenuItem.Text = "Tarihi Geçenler";
            this.tarihiGeçenlerToolStripMenuItem.Click += new System.EventHandler(this.tarihiGeçenlerToolStripMenuItem_Click);
            // 
            // programıKapatToolStripMenuItem
            // 
            this.programıKapatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programıKapatToolStripMenuItem.Image = global::kütüphane_takip.Properties.Resources.Comic_Icons_3_button_cancel1;
            this.programıKapatToolStripMenuItem.Name = "programıKapatToolStripMenuItem";
            this.programıKapatToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.programıKapatToolStripMenuItem.Text = "Programı Kapat";
            this.programıKapatToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.programıKapatToolStripMenuItem.Click += new System.EventHandler(this.programıKapatToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 32;
            // 
            // okuyucu_sil
            // 
            this.okuyucu_sil.Location = new System.Drawing.Point(277, 169);
            this.okuyucu_sil.Name = "okuyucu_sil";
            this.okuyucu_sil.Size = new System.Drawing.Size(107, 34);
            this.okuyucu_sil.TabIndex = 33;
            this.okuyucu_sil.Text = "Okuyucu Sil";
            this.okuyucu_sil.UseVisualStyleBackColor = true;
            this.okuyucu_sil.Visible = false;
            this.okuyucu_sil.Click += new System.EventHandler(this.okuyucu_sil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::kütüphane_takip.Properties.Resources.kitap__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1147, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 479);
            this.Controls.Add(this.okuyucu_sil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.geciken_sil);
            this.Controls.Add(this.kitap_sil);
            this.Controls.Add(this.okuyucu_guncelle);
            this.Controls.Add(this.kitap_guncelle);
            this.Controls.Add(this.arsiv_ara);
            this.Controls.Add(this.emanet_ara);
            this.Controls.Add(this.okuyucu_ara);
            this.Controls.Add(this.kitap_ara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitap_teslim);
            this.Controls.Add(this.emanet_kayit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "anaform";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "            KÜTÜPHANE TAKİP PROGRAMI ANA FORMU";
            this.Load += new System.EventHandler(this.anaform_Load);
            this.Shown += new System.EventHandler(this.anaform_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button okuyucu_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button geciken_sil;
        private System.Windows.Forms.ToolStripMenuItem kitaplarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okuyucuListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimEdilenKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okuyucuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarihiGeçenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programıKapatToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button kitap_guncelle;
        public System.Windows.Forms.Button okuyucu_guncelle;
        public System.Windows.Forms.Button kitap_sil;
        public System.Windows.Forms.TextBox kitap_ara;
        public System.Windows.Forms.TextBox okuyucu_ara;
        public System.Windows.Forms.TextBox emanet_ara;
        public System.Windows.Forms.TextBox arsiv_ara;
        public System.Windows.Forms.Button emanet_kayit;
        public System.Windows.Forms.Button kitap_teslim;
        private System.Windows.Forms.Button okuyucu_sil;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

