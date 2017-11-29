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
    public partial class KişiBul : Form
    {
        public KişiBul()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");

        private void KişiBul_Load(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }
        public KişiBul(string filtre)
        {
            InitializeComponent();
            this.filtre = filtre;
        }

        private void verilerigörüntüle()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("Select *From tbÜyeListesi", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Üyeİd"].ToString();
                ekle.SubItems.Add(oku["UyeAdı"].ToString());
                ekle.SubItems.Add(oku["UyeSoyadı"].ToString());
                
                listView1.Items.Add(ekle);

            }
            conn.Close();
        }

        public string ÜyeNo { get; set; }
        public string üyeAdi { get; set; }
        public string ÜyeSoyadi { get; set; }
        string filtre = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ÜyeNo = txtÜyeNo.Text;
            üyeAdi = txtÜyeAdı.Text;
            ÜyeSoyadi = txtÜyeSoyadi.Text;
            this.Close();
        }
        int Üyeİd = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Üyeİd = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtÜyeNo.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtÜyeAdı.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtÜyeSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            
        }
        
    }
}
