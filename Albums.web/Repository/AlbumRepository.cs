using Albums.web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Albums.web.Repository
{
    public interface IAlbumRepository
    {
        List<Album> getAlbums(int id);
    }

    public class AlbumRepository : IAlbumRepository
    {
        public List<Album> getAlbums(int id)
        {
            var url = @"https://jsonplaceholder.typicode.com/albums";
            var readJason = new ReadJson();
            return readJason.readUrl<Album>(url).ToList().Where(x => x.userId == id).ToList();
        }
    }
}