using System.Data.SqlClient;
using YurtbaySeramik.Core.Helper;

namespace YurtbaySeramik.Core.Database
{
    public class DataAccessLayer : globalIslemler
    {
        public SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        int ReturnValue;
        public OataAccessLayer()
        {
            con = new SqlConnection("data source=DESKTOP-ROTCU0Q,inital catalog=;Deneme;Integrated Security = True;TrustServerCertificate=True");

        }
        public int Calistir(SqlCommand cmd)
        {
            cmd.Connection = con;
            con.Open();// bağlantıyı aç
            TryCatchKullan(() =>
            {
                ReturnValue = cmd.ExecuteNonQuery();
            });
            con.Close();
            return ReturnValue;
        }
        public SqlDataReader VeriGetir(SqlCommand cmd)
        {
            cmd.Connection = con;
            con.Open();
            TryCatchKullan(() =>
            {
                reader = cmd.ExecuteReader();
            });
            return reader;
        }
        public int CalistirInt(SqlCommand cmd)
        {
            cmd.Connection = con;
            con.Open();
            TryCatchKullan(() =>
            {
                ReturnValue = (int)cmd.ExecuteScalar();
            });
            con.Close();
            return ReturnValue;
        }
    }
}
