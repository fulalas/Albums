using Albuns.site.Repository;
using System.Web.Mvc;

namespace Albuns.site.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoRepository _photoRepository;

        public PhotoController(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public ActionResult Index(int albumId, int id)
        {
            ViewBag.photos = _photoRepository.getPhotos(id);
            ViewBag.albumId = albumId;
            return View();
        }
    }
}