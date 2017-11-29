namespace KÜTÜPHANE
{
    partial class ÜyeListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜyeListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Üyeİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeSoyadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeOkulu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeMeslek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeDogum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeNumara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUyeListesi = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Üyeİd,
            this.UyeAdı,
            this.UyeSoyadı,
            this.UyeCinsiyet,
            this.UyeOkulu,
            this.UyeMeslek,
            this.UyeDogum,
            this.UyeNumara});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(2, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 609);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Üyeİd
            // 
            this.Üyeİd.DataPropertyName = "Üyeİd";
            this.Üyeİd.HeaderText = "No";
            this.Üyeİd.Name = "Üyeİd";
            // 
            // UyeAdı
            // 
            this.UyeAdı.DataPropertyName = "UyeAdı";
            this.UyeAdı.HeaderText = "Adı";
            this.UyeAdı.Name = "UyeAdı";
            // 
            // UyeSoyadı
            // 
            this.UyeSoyadı.DataPropertyName = "UyeSoyadı";
            this.UyeSoyadı.HeaderText = "Soyadı";
            this.UyeSoyadı.Name = "UyeSoyadı";
            // 
            // UyeCinsiyet
            // 
            this.UyeCinsiyet.DataPropertyName = "UyeCinsiyet";
            this.UyeCinsiyet.HeaderText = "Cinsiyeti";
            this.UyeCinsiyet.Name = "UyeCinsiyet";
            // 
            // UyeOkulu
            // 
            this.UyeOkulu.DataPropertyName = "UyeOkulu";
            this.UyeOkulu.HeaderText = "Okulu";
            this.UyeOkulu.Name = "UyeOkulu";
            // 
            // UyeMeslek
            // 
            this.UyeMeslek.DataPropertyName = "UyeMeslek";
            this.UyeMeslek.HeaderText = "Mesleği";
            this.UyeMeslek.Name = "UyeMeslek";
            // 
            // UyeDogum
            // 
            this.UyeDogum.DataPropertyName = "UyeDogum";
            this.UyeDogum.HeaderText = "Doğum Tarihi";
            this.UyeDogum.Name = "UyeDogum";
            // 
            // UyeNumara
            // 
            this.UyeNumara.DataPropertyName = "UyeNumara";
            this.UyeNumara.HeaderText = "İletişim";
            this.UyeNumara.Name = "UyeNumara";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUyeListesi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel1.Text = "Üye Listesi";
            // 
            // lblUyeListesi
            // 
            this.lblUyeListesi.Name = "lblUyeListesi";
            this.lblUyeListesi.Size = new System.Drawing.Size(118, 17);
            this.lblUyeListesi.Text = "toolStripStatusLabel2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::KÜTÜPHANE.Properties.Resources.indir;
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 84);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGüncelle.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.btnGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.Image")));
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.Location = new System.Drawing.Point(602, 46);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(99, 23);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "  Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSil.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(482, 46);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label1.Location = new System.Drawing.Point(105, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Arama:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ÜyeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 679);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ÜyeListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜyeListesi";
            this.Load += new System.EventHandler(this.ÜyeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUyeListesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Üyeİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeSoyadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeOkulu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeMeslek;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeDogum;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeNumara;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}