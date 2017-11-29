namespace KÜTÜPHANE
{
    partial class UyeKitap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uyeİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitabınAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.id,
            this.Uyeİd,
            this.kitapİd,
            this.UyeAdi,
            this.UyeSoyadi,
            this.YazarAdi,
            this.KitabınAdi,
            this.Yayinevi,
            this.AlisTarihi,
            this.VerisTarihi});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(998, 579);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "No";
            this.id.Name = "id";
            // 
            // Uyeİd
            // 
            this.Uyeİd.DataPropertyName = "Uyeİd";
            this.Uyeİd.HeaderText = "Üye No";
            this.Uyeİd.Name = "Uyeİd";
            // 
            // kitapİd
            // 
            this.kitapİd.DataPropertyName = "kitapİd";
            this.kitapİd.HeaderText = "Kitap No";
            this.kitapİd.Name = "kitapİd";
            // 
            // UyeAdi
            // 
            this.UyeAdi.DataPropertyName = "UyeAdi";
            this.UyeAdi.HeaderText = "Adı";
            this.UyeAdi.Name = "UyeAdi";
            // 
            // UyeSoyadi
            // 
            this.UyeSoyadi.DataPropertyName = "UyeSoyadi";
            this.UyeSoyadi.HeaderText = "Soyadı";
            this.UyeSoyadi.Name = "UyeSoyadi";
            // 
            // YazarAdi
            // 
            this.YazarAdi.DataPropertyName = "YazarAdi";
            this.YazarAdi.HeaderText = "Yazar Adı";
            this.YazarAdi.Name = "YazarAdi";
            // 
            // KitabınAdi
            // 
            this.KitabınAdi.DataPropertyName = "KitabınAdi";
            this.KitabınAdi.HeaderText = "Kitabın Adı";
            this.KitabınAdi.Name = "KitabınAdi";
            // 
            // Yayinevi
            // 
            this.Yayinevi.DataPropertyName = "Yayinevi";
            this.Yayinevi.HeaderText = "Yayıevi";
            this.Yayinevi.Name = "Yayinevi";
            // 
            // AlisTarihi
            // 
            this.AlisTarihi.DataPropertyName = "AlisTarihi";
            this.AlisTarihi.HeaderText = "Alış Tarihi";
            this.AlisTarihi.Name = "AlisTarihi";
            // 
            // VerisTarihi
            // 
            this.VerisTarihi.DataPropertyName = "VerisTarihi";
            this.VerisTarihi.HeaderText = "Verilen Tarih";
            this.VerisTarihi.Name = "VerisTarihi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Toplam:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::KÜTÜPHANE.Properties.Resources.indir;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 95);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(464, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(367, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Arama:";
            // 
            // UyeKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UyeKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyelerdeki Kitaplar";
            this.Load += new System.EventHandler(this.UyeKitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uyeİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitabınAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerisTarihi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}