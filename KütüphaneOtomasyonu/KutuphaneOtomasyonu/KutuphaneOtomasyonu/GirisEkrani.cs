using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KutuphaneOtomasyonu
{
   
    public partial class GirisEkrani : Form
    {
        public static string Yadi = "", Ysifre = "";

        public GirisEkrani()
        {
            InitializeComponent();
            
        }
        //Sql servıra bağlantı yapmamız için
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IVFG7VD\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        
        private void txtKullanıcı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void GirisEkranı_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
        
        private void girisBtn_Click(object sender, EventArgs e)
        {
            if (txtKullanıcı.Text == "" || txtSifre.Text == "")//Alanların boş bırakılmamsı için açılan koşul
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!");//Uyarı mesajı
                txtKullanıcı.Clear();//Adı textBoxının uyarıdan sonra temizlenmesi
                txtSifre.Clear();//Şifre textBoxının uyarıdan sonra temizlenmesi

            }
            else//Eğer personel bilgileri girildi ise
            {
                baglanti.Open();// Sql bağlantısını açma
               string adi = txtKullanıcı.Text;//TextBox adı  tanımladığım değişkene attadım
               string sifre = txtSifre.Text;//TextBox şifre  tanımladığım değişkene attadım
                Yadi = txtKullanıcı.Text;
                Ysifre= txtSifre.Text;

                //Sql bağlantısının personel tablomdaki verilerimi select sorgusuyla bakması
                SqlCommand komut = new SqlCommand("select*from TblPersonel where Adi='" + adi + "' and Sifre='" + sifre + "'", baglanti);
                //Sql bağlantısının personel tablomdaki verilerimi  SQLdatareader metodu sayesinde okumasını sağlamak
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())//okuma işlemi için if koşulu
                {
                    MessageBox.Show("Hoşgeldiniz " + adi + " ");// Eğer personel bilgisi doğru ise mesaj gözükür
                    Anasayfa anasayfa= new Anasayfa();//Anasayfayı ekranının tanımlanması
                    anasayfa.Show();//Anasayfa ekranın görünmesi
                    this.Hide();//Eski ekranın saklanamsı
                }
                else//Eger personel bilgileri doğru değilse
                {
                    MessageBox.Show("Hatalı kullanıcı adı ve şifre girdiniz");//Personel bilgileri yanlış ise mesaj devreye girer
                    txtKullanıcı.Clear();//TextBoxe alanının temizlenmesi
                    txtSifre.Clear();//TextBoxe alanının temizlenmesi
                }

                baglanti.Close();// bağlantının kapatılması
            }
            
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnutum sifremiUnutum = new SifremiUnutum();  //Şifremi unutum ekranının tanımlanması
            sifremiUnutum.Show();//ekranın görünmesi
            this.Hide(); //Eski ekranın saklanamsı



        }

        private void txtKullanıcı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)|| e.KeyChar==8)//Basılan karakter harf ise çalışır
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;//Textboxa yazdırma
            }
        }

        private void btnCikisG_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Dioloğun tanımlaması
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmesi
            secim = MessageBox.Show("Programı kapatmak istiyor musun?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçer ise bir if else koşulu
            {
                Application.Exit();//Projenin tamamen kapatılması
            }
        }
    }
}
