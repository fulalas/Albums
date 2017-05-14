using Albuns.site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Albuns.site.Repository
{
    public class AlbumRepository
    {
        public List<Album> getAlbuns(int id)
        {
            var url = @"https://jsonplaceholder.typicode.com/albums";
            var readJason = new ReadJason();
            return readJason.readUrl<Album>(url).ToList().Where(x => x.userId == id).ToList();
        }
    }
}