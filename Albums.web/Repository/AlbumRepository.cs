using Albums.web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Albums.web.Repository
{
    public interface IAlbumRepository
    {
        List<Album> getAlbums(int userId);
    }

    public class AlbumRepository : IAlbumRepository
    {
        public List<Album> getAlbums(int userId)
        {
            var url = @"https://jsonplaceholder.typicode.com/albums";
            var readJson = new ReadJson();
            return readJson.readUrl<Album>(url).Where(x => x.userId == userId).ToList();
        }
    }
}