using Albuns.site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Albuns.site.Repository
{
    public class PhotoRepository
    {
        public List<Photo> getPhotos(int albumId)
        {
            var url = @"https://jsonplaceholder.typicode.com/photos";
            var readJason = new ReadJason();
            return readJason.readUrl<Photo>(url).ToList().Where(x => x.albumId == albumId).ToList();
        }
    }
}