using System.Net.Mail;
namespace YurtbaySeramik.Core.Helper
{
    public class EpostaIslemler
    {
        public static void MailGonder(string isimSoyisim, string mailadres, string konu, string icerik)
        {
            MailMessage mail = new MailMessage();
            mail.From=new MailAddress("yucelalican@hotmail.com","merhaba");
            mail.To.Add(new MailAddress(mailadres, isimSoyisim));
            mail.Subject=konu;
            mail.Body=icerik;
            mail.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("live.hotmail.com",587);
            client.Credentials = new System.Net.NetworkCredential("yucelalican@hotmail.com", "torku123.");
            client.EnableSsl = false;
            client.Send(mail);
        }
    }
}
