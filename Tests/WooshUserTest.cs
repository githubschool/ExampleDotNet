using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class WooshUserTest
    {
        [Fact]
        public void EmailTest()
        {
            var user = new WooshUser()
            {
                Email = "mail@example.com"
            };
            Assert.Equal("mail@example.com", user.Email);
        }
    }
}
