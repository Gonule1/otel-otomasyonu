using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
 
namespace kayıtFormu_vs2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ATHREF5;Initial Catalog=kullanicilar;Integrated Security=True");
 
        private void Button1_Click(object sender, EventArgs e)
        {
            bool cinsiyet = false;
 
            if (rdbErkek.Checked == true)
            {
                cinsiyet = true;
            }
            else if (rdbKadin.Checked == true)
            {
                cinsiyet = false;
            }
            else
            {
                cinsiyet = false;
            }
            
            string ekle = "INSERT INTO kullanicilar(isim,soyisim,telefon,tc,adres,cinsiyet) values (@isim," +
                " @soyisim, @telefon, @tc, @adres, @cinsiyet)";
 
            SqlCommand komut = new SqlCommand();
            komut = new SqlCommand(ekle, baglanti);
            baglanti.Open();
 
            komut.Connection = baglanti;
 
            komut.Parameters.AddWithValue("@isim", txtIsim.Text);
            komut.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
            komut.Parameters.AddWithValue("@telefon", mskTelefon.Text);
            komut.Parameters.AddWithValue("@tc", mskTc.Text);
            komut.Parameters.AddWithValue("@adres", rchAdres.Text);
            komut.Parameters.AddWithValue("@cinsiyet",cinsiyet);
 
            komut.ExecuteNonQuery();
            baglanti.Close();
 
        }
    }
}