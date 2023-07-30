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
    public partial class SifremiUnutum : Form
    {
        public SifremiUnutum()
        {
            InitializeComponent();
        }
        //Sql servıra bağlantı yapmamız için
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IVFG7VD\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text == "" || txtEmail.Text == "")//TextBox alanlarının boş geçilememsi
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!");//Ekranda yapılan hatanın mesajının görünmesi
                txtAdi.Clear();//textBoxının uyarıdan sonra temizlenmesi
                txtEmail.Clear();//textBoxının uyarıdan sonra temizlenmesi
            }
            else
            {
                baglanti.Open();//Sql bağlantısı açma
               string adi = txtAdi.Text;
               string email = txtEmail.Text;
                //Sql datası için select sorgusu
                SqlCommand komut = new SqlCommand("select*from TblPersonel where Adi='" + adi + "'" +
                    " and Eposta='" + email + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();//Sql bilgileirnin okunması
                if (oku.Read())
                {
                    MessageBox.Show("Hoşgeldiniz " + adi + " ");
                    Anasayfa anasayfa = new Anasayfa();//Anasayfa ekranının tanımlanması
                    anasayfa.Show();//ekranın gösterilmesi veya gidilmesi
                    this.Hide();//Bir önceki sayfanın saklanması
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı ve eposta girdiniz");//Ekranda yapılan hatanın mesajının görünmesi
                    txtAdi.Clear();//textBoxının uyarıdan sonra temizlenmesi
                    txtEmail.Clear();//textBoxının uyarıdan sonra temizlenmesi
                }
                baglanti.Close();//Sql bağlantısı kapatma
            }



        }

        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)//Basılan karakter harf ise çalışır
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;//Textboxa yazdırma
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Dioloğun tanımlaması
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmesi
            secim = MessageBox.Show("Programı kapatmak istiyor musun?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçer ise bir if else döngüsü
            {
                Application.Exit();//Projenin tamamen kapatılması
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Giriş ekranına dönmek istiyor musunuz?","Geri Gel",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (secim==DialogResult.Yes) {
                GirisEkrani girisEkrani = new GirisEkrani();//Ekranın tanımlanması
                girisEkrani.Show();//Ekranın gözükmesi 
                this.Hide();//Eski ekranın kapatılması
            }
        }

        private void SifremiUnutum_Load(object sender, EventArgs e)
        {

        }
    }
}
