using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class SuchetaUserTest
    {
        [Fact]
        public void NameTest()
        {
            User user = new User()
            {
                Name = "Sucheta Biswas"
            };
            Assert.Equal("Sucheta Biswas", user.Name);
        }
    }
}
