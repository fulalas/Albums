using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Albuns.site.Models
{
    public class ReadJson
    {
        public T[] readUrl<T>(string url)
        {
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T[]));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                return (T[])serializer.ReadObject(ms);
            }
        }
    }
}