

private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
  this.Hide();
  sifremiunuttum frm = new sifremiunuttum();
  frm.Show();
}







public bool MailGonder(string konu, string icerik)
{
   MailMessage ePosta = new MailMessage();
   ePosta.From = new MailAddress("Mail Adresiniz.");
   ePosta.To.Add(txtMail.Text); //göndereceğimiz mail adresi

   ePosta.Subject = konu; //mail konusu
   ePosta.Body = icerik; //mail içeriği 

   SmtpClient client = new SmtpClient();
   client.Credentials = new System.Net.NetworkCredential("Mail Adresiniz.", "Mail Şifreniz.");
   client.Port = 587;
   client.Host = "smtp.outlook.com";
   client.EnableSsl = true;
   client.Send(ePosta);
   object userState = true;
   bool kontrol = true;
   try
   {
     client.SendAsync(ePosta, (object)ePosta);
   }
   catch (SmtpException ex)
   {
     kontrol = false;
     MessageBox.Show(ex.Message);
   }
   return kontrol;
}