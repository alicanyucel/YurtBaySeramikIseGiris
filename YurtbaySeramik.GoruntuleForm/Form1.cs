using YurtbaySeramik.Core.Repository;
using YurtbaySeramik.Entities;

namespace YurtbaySeramik.GoruntuleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KayitListele();
        }

        private void grbxPersonel_Enter(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // 1 tanew kayýt alacam fake data 
            for (int i = 0; i < 1; i++)
            {
                Personel personel = new Personel();
                personel.Ad = FakeData.NameData.GetFirstName();
                personel.Soyad = FakeData.NameData.GetSurname();
                using (PersonelRepository personelRepository = new PersonelRepository())
                {
                    personelRepository.KayitEkle(personel);
                }
            }
            KayitListele();
        }
        void KayitListele()
        {
            List<Personel> personelListesi = new List<Personel>();
            using (PersonelRepository personelrepo = new PersonelRepository())
            {
                personelListesi = personelrepo.TumPersonel();
            }
            dtgPersonel.DataSource = personelListesi;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            KayitListele();
        }
    }
}