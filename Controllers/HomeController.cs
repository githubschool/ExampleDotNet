using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(CreateUser());
        }

        public LGTaubeUser CreateUser()
        {
            LGTaubeUser user = new LGTaubeUser()
            {
                Name = "LG Taube",
                Address = "Internet"
            };

            return user;
        }
    }
}