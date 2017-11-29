namespace KÜTÜPHANE
{
    partial class KişiBul
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
            this.txtÜyeSoyadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtÜyeAdı = new System.Windows.Forms.TextBox();
            this.txtÜyeNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtÜyeSoyadi
            // 
            this.txtÜyeSoyadi.Location = new System.Drawing.Point(136, 108);
            this.txtÜyeSoyadi.Name = "txtÜyeSoyadi";
            this.txtÜyeSoyadi.Size = new System.Drawing.Size(200, 20);
            this.txtÜyeSoyadi.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.label9.Location = new System.Drawing.Point(37, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Üye Soyadı:";
            // 
            // txtÜyeAdı
            // 
            this.txtÜyeAdı.Location = new System.Drawing.Point(136, 73);
            this.txtÜyeAdı.Name = "txtÜyeAdı";
            this.txtÜyeAdı.Size = new System.Drawing.Size(200, 20);
            this.txtÜyeAdı.TabIndex = 22;
            // 
            // txtÜyeNo
            // 
            this.txtÜyeNo.Location = new System.Drawing.Point(136, 31);
            this.txtÜyeNo.Name = "txtÜyeNo";
            this.txtÜyeNo.Size = new System.Drawing.Size(200, 20);
            this.txtÜyeNo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.label5.Location = new System.Drawing.Point(61, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Üye Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Üye No:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.listView1.Location = new System.Drawing.Point(-2, 211);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(529, 255);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Üye No";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Üye Adı";
            this.columnHeader2.Width = 189;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Üye Soyadı";
            this.columnHeader3.Width = 191;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.btnKaydet.Image = global::KÜTÜPHANE.Properties.Resources.disk_icon__1_;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(385, 89);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 39);
            this.btnKaydet.TabIndex = 32;
            this.btnKaydet.Text = "     Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // KişiBul
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(525, 463);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtÜyeSoyadi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtÜyeAdı);
            this.Controls.Add(this.txtÜyeNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "KişiBul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bul";
            this.Load += new System.EventHandler(this.KişiBul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.TextBox txtÜyeSoyadi;
        public System.Windows.Forms.TextBox txtÜyeAdı;
        public System.Windows.Forms.TextBox txtÜyeNo;
    }
}