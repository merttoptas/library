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
    public partial class YeniKayıt : Form
    {
        
        public YeniKayıt()
        {
            InitializeComponent();
           
        }
        SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");
       
        private void YeniKayıt_Load(object sender, EventArgs e)
        {

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm:ss";



        }
        protected void DatagridYenile()
        {

            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select Üyeİd, UyeAdı, UyeSoyadı, UyeCinsiyet, UyeOkulu, UyeMeslek, UyeDogum,UyeNumara from tbÜyeListesi ", conn);
            adptr.Fill(tbl);
            conn.Close();

        }
        string UyeCinsiyet;
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (this.Text == "Üye Kayıt")

                try
                {
                    // tabcontrol1.selectedIndex ile tabcontrollerin içine girdik ve girdiyi çektik.
                    tabControl1.SelectedIndex = 1;
                    tabControl1.SelectedIndex = 2;
                    tabControl1.SelectedIndex = 3;
                    SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");

                    SqlCommand komut = new SqlCommand();
                    komut.Connection = conn;
                    komut.CommandText = "INSERT INTO tbÜyeListesi (UyeAdı,UyeSoyadı,UyeOkulu,UyeMeslek,UyeDogum,UyeNumara,UyeCinsiyet) VALUES(@adı, @soyadı,@okulu, @meslek, @dogum, @numara, @cinsiyet)";
                    komut.Parameters.Add("@adı", SqlDbType.NChar);
                    komut.Parameters["@adı"].Value = txtUyeAdı.Text.Trim();
                    komut.Parameters.Add("@soyadı", SqlDbType.NChar);
                    komut.Parameters["@soyadı"].Value = txtUyeSoyadı.Text.Trim();
                    komut.Parameters.Add("@okulu", SqlDbType.NChar);
                    komut.Parameters["@okulu"].Value = txtOkul.Text.Trim();
                    komut.Parameters.Add("@meslek", SqlDbType.NChar);
                    komut.Parameters["@meslek"].Value = txtMeslek.Text.Trim();
                    komut.Parameters.AddWithValue("@dogum", (dateTimePicker2.Value.ToString(("dd/MM/yyyy"))));
                    komut.Parameters.Add("@numara", SqlDbType.NChar);
                    komut.Parameters["@numara"].Value = maskedTextBox2.Text;
                    komut.Parameters.Add("@cinsiyet", SqlDbType.NChar);
                    komut.Parameters["@cinsiyet"].Value = UyeCinsiyet;

                    conn.Open();
                    komut.ExecuteNonQuery();
                    DatagridYenile();
                    conn.Close();

                    this.Close();
                    ÜyeListesi ac = new ÜyeListesi();
                    ac.ShowDialog();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("hata", ex.ToString());
                }

            else if (this.Text == "Güncelle")
            {
                if (radioButton1.Checked == true)
                {
                    tabControl1.SelectedIndex = 1;
                    tabControl1.SelectedIndex = 2;
                    tabControl1.SelectedIndex = 3;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("UPDATE tbÜyeListesi SET UyeAdı = '{0}', UyeSoyadı = '{1}', UyeCinsiyet = '{2}',UyeOkulu = '{3}',UyeMeslek = '{4}',UyeDogum = '{5}' , UyeNumara='{6}' WHERE Üyeİd = {7}", txtUyeAdı.Text, txtUyeSoyadı.Text, UyeCinsiyet, txtOkul.Text, txtMeslek.Text, dateTimePicker2.Value.ToString("dd/MM/yyyy"), maskedTextBox2.Text, txtUyeAdı.Tag.ToString(), txtUyeSoyadı.Tag.ToString(), txtOkul.Tag.ToString(), txtMeslek.Tag.ToString());
                    cmd.ExecuteNonQuery();
                    
                    conn.Close();
                                        
                    MessageBox.Show("Güncellendi");
                    this.Close();

                }
               else if (radioButton2.Checked == true)
                {
                    tabControl1.SelectedIndex = 1;
                    tabControl1.SelectedIndex = 2;
                    tabControl1.SelectedIndex = 3;
                    conn.Open();
               
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("UPDATE tbÜyeListesi SET UyeAdı = '{0}', UyeSoyadı = '{1}', UyeCinsiyet = '{2}',UyeOkulu = '{3}',UyeMeslek = '{4}',UyeDogum = '{5}' , UyeNumara='{6}' WHERE Üyeİd = {7}", txtUyeAdı.Text, txtUyeSoyadı.Text, UyeCinsiyet, txtOkul.Text, txtMeslek.Text, dateTimePicker2.Value.ToString("dd/MM/yyyy"), maskedTextBox2.Text, txtUyeAdı.Tag.ToString(), txtUyeSoyadı.Tag.ToString(), txtOkul.Tag.ToString(), txtMeslek.Tag.ToString());
                    cmd.ExecuteNonQuery();
                    
                    conn.Close();

                    MessageBox.Show("Güncellendi");
                    this.Close();
                    
                    
                }
            }
        }
       
        

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
                   

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            txtUyeAdı.Clear();
            txtUyeSoyadı.Clear();
          
            txtMeslek.Clear();
            txtOkul.Clear();
            maskedTextBox2.Clear();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UyeCinsiyet = "Erkek";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UyeCinsiyet = "Kadın";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

              private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
