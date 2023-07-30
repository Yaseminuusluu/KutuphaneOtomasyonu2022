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

namespace KutuphaneOtomasyonu
{
    public partial class KitapTeslimSayfasi : Form
    {
        public KitapTeslimSayfasi()
        {
            InitializeComponent();
        }
        //Sql bağlantısı tanımlanması.
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IVFG7VD\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        DataSet ds = new DataSet();//Sql veri almasını sağlamıştır
        private void EmanetListele()
        {
            baglanti.Open();//Sql bağlantısı açılmıştır.
            SqlDataAdapter adapter = new SqlDataAdapter("select*from TblEmanetKitap", baglanti);//Veri arasındaki köprü için sorgu yazılmıştır.
            adapter.Fill(ds, "TblEmanetKitap");//Data getirilmiştir.
            dataGridView1.DataSource = ds.Tables["TblEmanetKitap"];//DataGridView'e tablo bağlantısı sağlanmıştır.
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
        }
        private void KitapTeslimSayfasi_Load(object sender, EventArgs e)
        {
            EmanetListele();//Method çağrılmıştır.
        }
        private void btnCikisK_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Diyalog  tanımlanmıştır.
           
            secim = MessageBox.Show("Programı kapatmak istiyor musun?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçer ise bir if else döngüsü başlıyacaktır.
            {
                Application.Exit();//Projenin tamamen kapanacaktır.
            }
        }
        private void btnGeriK_Click(object sender, EventArgs e)
        {
             DialogResult secim = new DialogResult();//Diyalog  tanımlanmıştır.
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmiştir.
            secim = MessageBox.Show("Emanet kitap sayfa ekranına dönmek istiyor musunuz?", "Geri Gel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneğini seçer ise bir if else döngüsü başlıyacaktır.
            {
                EmanetKitapSayfasi emanetKitapSayfasi = new EmanetKitapSayfasi();//Ekran tanımlanmıştır.
                emanetKitapSayfasi.Show();//Ekran gösterilmiştir.
                this.Hide();//Önceki ekran kapatılmıştır.
            }
        }
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["TblEmanetKitap"].Clear();//Tablo temizlenmiştir
            baglanti.Open();//Sql bağlantısı açılmıştır.
            //Tc ile arama sorgusu dataAdapter yardımıyla yazılmıştır.
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from TblEmanetKitap where Tc like '%"+txtTc.Text+"%'", baglanti);
            dataAdapter.Fill(ds, "TblEmanetKitap");
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
            if (txtTc.Text=="")//Texbox boş ise
            {
                ds.Tables["TblEmanetKitap"].Clear();//Tablo temizlemiştir.
                EmanetListele();//Method çağrılmıştır.
            }                
        }
        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["TblEmanetKitap"].Clear();//Tablo temizlenmiştir
            baglanti.Open();//Sql bağlantısı açılmıştır.
            //Tc ile arama sorgusu dataAdapter yardımıyla yazılmıştır.
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from TblEmanetKitap where BarkodNo like '%" + txtBarkodNo.Text + "%'", baglanti);
            dataAdapter.Fill(ds, "TblEmanetKitap");
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
            if (txtBarkodNo.Text == "")//Texbox boş ise
            {
                ds.Tables["TblEmanetKitap"].Clear();//Tablo temizlemiştir.
                EmanetListele();//Method çağrılmıştır.
            }
        }
        private void btnİadeEt_Click(object sender, EventArgs e)
        {
            baglanti.Open();//Sql bağlantısı açılmıştır.
            //Silme işlemi için Tc ve Barkod No dan almak için sorgu yazılmıştır.
            SqlCommand komut = new SqlCommand("delete from TblEmanetKitap where Tc=@Tc and BarkodNo=@BarkodNo", baglanti);
            //Tc alanının yerini bulması için yazılmıştır.
            komut.Parameters.AddWithValue("@Tc",dataGridView1.CurrentRow.Cells["Tc"].Value.ToString());
            //BarkodNo alanının yerini bulması için yazılmıştır.
            komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut.ExecuteNonQuery();//işlem onaylanmıştır.
            //Stoksayısını geri artırmak için sorgu yazılmıştır.
            SqlCommand komut2 = new SqlCommand("update TblKitap set StokSayısı=StokSayısı+'"+dataGridView1.CurrentRow.Cells["KitapSayisi"].Value.ToString()+
                "' where BarkodNo=@BarkodNo ", baglanti);
            //BarkodNo alanının yerini bulması için yazılmıştır.
            komut2.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut2.ExecuteNonQuery();//işlem onaylanmıştır.
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
            MessageBox.Show("Kitaplar iade edilmiştir.");//Mesaj verilmiştir.
            ds.Tables["TblEmanetKitap"].Clear();//Tablo temizlemiştir.
            EmanetListele();//Method çağrılmıştır.   
        }
    }
}
