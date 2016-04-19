using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class BasUserTest
    {
        [Fact]
        public void NameTest()
        {
            BasUser user = new BasUser()
            {
                Role = "Solutions Engineer"
            };
            Assert.Equal("Engineer", BasUser.Role);
        }
    }
}
