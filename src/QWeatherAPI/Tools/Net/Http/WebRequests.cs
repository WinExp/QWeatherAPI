using System.Net;
using System.Text;

namespace QWeatherAPI.Tools.Net.Http
{
    internal static class WebRequests
    {
        #region Http 请求方法
        internal static async Task<string> GetRequestAsync(string Url)
        {
            Url = Url.Trim();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Proxy = null;
            request.KeepAlive = false;
            request.Method = "GET";
            request.ContentType = "application/json; charset=UTF-8";
            request.AutomaticDecompression = DecompressionMethods.GZip;

            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            using (Stream myResponseStream = response.GetResponseStream())
            {
                using (StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8))
                {
                    string retString = myStreamReader.ReadToEnd();
                    if (response != null)
                    {
                        response.Close();
                    }
                    if (request != null)
                    {
                        request.Abort();
                    }

                    return retString;
                }
            }
        }
        #endregion
    }
}
