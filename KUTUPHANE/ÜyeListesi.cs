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
    public partial class ÜyeListesi : Form
    {
        public ÜyeListesi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected void DatagridYenile()
        {

            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select Üyeİd, UyeAdı, UyeSoyadı, UyeCinsiyet, UyeOkulu, UyeMeslek, UyeDogum,UyeNumara from  tbÜyeListesi ", conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
            lblUyeListesi.Text = dataGridView1.RowCount.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ÜyeListesi_Load(object sender, EventArgs e)
        {
           
            conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");
            conn.Open();
            da = new SqlDataAdapter("Select * from tbÜyeListesi", conn);
            ds = new DataSet();
            da.Fill(ds, "tbÜyeListesi");
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            DatagridYenile();
           
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridYenile();
        }
        SqlDataAdapter da;
        DataSet ds;
      
        private void btnSil_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE tbÜyeListesi where Üyeid=" + dataGridView1.CurrentRow.Cells["Üyeİd"].Value.ToString(), conn);
            kmt.ExecuteNonQuery();
            conn.Close();
            DatagridYenile();

        }
        
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //string  kayit kmt = new SqlCommand (" Update tbÜyeListesi set UyeAdı ='"  ")
            //builder = new SqlCommandBuilder(da);
            //da.Update(ds, "tbÜyeListesi");
            //MessageBox.Show("Güncellendi");

            YeniKayıt ac = new YeniKayıt ();
            ac.Text = "Güncelle";
            ac.txtUyeAdı.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ac.txtUyeAdı.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            ac.txtUyeSoyadı.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ac.txtUyeSoyadı.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            ac.txtOkul.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            ac.txtOkul.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            ac.txtMeslek.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            ac.txtMeslek.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            ac.dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            ac.dateTimePicker2.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            ac.maskedTextBox2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            ac.maskedTextBox2.Tag = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            ac.ShowDialog();
            DatagridYenile();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("Select *From tbÜyeListesi where UyeAdı like '%" + textBox1.Text + "%'", conn);
            ara.Fill(tbl);

            conn.Close();
            dataGridView1.DataSource = tbl;
        }

    }

}


