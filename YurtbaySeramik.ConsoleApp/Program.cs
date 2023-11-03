using YurtbaySeramik.Core.Repository;
using YurtbaySeramik.Entities;
using YurtbaySeramik.Core.Helper;

class Program
{
    static void Main(string[] args)
    {
        string MailIcerik = "";
        using (PersonelRepository personelRepository = new PersonelRepository())
        {
            List<Personel> personelListele = personelRepository.TumPersonel();
            for (int i = 0; i < personelListele.Count; i++) // 10 adet kayıt var veri tabanına eklendi.
            {
                if (string.IsNullOrEmpty(personelListele[i].Ad)) 
                {
                    MailIcerik += "<div>";
                    MailIcerik += "<p>Merhaba</p>";
                    MailIcerik += "</div>";
                    EpostaIslemleri.emailGonder(personelListele[i].Ad + " " + personelListele[i].Soyad + " " + personelListele[i].Yas + " " + personelListele[i].Unvan + " " + personelListele[i].Birim + " " + personelListele[i].IseBaslamaTarihi);
                }

            }

            Console.ReadKey();
        }
    }
}