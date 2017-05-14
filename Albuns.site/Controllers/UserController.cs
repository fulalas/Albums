using Albuns.site.Repository;
using System.Web.Mvc;

namespace Albuns.site.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        public ActionResult Index()
        {
            ViewBag.users = _userRepository.getUsers();
            return View();
        }
    }
}