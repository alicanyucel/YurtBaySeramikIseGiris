using NLog;

namespace YurtbaySeramik.Core.Helper
{
    public class globalIslemler
    {
        public void TryCatchKullan(Action action)
        {
			try
			{
				action();
			}
			catch (Exception ex)
			{
				string ExStr=Newtonsoft.Json.JsonConvert.SerializeObject(ex);
				var logger = NLog.LogManager.GetCurrentClassLogger();
				logger.Log(LogLevel.Error,ex.Message);
			}
        }
    }
}
