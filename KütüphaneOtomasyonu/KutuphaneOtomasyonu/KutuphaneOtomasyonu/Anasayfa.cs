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

namespace KutuphaneOtomasyonu
{
    public partial class Anasayfa : Form

    {

        public Anasayfa()
        {
            InitializeComponent();
        }

        //Sql servıra bağlantı yapmamız için
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IVFG7VD\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

        private void btnUye_Click(object sender, EventArgs e)
        {
            UyeEkrani uyeEkrani = new UyeEkrani();//Ekranın tanımlanması
            uyeEkrani.Show();//Ekranı göstermek yani gitmek
            this.Hide();//Bir önceki ekrnaın saklanması 
        }
        

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Dioloğun tanımlaması
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmesi
           secim=MessageBox.Show("Programı kapatmak istiyor musun?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçer ise bir if else döngüsü
            {
                Application.Exit();//Projenin tamamen kapatılması
            }
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            KitapEkrani kitapEkrani = new KitapEkrani();//Ekranın tanımlanması
            kitapEkrani.Show();//Ekranı göstermek yani gitmek
            this.Hide();//Bir önceki ekrnaın saklanması 
        }

        private void btnEmanet_Click(object sender, EventArgs e)
        {
            EmanetKitapSayfasi emanetKitapSayfasi = new EmanetKitapSayfasi();//Ekranın tanımlanması
            emanetKitapSayfasi.Show();//Ekranı göstermek yani gitmek
            this.Hide();//Bir önceki ekrnaın saklanması 
        }
        private void btnPersonel_Click(object sender, EventArgs e)
        {  
            PersonelEkrani personelEkrani = new PersonelEkrani();//Ekranın tanımlanması
            personelEkrani.Show();//Ekranı göstermek yani gitmek
            this.Hide();//Bir önceki ekrnaın saklanması 
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
