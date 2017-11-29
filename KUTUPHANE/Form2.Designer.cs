namespace KÜTÜPHANE
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.lbl_Arama = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yazar_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kitabın_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Türü = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yayınevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sayfa_Sayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basim_Yılı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSİl = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUyeKitap = new System.Windows.Forms.Button();
            this.btnUyeListesi = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKitapSayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BackgroundImage = global::KÜTÜPHANE.Properties.Resources.indir;
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Controls.Add(this.lbl_Arama);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 108);
            this.panel1.TabIndex = 0;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGüncelle.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.btnGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.Image")));
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.Location = new System.Drawing.Point(897, 51);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(102, 29);
            this.btnGüncelle.TabIndex = 7;
            this.btnGüncelle.Text = "   Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lbl_Arama
            // 
            this.lbl_Arama.AutoSize = true;
            this.lbl_Arama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Arama.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbl_Arama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Arama.ImageKey = "(none)";
            this.lbl_Arama.Location = new System.Drawing.Point(347, 61);
            this.lbl_Arama.Name = "lbl_Arama";
            this.lbl_Arama.Size = new System.Drawing.Size(60, 18);
            this.lbl_Arama.TabIndex = 5;
            this.lbl_Arama.Text = "Arama";
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnYeni.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.Location = new System.Drawing.Point(137, 55);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(115, 29);
            this.btnYeni.TabIndex = 1;
            this.btnYeni.Text = "       Üye Kayıt";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapİd,
            this.Yazar_Adi,
            this.Kitabın_Adi,
            this.Türü,
            this.Yayınevi,
            this.Sayfa_Sayisi,
            this.Basim_Yılı});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(137, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(893, 507);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kitapİd
            // 
            this.kitapİd.DataPropertyName = "kitapİd";
            this.kitapİd.HeaderText = "No";
            this.kitapİd.Name = "kitapİd";
            // 
            // Yazar_Adi
            // 
            this.Yazar_Adi.DataPropertyName = "Yazar_Adi";
            this.Yazar_Adi.HeaderText = "Yazarın Adı";
            this.Yazar_Adi.Name = "Yazar_Adi";
            // 
            // Kitabın_Adi
            // 
            this.Kitabın_Adi.DataPropertyName = "Kitabın_Adi";
            this.Kitabın_Adi.HeaderText = "Kitabın Adı";
            this.Kitabın_Adi.Name = "Kitabın_Adi";
            // 
            // Türü
            // 
            this.Türü.DataPropertyName = "Türü";
            this.Türü.HeaderText = "Türü";
            this.Türü.Name = "Türü";
            // 
            // Yayınevi
            // 
            this.Yayınevi.DataPropertyName = "Yayınevi";
            this.Yayınevi.HeaderText = "Yayınevi";
            this.Yayınevi.Name = "Yayınevi";
            // 
            // Sayfa_Sayisi
            // 
            this.Sayfa_Sayisi.DataPropertyName = "Sayfa_Sayisi";
            this.Sayfa_Sayisi.HeaderText = "Sayfa Sayısı";
            this.Sayfa_Sayisi.Name = "Sayfa_Sayisi";
            // 
            // Basim_Yılı
            // 
            this.Basim_Yılı.DataPropertyName = "Basim_Yılı";
            this.Basim_Yılı.HeaderText = "Basım Yılı";
            this.Basim_Yılı.Name = "Basim_Yılı";
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(415, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSİl
            // 
            this.btnSİl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSİl.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.btnSİl.Image = ((System.Drawing.Image)(resources.GetObject("btnSİl.Image")));
            this.btnSİl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSİl.Location = new System.Drawing.Point(776, 51);
            this.btnSİl.Name = "btnSİl";
            this.btnSİl.Size = new System.Drawing.Size(102, 29);
            this.btnSİl.TabIndex = 6;
            this.btnSİl.Text = "Sil";
            this.btnSİl.UseVisualStyleBackColor = false;
            this.btnSİl.Click += new System.EventHandler(this.btnSİl_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnUyeKitap);
            this.panel2.Controls.Add(this.btnUyeListesi);
            this.panel2.Controls.Add(this.btnKitapEkle);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 495);
            this.panel2.TabIndex = 7;
            // 
            // btnUyeKitap
            // 
            this.btnUyeKitap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUyeKitap.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.btnUyeKitap.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeKitap.Image")));
            this.btnUyeKitap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeKitap.Location = new System.Drawing.Point(12, 298);
            this.btnUyeKitap.Name = "btnUyeKitap";
            this.btnUyeKitap.Size = new System.Drawing.Size(117, 42);
            this.btnUyeKitap.TabIndex = 11;
            this.btnUyeKitap.Text = "  Üyelerdeki Kitaplar";
            this.btnUyeKitap.UseVisualStyleBackColor = false;
            this.btnUyeKitap.Click += new System.EventHandler(this.btnUyeKitap_Click);
            // 
            // btnUyeListesi
            // 
            this.btnUyeListesi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUyeListesi.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.btnUyeListesi.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeListesi.Image")));
            this.btnUyeListesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeListesi.Location = new System.Drawing.Point(12, 222);
            this.btnUyeListesi.Name = "btnUyeListesi";
            this.btnUyeListesi.Size = new System.Drawing.Size(117, 29);
            this.btnUyeListesi.TabIndex = 10;
            this.btnUyeListesi.Text = "  Üye Listesi";
            this.btnUyeListesi.UseVisualStyleBackColor = false;
            this.btnUyeListesi.Click += new System.EventHandler(this.btnUyeListesi_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKitapEkle.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.btnKitapEkle.Image = global::KÜTÜPHANE.Properties.Resources.icons8_Library_20;
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapEkle.Location = new System.Drawing.Point(12, 152);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(117, 29);
            this.btnKitapEkle.TabIndex = 9;
            this.btnKitapEkle.Text = "  Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "    Kitap Al/Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblKitapSayisi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 596);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Kitap Sayısı:";
            // 
            // lblKitapSayisi
            // 
            this.lblKitapSayisi.Name = "lblKitapSayisi";
            this.lblKitapSayisi.Size = new System.Drawing.Size(118, 17);
            this.lblKitapSayisi.Text = "toolStripStatusLabel2";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 618);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSİl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yazar_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitabın_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Türü;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yayınevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sayfa_Sayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basim_Yılı;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label lbl_Arama;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSİl;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnUyeListesi;
        private System.Windows.Forms.Button btnUyeKitap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblKitapSayisi;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}