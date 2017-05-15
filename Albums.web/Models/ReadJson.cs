using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Albums.web.Models
{
    public class ReadJson
    {
        public List<T> readUrl<T>(string url)
        {
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new DataContractJsonSerializer(typeof(List<T>));

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                return (List<T>)serializer.ReadObject(ms);
            }
        }
    }
}