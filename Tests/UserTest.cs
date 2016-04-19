using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class UserTest
    {
        [Fact]
        public void NameTest()
        {
            KanchanUser user = new KanchanUser()
            {
                Name = "Kanchan Gaikwad"
            };
            Assert.Equal("Kanchan Gaikwad", user.Name);
        }
    }
}
