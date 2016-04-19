using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class BanenenUserTest
    {
        [Fact]
        public void NameTest()
        {
            var user = new UserBanenen()
            {
                Name = "Bas Peters",
                Yellowness = 4
            };
            Assert.Equal("Bas Peters", user.Name);
            Assert.Equal(4, user.Yellowness);
        }
    }
}
