using YurtbaySeramik.Entities;

namespace YurtbaySeramik.Core.Interface
{
    public interface IPersonelRepository
    {
        int KayitEkle(Personel p);
        List<Personel> TumPersonel();
        Personel GetirId(int id);
    }
}
