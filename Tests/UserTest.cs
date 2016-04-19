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
                Name = "Kanchan Gaikwad"
            };
            Assert.Equal("Kanchan Gaikwad", user.Name);
        }
    }
}
