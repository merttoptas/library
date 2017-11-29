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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");

        protected void DatagridYenile()
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select kitapİd, Yazar_Adi, Kitabın_Adi, Türü, Yayınevi, Sayfa_Sayisi,Basim_Yılı from tbBilgiler ", conn);
            adptr.Fill(tbl);
            conn.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (this.Text == "Ekle")
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");

                    SqlCommand komut = new SqlCommand();
                    komut.Connection = conn;
                    komut.CommandText = "INSERT INTO tbBilgiler (Yazar_Adi,Kitabın_Adi,Türü,Yayınevi,Sayfa_Sayisi,Basim_Yılı) VALUES(@yazaradi, @kitapadi,@türü, @yayinevi, @sayfasayisi, @basimyılı)";
                    komut.Parameters.Add("@yazaradi", SqlDbType.NChar);
                    komut.Parameters["@yazaradi"].Value = Txt_Adi.Text.Trim();
                    komut.Parameters.Add("@kitapadi", SqlDbType.NChar);
                    komut.Parameters["@kitapadi"].Value = Txt_Kitabın_Adi.Text.Trim();
                    komut.Parameters.Add("@türü", SqlDbType.NChar);
                    komut.Parameters["@türü"].Value = Txt_Türü.Text.Trim();
                    komut.Parameters.Add("@yayinevi", SqlDbType.NChar);
                    komut.Parameters["@yayinevi"].Value = Txt_Yayinevi.Text.Trim();
                    komut.Parameters.Add("@sayfasayisi", SqlDbType.Int);
                    komut.Parameters["@sayfasayisi"].Value = Convert.ToInt32(Txt_Sayfa_Sayisi.Text.Trim());
                    komut.Parameters.Add("@basimyılı", SqlDbType.Int);
                    komut.Parameters["@basimyılı"].Value = Convert.ToInt32(Txt_Basım_Yılı.Text.Trim());
                    conn.Open();
                    komut.ExecuteNonQuery();
                    conn.Close();

                    DatagridYenile();
                    this.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("hata", ex.ToString());
                }
            }
            else if (this.Text == "Güncelle")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format("UPDATE tbBilgiler SET Yazar_Adi = '{0}', Kitabın_Adi = '{1}', Türü = '{2}',Yayınevi = '{3}',Sayfa_Sayisi = '{4}',Basim_Yılı = '{5}' WHERE kitapİd = {6}", Txt_Adi.Text, Txt_Kitabın_Adi.Text, Txt_Türü.Text, Txt_Yayinevi.Text, Txt_Sayfa_Sayisi.Text, Txt_Basım_Yılı.Text, Txt_Kitabın_Adi.Tag.ToString(), Txt_Türü.Tag.ToString(), Txt_Yayinevi.Tag.ToString(), Txt_Sayfa_Sayisi.Tag.ToString(), Txt_Basım_Yılı.Tag.ToString(), Txt_Adi.Tag.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("GÜNCELLEME İŞLEMİ");
                this.Close();
            }

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            DatagridYenile();
        }
    }
    }

