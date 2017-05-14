using Albuns.site.Models;
using System.Collections.Generic;
using System.Linq;

namespace Albuns.site.Repository
{
    public interface IPhotoRepository
    {
        List<Photo> getPhotos(int albumId);
    }

    public class PhotoRepository : IPhotoRepository
    {
        public List<Photo> getPhotos(int albumId)
        {
            var url = @"https://jsonplaceholder.typicode.com/photos";
            var readJason = new ReadJson();
            return readJason.readUrl<Photo>(url).ToList().Where(x => x.albumId == albumId).ToList();
        }
    }
}