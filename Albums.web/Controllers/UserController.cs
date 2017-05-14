using Albums.web.Repository;
using System.Web.Mvc;

namespace Albums.web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ActionResult Index()
        {
            ViewBag.users = _userRepository.getUsers();
            return View();
        }
    }
}