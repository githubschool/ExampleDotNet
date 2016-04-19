using ExampleDotNet.Models;
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

        public User CreateUser()
        {
            User user = new User()
            {
                Name = "Bas Peters",
                Address = "Weteringschans 165"
            };

            return user;
        }

        public FBProduct CreateProduct()
        {
            FBProduct product = new FBProduct()
            {
                Name = "Bas Peters",
                Description = "Weteringschans 165"
            };

            return product;
        }

    }
}