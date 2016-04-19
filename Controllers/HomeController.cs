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

        public UserBanenen CreateUser()
        {
            var user = new UserBanenen()
            {
                Name = "Fritz schnitzell",
                Address = "Weteringschans 165",
                Age = 134,
                Bendition = 80,
                Yellowness = 3            
            };

            return user;
        }
    }
}