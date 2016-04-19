using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class UserTest
    {
        [Fact]
        public void NameTest()
        {
            User user = new User()
            {
                Name = "GitHub Developer"
            };
            Assert.Equal("GitHub Developer", user.Name);
        }
    }
}
