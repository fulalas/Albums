using Albums.web.Repository;
using System.Web.Mvc;

namespace Albums.web.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumRepository _albumRepository;

        public AlbumController(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public ActionResult Index(int albumId)
        {
            ViewBag.albums = _albumRepository.getAlbums(albumId);
            ViewBag.albumId = albumId;
            return View();
        }
    }
}