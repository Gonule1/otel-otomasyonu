string sifre;
private void btnGonder_Click(object sender, EventArgs e)
{
   try
   {
      SqlConnection baglanti = new SqlConnection("Data Source=ONUR;Initial Catalog=Mutakabat;Integrated Security=True");
      if (baglanti.State == ConnectionState.Closed)
      {
        baglanti.Open();
      }
      SqlCommand komut = new SqlCommand("select * from users where mail='" + txtMail.Text + "'");
      komut.Connection = baglanti;
      SqlDataReader oku = komut.ExecuteReader();
      if (oku.Read())
      {
        sifre = oku["sifre"].ToString();

        lblHata.Visible = true;
        lblHata.ForeColor = Color.Green;
        lblHata.Text = "Girmiş Olduğunuz Bilgiler Uyuşuyor Şifreniz Mail Olarak Gönderildi";

        progressBar1.Visible = true;
        progressBar1.Maximum = 900000;
        progressBar1.Minimum = 90;

        for (int j = 90; j < 900000; j++)
        {
          progressBar1.Value = j;
        }

        MailGonder("ŞİFRE HATIRLATMA", "Şifreniz: " + sifre);
        baglanti.Close();
      }
      else
      {
         lblHata.Visible = true;
         lblHata.ForeColor = Color.Red;
         lblHata.Text = "Girmiş Olduğunuz Bilgiler Uyuşmuyor";
      }
   }
   catch (Exception)
   {
      lblHata.Visible = true;
      lblHata.ForeColor = Color.Red;
      lblHata.Text = "Mail Gönderme Hatası";
   }

}