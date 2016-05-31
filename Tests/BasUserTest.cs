using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class BasUserTest
    {
        [Fact]
        public void RoleTest()
        {
            BasUser user = new BasUser()
            {
                Name  = "Bas Peters",
                Role = "Solutions Engineer"
            };
            Assert.Equal("Solutions Engineer", user.Role);
        }
        
        [Fact]
        public void CompanyTest()
        {
            BasUser user = new BasUser()
            {
                Name  = "Bas Peters",
                Company = "GitHub"
            };
            Assert.Equal("GitHub", user.Company);
        }
    }
}
