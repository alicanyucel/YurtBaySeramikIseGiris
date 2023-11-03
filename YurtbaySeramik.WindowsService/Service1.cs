using System.Timers;
using System.ServiceProcess;
using System.Collections.Generic;
namespace YurtbaySeramik.WindowsService
{
    public partial class Service1 : ServiceBase
    {
        Timer t;
        public Service1()
        {
            InitializeComponent();
            t = new Timer(6000); // 6 saniyede bir kez çalışsın
            t.Elapsed += T_Elapsed;
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            using (PersonelRepository personelrepo = new PersonelRepository())
            {
                List<Personel> personelListele = personelrepo.TumPersonel();
                for (int i = 0; i < personelListele.Count; i++)
                {
                    if (string.IsNullOrEmpty(personelListele[i].Ad))
                    {
                       
                        // Eposta Gönderme işlemi 

                        string MailIcerik = string.Empty;
                        MailIcerik += "<div>";
                        MailIcerik += "<p>Merhaba</p>";
                        MailIcerik += "<p> " + personelListele[i].Ad + " " + personelListele[i].Soyad + "</p>";
                        MailIcerik += "<di>";
                        EpostaIslemleri.emailGonder(personelListele[i].Ad + " " + personelListele[i].Soyad, personelListele[i].EmailAdres, "Merhaba", MailIcerik);

                    }
                }
            }
        }
    protected override void OnContinue()
        {
            t.Start();
        }
        protected override void OnStart(string[] args)
        {
            t.Start();
        }

        protected override void OnStop()
        {
            t.Stop();
        }
        protected override void OnShutdown()
        {
            t.Stop();
        }
        protected override void OnPause()
        {
            t.Stop();
        }
    }
}
