using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace SocialMediaLinks.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<SocialMediaLinksOptions> _linkOptions;
        public HomeController(IOptions<SocialMediaLinksOptions> linkOptions)
        {
            _linkOptions = linkOptions;
        }
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.Twitter = _linkOptions.Value.Twitter;
            ViewBag.YouTube = _linkOptions.Value.Youtube;
            ViewBag.Instagram = _linkOptions.Value.Instagram;
            ViewBag.Facebook = _linkOptions.Value.Facebook;
            return View();
        }
    }
}
