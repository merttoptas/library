using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace KÜTÜPHANE
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");
        public Form2()
        {
            InitializeComponent();
        }
        protected void DatagridYenile()
        {

            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select kitapİd, Yazar_Adi, Kitabın_Adi, Türü, Yayınevi, Sayfa_Sayisi, Basim_Yılı from tbBilgiler ", conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
            lblKitapSayisi.Text = dataGridView1.Rows.Count.ToString();
           }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapAlVer ac = new KitapAlVer();
            ac.ShowDialog();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            getir();
            KitapEkle ac = new KitapEkle();
            ac.ShowDialog();
            conn.Close();
            DatagridYenile();

        }
        private void getir()
        {
            // Get All Books SQL Clause 
            // SOLID , KIST , DRY , YAGNI
            string komut = "Select * from tbBilgiler";
            SqlDataAdapter da = new SqlDataAdapter(komut, conn);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            conn.Close();
        }
        private void btnUyeListesi_Click(object sender, EventArgs e)
        {
            ÜyeListesi ac = new ÜyeListesi();
            ac.ShowDialog();
        }

        private void btnUyeKitap_Click(object sender, EventArgs e)
        {
            UyeKitap ac = new UyeKitap();
            ac.ShowDialog();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            conn.Open();
            YeniKayıt ac = new YeniKayıt();
            ac.ShowDialog();
            conn.Close();
            DatagridYenile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("Select *From tbBilgiler where Yazar_Adi like '%" + textBox1.Text + "%'", conn);
            ara.Fill(tbl);

            conn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridYenile();
        }
        SqlDataAdapter da;
        DataSet ds;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");
            conn.Open();
            da = new SqlDataAdapter("Select * from tbBilgiler", conn);
            ds = new DataSet();
            da.Fill(ds, "tbBilgiler");
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            DatagridYenile();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //cmdb = new SqlCommandBuilder(da);
            //da.Update(ds, "tbBilgiler");

            //conn.Close();
            //DatagridYenile();
            //MessageBox.Show("Kayıt güncellendi");

            // ac ile kitapekle formunu açma komutu verdik.
            // texbotların textlerini, datagridviewdeki sütün ve satırlara göre yazdık ve stringe çevirdik.
            // tag ile girdinin okunmasını sağladık.

            KitapEkle ac = new KitapEkle();
            ac.Text = "Güncelle";
            ac.Txt_Adi.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ac.Txt_Adi.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            ac.Txt_Kitabın_Adi.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ac.Txt_Kitabın_Adi.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            ac.Txt_Türü.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            ac.Txt_Türü.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            ac.Txt_Yayinevi.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            ac.Txt_Yayinevi.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            ac.Txt_Sayfa_Sayisi.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            ac.Txt_Sayfa_Sayisi.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            ac.Txt_Basım_Yılı.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            ac.Txt_Basım_Yılı.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ac.ShowDialog();
            DatagridYenile();
        }

        private void btnSİl_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  tbBilgiler where kitapİd=" + dataGridView1.CurrentRow.Cells["kitapİd"].Value.ToString(), conn);
            kmt.ExecuteNonQuery();
            conn.Close();
            DatagridYenile();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            KitapAlVer ac = new KitapAlVer();
            ac.ShowDialog();
        }
    }
}
