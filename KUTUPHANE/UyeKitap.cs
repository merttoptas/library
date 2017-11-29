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

namespace KÜTÜPHANE
{
    public partial class UyeKitap : Form
    {
        public UyeKitap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");
        SqlDataAdapter da;
        DataSet ds;
        private void UyeKitap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");
            conn.Open();
            da = new SqlDataAdapter("Select * from tbKitapAlVer", conn);
            ds = new DataSet();
            da.Fill(ds, "tbKitapAlVer");
            dataGridView1.DataSource = ds.Tables[0];
            DatagridYenile();
            conn.Close();
        }

        protected void DatagridYenile()
        {

            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select id, Uyeİd, kitapİd, UyeAdi, UyeSoyadi, YazarAdi, KitabınAdi, Yayinevi, AlisTarihi, VerisTarihi from tbKitapAlVer", conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
            toolStripStatusLabel2.Text = dataGridView1.RowCount.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("Select *From tbKitapAlVer where UyeAdi like '%" + textBox1.Text + "%'", conn);
            ara.Fill(tbl);

            conn.Close();
            dataGridView1.DataSource = tbl;
        }
    }
}
