using System.Data;
using System.Data.SqlClient;
using YurtbaySeramik.Core.Database;
using YurtbaySeramik.Core.Helper;
using YurtbaySeramik.Core.Interface;
using YurtbaySeramik.Entities;

namespace YurtbaySeramik.Core.Repository
{
    public class PersonelRepository : globalIslemler,IPersonelRepository
    {
        SqlCommand cmd;
        SqlDataReader reader;
        int ReturnValue;
        DataAccessLayer Dal;
        public PersonelRepository()
        {
            Dal = new DataAccessLayer();
        }
        public Personel GetirId(int ID)
        {
            Personel personel = new Personel();
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("PersonelGetirId");
                // stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID",SqlDbType.Int).Value=ID;
                Dal.VeriGetir(cmd);
            // verileri oku
            while (reader.Read())
                {
                  
                  personel=new Personel()
                  {
                      Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                      Ad = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                      Soyad = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                      Yas = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                      Unvan = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                      Birim = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                      IseBaslamaTarihi = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6),

                  } ;
                }
                reader.Close();
                Dal.con.Close();

            });
            return personel;

        }

        public int KayitEkle(Personel p)
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("KayitEkle");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ad",SqlDbType.NVarChar).Value=p.Ad;
                cmd.Parameters.Add("@Soyad", SqlDbType.NVarChar).Value = p.Soyad;
                cmd.Parameters.Add("Yas", SqlDbType.Int).Value = p.Yas;
                cmd.Parameters.Add("Birim", SqlDbType.NVarChar).Value = p.Birim;
                cmd.Parameters.Add("Unvan", SqlDbType.NVarChar).Value = p.Unvan;
                cmd.Parameters.Add("IseBaslamaTarihi", SqlDbType.DateTime).Value = p.IseBaslamaTarihi;
                ReturnValue=Dal.Calistir(cmd);
            });
            return ReturnValue;
        }

        public List<Personel> TumPersonel()
        {
            List<Personel> personelListe = new List<Personel>();
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("PersonelListe");
                // stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Dal.VeriGetir(cmd);
                // verileri oku
                while (reader.Read())
                {
                    personelListe.Add(new Personel()
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Ad = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Soyad = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Yas = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                        Unvan = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Birim = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        IseBaslamaTarihi = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6),

                    });
                }
                reader.Close();
                Dal.con.Close();

            });
            return personelListe;
        }
    }
}
