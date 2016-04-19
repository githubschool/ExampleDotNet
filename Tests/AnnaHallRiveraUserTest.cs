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
                Name = "Anna H�ll Rivera"
            };
            Assert.Equal("Anna H�ll Rivera", user.Name);
        }
    }
}
