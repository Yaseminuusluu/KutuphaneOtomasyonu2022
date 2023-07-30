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
    public partial class KitapEkrani : Form
    {
        SqlConnection baglanti;//Bağlantınn kısa tanımlanmıştır.
        SqlDataAdapter da;//Bağlantının olup olmamasını arasındaki bir köprü tanımlanmıştır.
        DataTable dt;//Oluşturulan tablonun kısa tanımlaması yapılmıştır.
        public KitapEkrani()
        {
            InitializeComponent();
        }

        bool durum;//2.kayıt yapmamak için kontrol olarak tanımlanan değişken
        void mukerrer()//Tekrar kayıt yapmayı önlemek için fonksiyon yazılmıştır.
        {
            baglanti.Open();//Sql bağalntısı açılmıştır.
            //Verilerde  personel tablosundaki sadece Tc bölümünün tanımlanması yapılmıştır.
            SqlCommand komut = new SqlCommand("select*from TblKitap where BarkodNo=@BarkodNo", baglanti);
            //Tc bölümün parametresi tasarımda eklenmiş olan bölümden alınmıştır.
            komut.Parameters.AddWithValue("@BarkodNo", txtBarkod.Text);
            SqlDataReader dr = komut.ExecuteReader();//Verilerin okunması sağlanmıştır.
            if (dr.Read())//Veriler okunduğunda duruma göre bakılması için yazılan methoddur.
            {
                durum = false;//Durum false ise kayıtlı olduğu anlamına gelmektedir
            }
            else
            {
                durum = true;//Durum true ise yani kayıt yapılır
            }
            baglanti.Close();//Sql bağlantısının kapatılmıştır.

        }
        private void KitapEkrani_Load(object sender, EventArgs e)
        {
            KitapGetir();//Ekran yüklenince çalışması  için method çağrılmıştır.
        }

        void KitapGetir()
        {
            //Sql bağlantımı tanımlanmıştır.
            baglanti = new SqlConnection("Data Source=DESKTOP-IVFG7VD\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
            baglanti.Open();//Sql bağlantısı açılmıştır
            dt = new DataTable();//Tablo oluşturulmuştur
            da = new SqlDataAdapter("Select*from TblKitap", baglanti);//Tabloya gelicek olan sql veri sorgusu yazılmıştır
            da.Fill(dt);//Data getirilmiştir
            dataGridView1.DataSource = dt;//DatagridViewi tanımlaması yapılmıştır
            baglanti.Close();//Bağlantı kapatılmıştır

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCikisK_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Diyalog tanımlanmıştır.
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmiştir.
            secim = MessageBox.Show("Programı kapatmak istiyor musun?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçilir ise bir if else döngüsü yazılmıştır.
            {
                Application.Exit();//Projenin tamamen kapatılması için yazılmıştır.
            }
        }

        private void btnGeriK_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Diyalog tanımlanmıştır.
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmiştir.
            secim = MessageBox.Show("Ana sayfa ekranına dönmek istiyor musunuz?", "Geri Gel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçilir ise bir if else döngüsü yazılmıştır.
            {
                Anasayfa anasayfa = new Anasayfa();//Ekranın tanımlanması
                anasayfa.Show();//Ekranın gözükmesi 
                this.Hide();//Eski ekranın kapatılması
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DatagrideView de tanımlanan verilerin Textboxlar ile bağlantısının tanımlanmıştır.
            txtNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBarkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYazar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtYayınevi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTur.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSayfaS.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtYıl.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }
        private void btnTemizleK_Click(object sender, EventArgs e)
        {
            //Güncelleme yada her hangi işlemden sonra textboxlarımı temizlemek için temizle butonu koyulmuştur.
            //Tek tek olan textboxları tanımlayarak temizleme işlemi yapılmıştır.
            txtNo.Clear();
            txtBarkod.Clear();
            txtAdi.Clear();
            txtYazar.Clear();
            txtYayınevi.Clear();
            txtTur.Clear();
            txtSayfaS.Clear();
            txtYıl.Clear();
            txtAciklama.Clear();
            txtStok.Clear();
        }
        private void btnEkleK_Click(object sender, EventArgs e)
        {
            //Boşta alan bırakılmamsı için  bir if else döngüsü yazılmıştır.
            if (txtBarkod.Text == "" || txtAdi.Text == "" || txtYazar.Text == "" || txtYayınevi.Text == "" || txtTur.Text == "" || txtSayfaS.Text == ""
                || txtYıl.Text == "" || txtAciklama.Text == "" || txtStok.Text=="")
            {
                MessageBox.Show("Boş alan bırakmayınız");//Uyarı mesajı verilmiştir.
            }
            else
            {
                mukerrer();//Yazılmış olan  kontrol fonksiyonu tanımlanmıştır.
               //Durumu true ise if döngüsünün içine girecektir.
                if (durum==true)
                {
                    baglanti.Open();//sql bağlantısı açılmıştır.
                    //Sqldeki verilerin çekilmesi için tanımlama yapılmıştır tablodaki verilerin adlarıyla yapılmıştır.
                    SqlCommand komut = new SqlCommand("insert into TblKitap(BarkodNo,KitapAdı,Yazar,Yayınevi,KitapTürü,SayfaSayısı,BasımYıllı,Acıklama,StokSayısı) " +
                        "values(@BarkodNo,@KitapAdı,@Yazar,@Yayınevi,@SayfaSayısı,@KitapTürü,@BasımYıllı,@Acıklama,@StokSayısı) ", baglanti);
                    //Sqldeki olan verileri tek tek oluşturulan textboxlara bağlantısı yapılmıştır.
                    komut.Parameters.AddWithValue("@BarkodNo", txtBarkod.Text);
                    komut.Parameters.AddWithValue("@KitapAdı", txtAdi.Text);
                    komut.Parameters.AddWithValue("@Yazar", txtYazar.Text);
                    komut.Parameters.AddWithValue("@Yayınevi", txtYayınevi.Text);
                    komut.Parameters.AddWithValue("@KitapTürü", txtTur.Text);
                    komut.Parameters.AddWithValue("@SayfaSayısı", txtSayfaS.Text);
                    komut.Parameters.AddWithValue("@BasımYıllı", txtYıl.Text);
                    komut.Parameters.AddWithValue("@Acıklama", txtAciklama.Text);
                    komut.Parameters.AddWithValue("@StokSayısı",int.Parse( txtStok.Text));
                    komut.ExecuteNonQuery();//Tabloda eklemek istenilen veriler oluşturuldu
                    MessageBox.Show("Kayıt başarılı");//Kayıt başarılı ise ekrana mesaj verilmiştir.
                    baglanti.Close();//Sql bağlantısı kapatılmıştır.
                    KitapGetir();//Tablodaki verileri güncel şekilde görmek için çağrılmıştır.
                }
                else//Eğer kullanıcı var ise
                {  //Uyarı mesajı verilmiştir.
                    MessageBox.Show("Bu kayıt zaten var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            }

        private void btnSilK_Click(object sender, EventArgs e)
        {
            //Silme işlemi için sql bağlantısını açılmıştır.
            baglanti.Open();
            //Sql tabosundaki biligileri ulaşmak için sorgu yazılmıştır sorguda bir tek No ile sorgu yazılmıştır.
            SqlCommand komut = new SqlCommand("delete from TblKitap where KitapNo=@KitapNo", baglanti);
            //Kitap No ile silme yapması için Convert yardımıyla ınt değerine dönüşüm yapılmıştır.
            komut.Parameters.AddWithValue("@KitapNo", Convert.ToInt32(txtNo.Text));
            komut.ExecuteNonQuery();//Tabloda silmek istenilen veriler oluşturulmuştur
            baglanti.Close();//Sql bağlantı kapatılmıştır.
            MessageBox.Show("Silme başarılı");//İşlem başarılı ise mesaj verilmiştir.
            KitapGetir();//Tablodaki verileri güncel şekilde görmek için çağrılmıştır.

        }

        private void btnGuncelleK_Click(object sender, EventArgs e)
        {
            //Güncelleme için sql sorgu yazılmıştır.
            SqlCommand komut = new SqlCommand("update TblKitap set BarkodNo=@BarkodNo,KitapAdı=@KitapAdı,Yazar=@Yazar,Yayınevi=@Yayınevi," +
                "KitapTürü=@KitapTürü,SayfaSayısı=@SayfaSayısı,BasımYıllı=@BasımYıllı,Acıklama=@Acıklama,StokSayısı=@StokSayısı where KitapNo=@KitapNo", baglanti);
            //Kitap No ile güncelleme yapması için Convert yardımıyla ınt değerine dönüşüm yapılmıştır.
            //Tek tek alınacak olan tablodaki değerleri textboxlar ile tanımlanmıştır.
            komut.Parameters.AddWithValue("KitapNo", Convert.ToInt32(txtNo.Text));
            komut.Parameters.AddWithValue("@BarkodNo", txtBarkod.Text);
            komut.Parameters.AddWithValue("@KitapAdı", txtAdi.Text);
            komut.Parameters.AddWithValue("@Yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@Yayınevi", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@KitapTürü", txtTur.Text);
            komut.Parameters.AddWithValue("@SayfaSayısı", txtSayfaS.Text);
            komut.Parameters.AddWithValue("@BasımYıllı", txtYıl.Text);
            komut.Parameters.AddWithValue("@Acıklama", txtAciklama.Text);
            komut.Parameters.AddWithValue("@StokSayısı", int.Parse(txtStok.Text));
            baglanti.Open();//Sql bağlantısı açılmıştır.
            komut.ExecuteNonQuery();//Tablodaki güncellemek istenilen verileri oluşturmak için kullanılan methoddur.
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
            MessageBox.Show("Güncelleme başarılı");//İşlem başarılı olduktan sonra mesaj verilmiştir.
            KitapGetir();//Tablodaki verileri güncel şekilde görmek için çağrılmıştır.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

