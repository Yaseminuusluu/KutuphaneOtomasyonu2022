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
    public partial class EmanetKitapListeleme : Form
    {
        public EmanetKitapListeleme()
        {
            InitializeComponent();
        }
        //Sql bağlantısı tanımlanması.
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IVFG7VD\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        DataSet ds = new DataSet();//Sql veri almasını sağlamıştır

        private void EmanetKitapListeleme_Load(object sender, EventArgs e)
        {
            EmanetKitapListele();//Yazılan method çağrılmıştır.
        }
        private void EmanetKitapListele()
        {
            baglanti.Open();//Sql bağlantısı açılmıştır.
            SqlDataAdapter adapter = new SqlDataAdapter("select*from TblEmanetKitap", baglanti);//Veri arasındaki köprü için sorgu yazılmıştır.
            adapter.Fill(ds, "TblEmanetKitap");//Data getirilmiştir.
            dataGridView1.DataSource=ds.Tables["TblEmanetKitap"];//DataGridView'e tablo bağlantısı sağlanmıştır.
            baglanti.Close();//Sql bağlantısı kapatılmıştır.
        }

        private void btnGeriK_Click(object sender, EventArgs e)
        {
            EmanetKitapSayfasi emanetKitapSayfasi = new EmanetKitapSayfasi();//Ekran tanımlaması yapılmıştır.
            emanetKitapSayfasi.Show();//Ekran gözükmesi için show methodu yazılmıştır.
            this.Hide();//Bir önceki sayfa saklanmıştır.
        }

        private void btnCikisK_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();//Dialog tanımlanmıştır.
            //Mesaj kutusu ile evet hayırlı bir soru mesajı verilmiştir.
            secim = MessageBox.Show("Programı kapatmak istiyor musun?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)//Eğer evet seçeneği seçilir ise if döngüsü devreye girer
            {
                Application.Exit();//Projenin tamamen kapatılması sağlanmıştır.
            }
        }
    }
}
