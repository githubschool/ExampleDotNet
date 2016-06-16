using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(CreateEmployee());
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
        
        public Employee CreateEmployee()
        {
            Employee emp = new Employee()
            {
                Name = "Jayesh Pawar",
                EmployeeID = 123,
                OfficeLocation = "210"
            };

            return emp;
        }
    }
}