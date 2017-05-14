using Albuns.site.Repository;
using System.Web.Mvc;

namespace Albuns.site.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AlbumRepository _albumRepository;

        public AlbumController()
        {
            _albumRepository = new AlbumRepository();
        }

        public ActionResult Index(int id)
        {
            ViewBag.albums = _albumRepository.getAlbuns(id);
            return View();
        }
    }
}