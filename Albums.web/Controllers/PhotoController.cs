using Albums.web.Repository;
using System.Web.Mvc;

namespace Albums.web.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoRepository _photoRepository;

        public PhotoController(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public ActionResult Index(int albumId, int photoId)
        {
            ViewBag.photos = _photoRepository.getPhotos(photoId);
            ViewBag.albumId = albumId;
            return View();
        }
    }
}