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

    public partial class KitapAlVer : Form
    {
        public KitapAlVer()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");

                    SqlCommand komut = new SqlCommand();
                    komut.Connection = conn;
                    komut.CommandText = "INSERT INTO tbKitapAlVer (Uyeİd,kitapİd,UyeAdi,UyeSoyadi,YazarAdi, KitabınAdi, Yayinevi,AlisTarihi ) VALUES(@uyeİd,@kitapİd, @uyeadi, @uyesoyadi, @yazaradi, @kitapadi, @yayinevi,@alistarihi )";

                    komut.Parameters.Add("@uyeİd", SqlDbType.Int);
                    komut.Parameters["@uyeİd"].Value = Convert.ToInt32(txt_ÜyeNo.Text.Trim());

                    komut.Parameters.Add("@kitapİd", SqlDbType.Int);
                    komut.Parameters["@kitapİd"].Value = Convert.ToInt32(txtKitapNoo.Text.Trim());

                    komut.Parameters.Add("@uyeadi", SqlDbType.NChar);
                    komut.Parameters["@uyeadi"].Value = txt_ÜyeAdı.Text.Trim();

                    komut.Parameters.Add("@uyesoyadi", SqlDbType.NChar);
                    komut.Parameters["@uyesoyadi"].Value = txt_ÜyeSoyadi.Text.Trim();

                    komut.Parameters.Add("@kitapadi", SqlDbType.NChar);
                    komut.Parameters["@kitapadi"].Value = txtKitapAdi.Text.Trim();

                    komut.Parameters.Add("@yayinevi", SqlDbType.NChar);
                    komut.Parameters["@yayinevi"].Value = txtYayinevi.Text.Trim();

                    komut.Parameters.Add("@yazaradi", SqlDbType.NChar);
                    komut.Parameters["@yazaradi"].Value = txtYazarAdi.Text.Trim();
                    
                    komut.Parameters.AddWithValue("@alistarihi", (dateTimePicker1.Value.ToString("dd/MM/yyyy")));

                    conn.Open();
                    komut.ExecuteNonQuery();
                    conn.Close();
                    komut.Parameters.Clear();
                    DatagridYenile();
                    txtKitapAdi.Clear();
                    txtKitapNoo.Clear();
                    txtYayinevi.Clear();
                    txtYazarAdi.Clear();
                    txt_ÜyeAdı.Clear();
                    txt_ÜyeNo.Clear();
                    txt_ÜyeSoyadi.Clear();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hata", ex.ToString());
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");

                SqlCommand komut = new SqlCommand();
                komut.Connection = conn;
                komut.CommandText = "INSERT INTO tbKitapAlVer (Uyeİd,kitapİd,UyeAdi,UyeSoyadi,YazarAdi, KitabınAdi, Yayinevi, VerisTarihi ) VALUES(@uyeİd,@kitapİd, @uyeadi, @uyesoyadi, @yazaradi, @kitapadi, @yayinevi,@veristarihi )";

                komut.Parameters.Add("@uyeİd", SqlDbType.Int);
                komut.Parameters["@uyeİd"].Value = Convert.ToInt32(txt_ÜyeNo.Text.Trim());

                komut.Parameters.Add("@kitapİd", SqlDbType.Int);
                komut.Parameters["@kitapİd"].Value = Convert.ToInt32(txtKitapNoo.Text.Trim());

                komut.Parameters.Add("@uyeadi", SqlDbType.NChar);
                komut.Parameters["@uyeadi"].Value = txt_ÜyeAdı.Text.Trim();

                komut.Parameters.Add("@uyesoyadi", SqlDbType.NChar);
                komut.Parameters["@uyesoyadi"].Value = txt_ÜyeSoyadi.Text.Trim();

                komut.Parameters.Add("@kitapadi", SqlDbType.NChar);
                komut.Parameters["@kitapadi"].Value = txtKitapAdi.Text.Trim();

                komut.Parameters.Add("@yayinevi", SqlDbType.NChar);
                komut.Parameters["@yayinevi"].Value = txtYayinevi.Text.Trim();

                komut.Parameters.Add("@yazaradi", SqlDbType.NChar);
                komut.Parameters["@yazaradi"].Value = txtYazarAdi.Text.Trim();
                komut.Parameters.AddWithValue("@veristarihi", (dateTimePicker1.Value.Date));

                conn.Open();
                komut.ExecuteNonQuery();
                komut.Parameters.Clear();
                DatagridYenile();
                conn.Close();
                txtKitapAdi.Clear();
                txtKitapNoo.Clear();
                txtYayinevi.Clear();
                txtYazarAdi.Clear();
                txt_ÜyeAdı.Clear();
                txt_ÜyeNo.Clear();
                txt_ÜyeSoyadi.Clear();
            }

        }
        
        SqlDataAdapter da;
        DataSet ds;
        
        private void KitapAlVer_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
           
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
            lblToplamSayi.Text = dataGridView1.RowCount.ToString();
        }
        //Her Yönüyle C# Sefer Algan
        //C# Cilt 1 Cilt 2 Ahmet Kaymaz
        //Sql Server 2016 ile sorgulama ve programlama İsmail Adar
        //youtube channel : kudvenkat (basic english)
        //youtube channel : bilgisayar kavramları

        private void txt_KitapNo_TextChanged(object sender, EventArgs e)
        {
         
        }
        string filtre = "";
        private void btnBül_Click(object sender, EventArgs e)
        {
            // this.Close();
            //string format {0}
            filtre = string.Format("Kitabın_Adi LIKE '%{0}%' AND Yazar_Adi LIKE '%{1}%' ", txtKitapAdi.Text, txtYazarAdi.Text);

            Bul ac = new Bul(filtre);
            ac.ShowDialog();

            txtKitapNoo.Text = ac.kitapNo;
            txtKitapAdi.Text = ac.kitapAdi;
            txtYayinevi.Text = ac.yayinEvi;
            txtYazarAdi.Text = ac.yazarAdi;

            ac.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridYenile();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            filtre = string.Format("UyeAdı LIKE '%{0}%' AND UyeSoyadı LIKE '%{1}%' ", txt_ÜyeNo.Text, txt_ÜyeSoyadi.Text);
            KişiBul ac = new KişiBul(filtre);
            ac.ShowDialog();

            txt_ÜyeNo.Text = ac.ÜyeNo;
            txt_ÜyeAdı.Text = ac.üyeAdi;
            txt_ÜyeSoyadi.Text = ac.ÜyeSoyadi;
             ac.Dispose();
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                conn.Open();
                SqlCommand kmt = new SqlCommand("UPDATE tbKitapAlVer SET Uyeİd ='" + txt_ÜyeNo.Text + "',kitapid= '" + txtKitapNoo.Text + "', UyeAdi= '" + txt_ÜyeAdı.Text + "', UyeSoyadi= '" + txt_ÜyeSoyadi.Text + "', YazarAdi= '" + txtYazarAdi.Text + "', KitabınAdi= '" + txtKitapAdi.Text + "', Yayinevi = '" + txtYayinevi.Text + "', AlisTarihi = '" +dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm:ss") + "' where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);

                kmt.ExecuteNonQuery();
                DatagridYenile();
                conn.Close();
              
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("UPDATE tbKitapAlVer SET Uyeİd ='" + txt_ÜyeNo.Text + "',kitapid= '" + txtKitapNoo.Text + "', UyeAdi= '" + txt_ÜyeAdı.Text + "', UyeSoyadi= '" + txt_ÜyeSoyadi.Text + "', YazarAdi= '" + txtYazarAdi.Text + "', KitabınAdi= '" + txtKitapAdi.Text + "', Yayinevi = '" + txtYayinevi.Text + "', VerisTarihi = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm:ss") + "' where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
               
                kmt.ExecuteNonQuery();
                DatagridYenile();
                conn.Close();
               
            }

        }
       
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_ÜyeNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_ÜyeNo.Tag= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            txtKitapNoo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtKitapNoo.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            txt_ÜyeAdı.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_ÜyeAdı.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_ÜyeSoyadi.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_ÜyeSoyadi.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtYazarAdi.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtYazarAdi.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtKitapAdi.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtKitapAdi.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtYayinevi.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtYayinevi.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE tbKitapAlVer where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
            kmt.ExecuteNonQuery();
            conn.Close();
            DatagridYenile();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("Select *From tbKitapAlVer where UyeAdi  like '%" + textBox1.Text + "%'", conn);
            ara.Fill(tbl);

            conn.Close();
            dataGridView1.DataSource = tbl;
        }

       

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
  }

