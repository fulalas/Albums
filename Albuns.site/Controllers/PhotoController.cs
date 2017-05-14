using Albuns.site.Repository;
using System.Web.Mvc;

namespace Albuns.site.Controllers
{
    public class PhotoController : Controller
    {
        private readonly PhotoRepository _photoRepository;

        public PhotoController()
        {
            _photoRepository = new PhotoRepository();
        }

        public ActionResult Index(int albumId, int id)
        {
            ViewBag.photos = _photoRepository.getPhotos(id);
            ViewBag.albumId = albumId;
            return View();
        }
    }
}