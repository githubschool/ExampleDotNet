using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class KenthUserTest
    {
        [Fact]
        public void NameTest()
        {
            User user = new User()
            {
                Name = "Kenth"
            };
            Assert.Equal("Kenth", user.Name);
        }
    }
}
