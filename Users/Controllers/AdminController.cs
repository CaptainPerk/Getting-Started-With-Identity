using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Users.Models;

namespace Users.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public ViewResult Index() => View(_userManager.Users);
    }
}
