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
    public partial class Bul : Form
    {
        public Bul()
        {
            InitializeComponent();
        }
        public Bul(string filtre)
        {
            InitializeComponent();
            this.filtre = filtre;
        }
        SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = kütüphane; Integrated Security = True; ");
        // Her Yönüyle C# - Sefer Algan
        // Encapsulation OOP temel prensiplerinden bir tanesi sarmalama kapsülleme olarak çevrilir türkçe'ye get set properties konularını o başlık altında
        //daha iyi anlayacaksın.
        public string kitapNo { get; set; }
        public string yazarAdi { get; set; }
        public string kitapAdi { get; set; }
        public string yayinEvi { get; set; }

        private void Bul_Load(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }
        string filtre = "";
        private void verilerigörüntüle()
        {
            
            conn.Open();
            SqlCommand komut = new SqlCommand("Select *From tbBilgiler where "+ filtre , conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kitapİd"].ToString();
                ekle.SubItems.Add(oku["Yazar_Adi"].ToString());
                ekle.SubItems.Add(oku["Kitabın_Adi"].ToString());
                ekle.SubItems.Add(oku["Yayınevi"].ToString());
                listView1.Items.Add(ekle);
                
            }
            conn.Close();
        }

       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            //KitapAlVer ac = new KitapAlVer();
            //ac.txtKitapNoo.Text = txtKitapNo.Text;
            //ac.txtYazarAdi.Text = txt_YazarAdi.Text;
            //ac.txtKitapAdi.Text = txt_KitapAdi.Text;
            //ac.txtYayinevi.Text = txt_Yayinevi.Text;
            //ac.ShowDialog();
            //this.Close();
            kitapNo = txtKitapNo.Text;
            yazarAdi = txt_YazarAdi.Text;
            kitapAdi = txt_KitapAdi.Text;
            yayinEvi = txt_Yayinevi.Text;
            this.Close();
        }
        int kitapİd = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            kitapİd = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtKitapNo.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txt_YazarAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txt_KitapAdi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txt_Yayinevi.Text = listView1.SelectedItems[0].SubItems[3].Text;

        }

    }

}
