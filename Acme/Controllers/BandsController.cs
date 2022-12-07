using Microsoft.AspNetCore.Mvc;

namespace FavoritArtister.Controllers
{
    public class BandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
