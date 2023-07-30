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
    public partial class PersonelEkrani : Form
    {
        SqlConnection baglanti;//Bağlantınn kısa tanımlanmıştır.
        SqlDataAdapter da;//Bağlantının olması ve olmamsı arasındaki bir köprü kısa tanımlaması
        DataTable dt;//Oluşturulan tablonun kısa tanımlaması
        public PersonelEkrani()
        {
            InitializeComponent();
        }
        
        bool durum;//2.kayıt yapmamak için kontrol olarak tanımlanan değişken
        void mukerrer()//Tekrar kayıt yapmayı önlemek için fonkssiyon
        {
            baglanti.Open();//Sql bağalntısı açılması
            //Verilerde  personel tabloda Tc bölümünün görülmesi
            SqlCommand komut =new SqlCommand("select*from TblPersonel where Tc=@Tc",baglanti);
            //Tc bölümün parametresi tasarımda eklenmiş olan bölümden alınıyor
            komut.Parameters.AddWithValue("@Tc",txtTc.Text);
            SqlDataReader dr =komut.ExecuteReader();//Verilerin okunması sağlanıyor
            if (dr.Read())//Veriler okunduğunda duruma göre bakılması
            {
                durum = false;//Durum false ise kayıtlı olduğu anlamına gelir.
            }
            else
            {
                durum = true;//Durum true ise yani kayıt  yapılır
            }
            baglanti.Close();//Sql bağlantısının kapatılması

        }
        void PersonelGetir()//Sql deki verileri getirebilmek için bir fonksiyon yazılmıştır
        {
            //Sql bağlantımı tanımladım
            baglanti = new SqlConnection("Data Source=DESKTOP-IVFG7VD\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
            baglanti.Open();//Sql bağlantısı açılmıştı
            dt= new DataTable();//Table oluşturulmuştur
            da = new SqlDataAdapter("Select*from TblPersonel",baglanti);//Tabloya gelicek olan sql veri sorgusu yazılmıştır
            da.Fill(dt);//Data getirilmiştir
            dataGridView1.DataSource = dt;//DatagridViewi tanımlaması yapılmıştır
            baglanti.Close();//Bağlantı kapatılmıştır
        }
        private void PersonelEkrani_Load(object sender, EventArgs e)
        {
            PersonelGetir();//Tanımlanan fonksiyon çağrılmıştır
        }
        private void btnCikisP_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Dioloğun tanımlaması
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmesi
            secim = MessageBox.Show("Programı kapatmak istiyor musun?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçer ise bir if else döngüsü
            {
                Application.Exit();//Projenin tamamen kapatılması
            }
        }
        private void btnGeriP_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Dialoğun tanımlanması
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmesi
            secim = MessageBox.Show("Ana sayfa ekranına dönmek istiyor musunuz?", "Geri Gel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçer ise bir if else döngüsü
            {
                Anasayfa anasayfa = new Anasayfa();//Ekranın tanımlanması
                anasayfa.Show();//Ekranın gözükmesi 
                this.Hide();//Eski ekranın kapatılması
            }
            }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Boşta alan bırakılmamsı için  bir if else döngüsü
            if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtTc.Text == "" || txtPosta.Text == "" || txtSifre.Text == "" || txtTelefon.Text == ""
                || dogumTarih.Text == "" || txtMaasi.Text == "" || txtYetki.Text == "" )
            {
                MessageBox.Show("Boş alan bırakmayınız");//Uyarı mesajı
            }
            else
            {
                mukerrer();//Yazılmış olan  kontrol fonksiyonu tanımlandı
                           //Durumu true ise if döngüsünün içine girecek
                if (durum == true)
                {
                    baglanti.Open();//sql bağlantısı açılması
                    //Sqldeki verilerimi çekmek için tanımlama yapıldı tablodaki verilerin adlarıyla
                    SqlCommand komut = new SqlCommand("insert into TblPersonel(Adi,Soyadi,Tc,Eposta,Sifre,Telefon,DoğumTarihi,Maası,Yetki) " +
                        "values(@Adi,@Soyadi,@Tc,@Eposta,@Sifre,@Telefon,@DoğumTarihi,@Maası,@Yetki)", baglanti);
                    //Sqldeki olan verileri tek tek olusturulan textboxlara bağlandı
                    komut.Parameters.AddWithValue("@Adi", txtAdi.Text);
                    komut.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                    komut.Parameters.AddWithValue("@Tc", txtTc.Text);
                    komut.Parameters.AddWithValue("@Eposta", txtPosta.Text);
                    komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                    komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@DoğumTarihi", dogumTarih.Value);
                    komut.Parameters.AddWithValue("@Maası", txtMaasi.Text);
                    komut.Parameters.AddWithValue("@Yetki", txtYetki.Text); 
                    komut.ExecuteNonQuery();//Tabloda eklemek istenilen veriler oluşturuldu
                    baglanti.Close();//Sql bağlantı kapatılması
                    MessageBox.Show("Kayıt başarılı");//Kayıt başarılı ise ekrana mesaj vermesi
                    PersonelGetir();//Tablodaki verileri güncel şekilde görmek için çağrılmıştır.
                }
                else//Eğer kayıtlı kullanıcı var ise
                {  //Uyarı mesajı verilmiştir
                    MessageBox.Show("Bu kayıt zaten var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DatagrideView de tanımlanan verilerin Textboxlar ile bağlantısının tanımlanmıştır.
            txtNo.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPosta.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dogumTarih.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtMaasi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtYetki.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
           
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            //Silme işlemi için sql bağlantısı açılmıştır.
            baglanti.Open();
            //Sql de tablosundaki biligilere ulaşmak için sorgu yazılmıştır sorguda bir tek personelNo ile sorgu yazılmıştır.
            SqlCommand komut = new SqlCommand("delete from TblPersonel where PersonelNo=@PersonelNo",baglanti);
            //Personel No ile güncelleme yapması için Convert yardımıyla ınt değerine dönüşüm yapılmıştır.
            komut.Parameters.AddWithValue("@PersonelNo",Convert.ToInt32(txtNo.Text));
            komut.ExecuteNonQuery();//Tabloda silmek istenilen veriler oluşturulmuştur.
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
            MessageBox.Show("Silme başarılı");//İşlem başarılı ise measj verilmiştir.
            PersonelGetir();//Tablodaki verileri güncel şekilde görmek için çağrılmıştır.
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //Güncelleme yada her hangi işlemden sonra textboxlarımı temizlemek için temizle butonu koyulmuştur.
            //Tek tek olan textboxları tanımlayarak temizleme işlemi yapılmıştır.
            txtTc.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTc.Clear();
            txtPosta.Clear();
            txtSifre.Clear();
            txtTelefon.Clear();
            txtMaasi.Clear();
            txtYetki.Clear();
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           //Güncelleme için sql sorgusu yazılmıştır.
            SqlCommand komut = new SqlCommand("update TblPersonel set Adi=@Adi,Soyadi=@Soyadi,Tc=@Tc,Eposta=@Eposta,Sifre=@Sifre," +
                "Telefon=@Telefon,DoğumTarihi=@DoğumTarihi,Maası=@Maası,Yetki=@Yetki where PersonelNo=@PersonelNo",baglanti);
            //Personel No ile güncelleme yapması için int değerin dönüşümü sağlanmıştır.
            //Tek tek alınacak olan tablodaki değerleri textboxlar ile tanımlanmıştır.
            komut.Parameters.AddWithValue("@PersonelNo", Convert.ToInt32(txtNo.Text));
            komut.Parameters.AddWithValue("@Adi", txtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
            komut.Parameters.AddWithValue("@Tc", txtTc.Text);
            komut.Parameters.AddWithValue("@Eposta", txtPosta.Text);
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@DoğumTarihi", dogumTarih.Value);
            komut.Parameters.AddWithValue("@Maası", txtMaasi.Text);
            komut.Parameters.AddWithValue("@Yetki", txtYetki.Text);
            
            baglanti.Open();//Sql bağlantı açılmıştır.
            komut.ExecuteNonQuery();//Tablodaki güncellemek istenilen verileri oluşturmak için kullanılan methoddur.
            baglanti.Close();//Sql bağlantı kapatılmıştır.
            MessageBox.Show("Güncelleme başarılı");//İşlem başarılı olduktan sonra mesaj verilmiştir.
            PersonelGetir();//Tablodaki verileri güncel şekilde görmek için çağrılmıştır.
        }
    }
}
