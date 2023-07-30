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
    public partial class UyeEkrani : Form
    {
        SqlConnection baglanti;//Bağlantınn kısa tanımlaması
        SqlDataAdapter da;//Bağlantının olması ve olmamsı arasındaki bir köprü kısa tanımlaması
        DataTable dt;//Oluşturulan tablonun kısa tanımlaması
        public UyeEkrani()
        {
            InitializeComponent();
        }

        bool durum;//2.kayıt yapmamak için kontrol olarak tanımlanan değişken
        void mukerrer()//Tekrar kayıt yapmayı önlemek için fonkssiyon
        {
            baglanti.Open();//Sql bağalntısı açılması
            //Verilerde  personel tabloda Tc bölümünün görülmesi
            SqlCommand komut = new SqlCommand("select*from TblKullanıcı where Tc=@Tc", baglanti);
            //Tc bölümün parametresi tasarımda eklenmiş olan bölümden alınıyor
            komut.Parameters.AddWithValue("@Tc", txtTc.Text);
            SqlDataReader dr = komut.ExecuteReader();//Verilerin okunması sağlanıyor
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
        void UyeGetir()
        {
            //Sql bağlantımı tanımladım
            baglanti = new SqlConnection("Data Source=DESKTOP-IVFG7VD\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
            baglanti.Open();//Sql bağlantısı açılmıştır
            dt = new DataTable();//Table oluşturulmuştur
            da = new SqlDataAdapter("Select*from TblKullanıcı", baglanti);//Tabloya gelicek olan sql veri sorgusu yazılmıştır
            da.Fill(dt);//Data getirilmiştir
            dataGridView1.DataSource = dt;//DatagridViewi tanımlaması yapılmıştır
            baglanti.Close();//Bağlantı kapatılmıştır

        }
        private void UyeEkrani_Load(object sender, EventArgs e)
        {
            UyeGetir();//Yazılan metod çağrıldır
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCikisU_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Diyaloğun tanımlaması
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmesi
            secim = MessageBox.Show("Programı kapatmak istiyor musun?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçer ise bir if else döngüsü
            {
                Application.Exit();//Projenin tamamen kapatılması
            }
        }

        private void btnGeriU_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Diyaloğun tanımlanması
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmesi
            secim = MessageBox.Show("Ana sayfa ekranına dönmek istiyor musunuz?", "Geri Gel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçer ise bir if else döngüsü
            {
                Anasayfa anasayfa = new Anasayfa();//Ekranın tanımlanması
                anasayfa.Show();//Ekranın gözükmesi 
                this.Hide();//Eski ekranın kapatılması
            }
        }

        private void btnTemizleU_Click(object sender, EventArgs e)
        {
            //Güncelleme yada her hangi bir işlemden sonra textboxların temizlenmesi için temizle butonu koyulmuştur.
            //Tek tek olan textboxlarımı tanımlayarak tezlettim.
            txtNoU.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTc.Clear();
            txtTelefon.Clear();
            txtPosta.Clear();
            txtkitap.Clear();
            txtAdres.Clear();
        }
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DatagrideView de tanımlanan verilerin Textboxlar ile bağlantısının tanımlanması
            txtNoU.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPosta.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dogumTarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtkitap.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
        private void btnEkleU_Click(object sender, EventArgs e)
        {
            //Boşta alan bırakılmamsı için  bir if else döngüsü yazılmıştır.
            if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtTc.Text == "" || txtTelefon.Text == "" || txtPosta.Text == "" || dogumTarihi.Text == ""
                || txtkitap.Text == "" || txtAdres.Text == "" )
            {
                MessageBox.Show("Boş alan bırakmayınız");//Uyarı mesajı verilmiştir
            }
            else
            {
                mukerrer();//Yazılmış olan  kontrol fonksiyonu tanımlanmıştır.
                //Durumu true ise if döngüsünün içine girecek
                if (durum == true)
                {
                    baglanti.Open(); //sql bağlantısı açılmıştır.
                    //Sqldeki verilerimi çekmek için tanımlama yapıldı tablodaki verilerin adlarıyla komut sorgusu yazılmıştır.
                    SqlCommand komut = new SqlCommand("insert into TblKullanıcı(Adı,Soyadı,Tc,Telefon,Email,DoğumTarihi,OkuduğuKitap,Adres) " +
                        "values(@Adı,@Soyadı,@Tc,@Telefon,@Email,@DoğumTarihi,@OkuduğuKitap,@Adres) ", baglanti); 
                    //Sqldeki olan verileri tek tek olusturulan textboxlara bağlantısı yapılmıştır.
                    komut.Parameters.AddWithValue("@Adı", txtAdi.Text);
                    komut.Parameters.AddWithValue("@Soyadı", txtSoyadi.Text);
                    komut.Parameters.AddWithValue("@Tc", txtTc.Text);
                    komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@Email", txtPosta.Text);
                    komut.Parameters.AddWithValue("@DoğumTarihi", dogumTarihi.Value);
                    komut.Parameters.AddWithValue("@OkuduğuKitap", txtkitap.Text);
                    komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                    komut.ExecuteNonQuery();//Verileri eklemek için kullanılmıştır.
                    MessageBox.Show("Kayıt başarılı");//Uyarı mesajı verilmiştir.
                    baglanti.Close();//Sql bağlantısı kapatılmıştır.
                    UyeGetir();//Yazılan fonksiyon çağrılmıştır.
                }
                else//Eğer kullanıcı var ise
                {  //Uyarı mesajı verilmiştir.
                    MessageBox.Show("Bu kayıt zaten var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void btnSilU_Click(object sender, EventArgs e)
        {
            //Silme işlemi için sql bağlantısını açılmıştır.
            baglanti.Open();
            //Sql de tablomdaki biligileri ulaşmak için sorgu yazılmıştır sorguda bir tek KullanıcıNo ile sorgu yazılmıştır.
            SqlCommand komut = new SqlCommand("delete from TblKullanıcı where KullanıcıNo=@KullanıcıNo", baglanti);
            //Parametre ve yerini belirtildiketen sonra textboxa yazıldı ama veri olarak int değer aldındığından Convert yardımıyla ınt değerine dönüşüm yapılmıştır.
            komut.Parameters.AddWithValue("@KullanıcıNo", Convert.ToInt32(txtNoU.Text));
            komut.ExecuteNonQuery();//Tabloda silmek istenilen verileri oluşturmak
            baglanti.Close();//Sql bağlantı kapatılmıştır
            MessageBox.Show("Silme başarılı");//İşlem başarılı ise measj verilmiştir.
            UyeGetir();//Tablodaki verileri güncel şekilde görmek için çağrılmıştır.
        }

        private void btnGuncelleU_Click(object sender, EventArgs e)
        {
            //Güncelleme için sql sorgusu yazılmıştır.
            SqlCommand komut = new SqlCommand("update TblKullanıcı set Adı=@Adı,Soyadı=@Soyadı,Tc=@Tc,Telefon=@Telefon,Email=@Email," +
                "DoğumTarihi=@DoğumTarihi,OkuduğuKitap=@OkuduğuKitap,Adres=@Adres where KullanıcıNo=@KullanıcıNo", baglanti);
            //Üye No ile güncelleme yapması için Convert yardımıyla ınt değerine dönüşüm yapılmıştır.
            //Tek tek alınıcak olan  değerleri textboxlar ile tanımlanmıştır.
            komut.Parameters.AddWithValue("KullanıcıNo", Convert.ToInt32(txtNoU.Text));
            komut.Parameters.AddWithValue("@Adı", txtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadı", txtSoyadi.Text);
            komut.Parameters.AddWithValue("@Tc", txtTc.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Email", txtPosta.Text);
            komut.Parameters.AddWithValue("@DoğumTarihi", dogumTarihi.Value);
            komut.Parameters.AddWithValue("@OkuduğuKitap", txtkitap.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();//Tablomda güncellemek istenilen verileri oluşturmak için kulanılan methoddur.
            baglanti.Close();//Sql bağlantı kapatılmıştır.
            MessageBox.Show("Güncelleme başarılı");//İşlem başarılı olduktan sonra mesaj verilmiştir.
            UyeGetir();//Tablodaki verileri güncel şekilde görmek için çağrılmıştır.
        }
    }
}
