using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class EmanetKitapSayfasi : Form
    {
        public EmanetKitapSayfasi()
        {
            InitializeComponent();
        }
        //Sql bağlantısı tanımlanmıştır.
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IVFG7VD\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        DataSet ds= new DataSet();//Sql veri almasını sağlamıştır
        private void kitapSayisi()//Kitap sayısını görmek için yazılan methodtur.
        {
            baglanti.Open();//Sql bağlantısı açılmıştır.
            //Kitap sayısını tabloya yansıtmak için sorgu yazılmıştır.
            SqlCommand komut = new SqlCommand("select sum(KitapSayisi) from TblSepet", baglanti);
            lblKitapSayisi.Text = komut.ExecuteScalar().ToString();//Kullanılan label için sorgu tanımlaması yapılmıştır.
            baglanti.Close();//Sql bağlantısı kapatılmıştır.

        }
        private void EmanetKitapSayfasi_Load(object sender, EventArgs e)
        {
            sepetListele();//Method çağrılmıştır.
            kitapSayisi();//Method çağrılmıştır.
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
        private void btnCikisK_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Diyalog tanımlanmıştır.
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmiştir.
            secim = MessageBox.Show("Programı kapatmak istiyor musun?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçer ise bir if else döngüsü
            {
                Application.Exit();//Projenin tamamen kapatılmıştır.
            }
        }
        private void btnİade_Click(object sender, EventArgs e)
        {
            KitapTeslimSayfasi kitapTeslimSayfasi= new KitapTeslimSayfasi();//Ekran tanımlanmıştır.
            kitapTeslimSayfasi.Show();//Ekran gösterilmiştir.
            this.Hide();//Önceki ekran saklanmıştır.
        }
        private void sepetListele()
        {
            baglanti.Open();//Sql bağlantısı açılmıştır.
            //Sepet tabloya yansıtmak için sorgu yazılmıştır.
            SqlDataAdapter adapter = new SqlDataAdapter("select*from TblSepet",baglanti);
            adapter.Fill(ds, "TblSepet");//Data getirilmiştir.
            dataGridView1.DataSource = ds.Tables["TblSepet"];//DataGridView'e tablo bağlantısı sağlanmıştır.
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
        }
        private void btnEkleK_Click(object sender, EventArgs e)
        {
            baglanti.Open();//Sql bağlantısı açılmıştır.
            //Sqldeki verilerin çekilmesi için tanımlama yapılmıştır tablodaki verilerin adlarıyla yapılmıştır.
            SqlCommand komut = new SqlCommand("insert into TblSepet(BarkodNo,KitapAdi,Yazari,Yayinevi,SayfaSayisi,KitapSayisi,TeslimTarihi,İadeTarihi) " +
                       "values(@BarkodNo,@KitapAdi,@Yazari,@Yayinevi,@SayfaSayisi,@KitapSayisi,@TeslimTarihi,@İadeTarihi) ", baglanti);
            //Sqldeki olan verileri tek tek oluşturulan textboxlara bağlantısı yapılmıştır.
            komut.Parameters.AddWithValue("@BarkodNo",txtNo.Text);
            komut.Parameters.AddWithValue("@KitapAdi",txtAdiK.Text);
            komut.Parameters.AddWithValue("@Yazari", txtYazar.Text);
            komut.Parameters.AddWithValue("@Yayinevi", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@SayfaSayisi",txtSayfaS.Text);
            //Veride alınan değere için Parse ile dönüşüm yapılmıştır.
            komut.Parameters.AddWithValue("@KitapSayisi", int.Parse(txtKitapSayisi.Text));
            komut.Parameters.AddWithValue("@TeslimTarihi",teslimTarihi.Text);
            komut.Parameters.AddWithValue("@İadeTarihi", İadeTarihi.Text);
            komut.ExecuteNonQuery();//Tabloda eklemek istenilen veriler oluşturulmuştur.
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
            MessageBox.Show("Kitaplar sepete eklendi");//Uyarı mesajı verilmiştir.
            ds.Tables["TblSepet"].Clear();//Tablo temizleme işlemi yapılmıştır.
            sepetListele();//Sepet listeleme methodu çağrılmıştır.
            lblKitapSayisi.Text = "";//lable boş bırakılmıştır.
            kitapSayisi();//Kitap sayısı methodu çağrılmıştır.
            foreach (Control item in groupBox2.Controls)//Forech döngüsüyle grupboxe kontrolü yapılmıştır.
            {
                if (item is TextBox)// if döngüsüne textbox yazılmıştır
                {
                    if(item!=txtKitapSayisi)//Kitap sayısı boş bırakılmamış olması kontrol edilmiştir.
                    {
                        item.Text = "";
                    }

                }
            }   
        }
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();//Sql bağlantı açılmıştır.
            //Kullanıcı bilgilerini almak için sorgu yazılmıştır.
            SqlCommand komut = new SqlCommand("select*from TblKullanıcı where Tc like '"+txtTc.Text+"'",baglanti);
            SqlDataReader oku=komut.ExecuteReader();//Sorgunun okuması yapılmıştır.
            while (oku.Read())//oku metodu kontrolü için while döngüsü yazılmıştır.
            {
                //Çekilmesi gerekli olan  veriler textboxlara tanımlanmıştır.
                txtAdi.Text = oku["Adı"].ToString();
                txtSoyadi.Text = oku["Soyadı"].ToString();
                txtTelefon.Text = oku["Telefon"].ToString();
                txtEmail.Text = oku["Email"].ToString();
            }
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
            if (txtTc.Text == "")//Textboxların boş olma durumu kontrolü yapılmıştır.
            {
                foreach (Control item in groupBox1.Controls)
                {
                    item.Text = "";
                }
            }
        }
        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();//Sql bağlantı açılmıştır.
            //Kitap bilgilerini almak için sorgu yazılmıştır.
            SqlCommand komut = new SqlCommand("select *from TblKitap where BarkodNo like '"+txtNo.Text+"'", baglanti);
            SqlDataReader oku =komut.ExecuteReader();//Sorgunun okuması yapılmıştır.
            while (oku.Read())//oku metodu kontrolü için while döngüsü yazılmıştır.
            {
                //Çekilmesi gerekli olan  veriler textboxlara tanımlanmıştır.
                txtAdiK.Text=oku["KitapAdı"].ToString();
                txtYazar.Text = oku["Yazar"].ToString();
                txtYayınevi.Text = oku["Yayınevi"].ToString();
                txtSayfaS.Text = oku["SayfaSayısı"].ToString();
            }
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
            if (txtNo.Text=="")//Textboxların boş olma durumu kontrolü yapılmıştır.
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtKitapSayisi)
                        {
                            item.Text = "";//Temizleme işlemi yapar.
                        }
                    }                  
                }
            }
           
        }
        private void btnSilK_Click(object sender, EventArgs e)
        {
            //Sql bağlantısı açılmıştır.
            baglanti.Open();
            //Sql de tablosundaki biligilere ulaşmak için sorgu yazılmıştır sorguda bir tek Barkod no ile silme işlemi yapılmıştır.
            SqlCommand komut = new SqlCommand("delete from TblSepet where BarkodNo='"+dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString()
                +"'", baglanti);
            komut.ExecuteNonQuery();//Tabloda eklemek istenilen veriler oluşturulmuştur.
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
            MessageBox.Show("Silme işlemi yapıldı","Silme İşlemi");//İşlemle ilgili mesaj verildi
            ds.Tables["TblSepet"].Clear();//Sepet tablosu temizlenmiştir.
            sepetListele();//Yazılan fonksiyon çağrılmıştır..
            lblKitapSayisi.Text = "";//Lable temizler
            kitapSayisi();//Yazılan kitap sayısı fonksiyonu çağrılmıştır.
        }
        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
                if (lblKitapSayisi.Text!="")//Lableın boş olmamsı için yazılan if koşulu
            {
                //Sayısal veri olduğu için int değine çevirildi ve 3 ten fazla sepete kitap eklenmesi için yazılmıştır.
                if (int.Parse(lblKitapSayisi.Text)<=3)//Parse ile int değerine dönüşüm yapılmıştır.
                {
                    //Alanların boş olmamamsı için  if koşulu yazılmıştır.
                    if(txtTc.Text!="" && txtAdi.Text!="" && txtSoyadi.Text!="" && txtTelefon.Text!=""&& txtEmail.Text!="")
                    {
                        //DatagridView içindeki verileri dönmek için yazılan for döngüsüdür.
                        for (int i = 0; i <dataGridView1.Rows.Count; i++)
                        {
                            baglanti.Open();//Sql bağlantısı açılmıştır.
                            //Kitap ve kullanıcı bilgilerini almak için sorgu yazılmıştır.
                            SqlCommand komut = new SqlCommand("insert into TblEmanetKitap(Tc,Adi,Soyadi,Telefon,Email,BarkodNo,KitapAdi," +
                                "Yazari,Yayinevi,SayfaSayisi,KitapSayisi,TeslimTarihi,İadeTarihi) values(@Tc,@Adi,@Soyadi,@Telefon,@Email," +
                                "@BarkodNo,@KitapAdi,@Yazari,@Yayinevi,@SayfaSayisi,@KitapSayisi,@TeslimTarihi,@İadeTarihi) ", baglanti);
                            //Sqldeki olan verileri tek tek oluşturulan textboxlara bağlantısı yapılmıştır.
                            komut.Parameters.AddWithValue("@Tc",txtTc.Text);
                            komut.Parameters.AddWithValue("@Adi", txtAdi.Text);
                            komut.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
                            //Sepet tablosundan çekilen veriler için datagridviewe bağlantıları yapılmıştır.
                            komut.Parameters.AddWithValue("BarkodNo",dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                            komut.Parameters.AddWithValue("KitapAdi", dataGridView1.Rows[i].Cells["KitapAdi"].Value.ToString());
                            komut.Parameters.AddWithValue("Yazari", dataGridView1.Rows[i].Cells["Yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("Yayinevi", dataGridView1.Rows[i].Cells["Yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("SayfaSayisi", dataGridView1.Rows[i].Cells["SayfaSayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("KitapSayisi", int.Parse(dataGridView1.Rows[i].Cells["KitapSayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("TeslimTarihi", dataGridView1.Rows[i].Cells["TeslimTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("İadeTarihi", dataGridView1.Rows[i].Cells["İadeTarihi"].Value.ToString());
                            komut.ExecuteNonQuery();//Tabloda eklemek istenilen veriler oluşturulmuştur.
                            //Kitap tablosundaki stoksayısını düşürmek için yazılan sorgu methodudur.
                            SqlCommand komut2 = new SqlCommand("update TblKitap set StokSayısı=StokSayısı-'"+int.Parse(dataGridView1.Rows[i].Cells
                            ["KitapSayisi"].Value.ToString())+"' where BarkodNo='"+dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString()+"'", baglanti);
                            komut2.ExecuteNonQuery();//Tabloda eklemek istenilen veriler oluşturulmuştur.
                            baglanti.Close();//Sql bağlantısı kapatılmıştır. 
                        }
                        baglanti.Open();//Sql bağlantısı açılmıştır.
                        //Sepet silme işlemi için sorgu yazılmıştır.
                        SqlCommand komut3 = new SqlCommand("delete from TblSepet",baglanti);
                        komut3.ExecuteNonQuery();//Tabloda eklemek istenilen veriler oluşturulmuştur.
                        baglanti.Close();//Sql bağlantısı kapatılmıştır. 
                        MessageBox.Show("Kitaplar emanet edildi");//Uyarı mesajı verilmiştir.
                        ds.Tables["TblSepet"].Clear();//Tablo temizleme işlemi yapılmıştır.
                        sepetListele();//Method çağrılmıştir
                        txtTc.Text = "";//Textboox temizler.
                        lblKitapSayisi.Text = "";//Lable temizler
                        kitapSayisi();//Yazılan fonksiyonu çağırır
                      //Komut satırları
                    }
                    else//Kullanıcı seçilmemeiş ise
                    {
                        MessageBox.Show("Önce kullanıcı ismi seçiniz!!","Uyarı");//Uyarı mesajı verir
                    }
                }
                else//Sepetteki kitap sayısı 3 ten fazlaysa
                {
                    MessageBox.Show("Emanet kitap sayısı 3 ten fazla olamaz!!","Uyarı");//Uyarı mesajı verir.
                }
            }
            else//Eğer lable boş ise
            {
                MessageBox.Show("Önce sepete kitap eklenmelidir!!","Uyarı");//ekrana mesaj verilir.
            }         
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            EmanetKitapListeleme kitapListeleme = new EmanetKitapListeleme();//Ekran tanımlaması yapılmıştır.
            kitapListeleme.Show();//Ekranın görünmesi sağlanmıştır.
            this.Hide();//Önceki ekran saklanmıştır.
        }
    }
}
