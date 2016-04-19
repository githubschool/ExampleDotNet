using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class UserTest
    {
        [Fact]
        public void AddressTest()
        {
            User user = new User()
            {
                Address = "Högmovägen 21"
            };
            Assert.Equal("Högmovägen 21", user.Address);
        }
        
        [Fact]
        public void AgeTest()
        {
            User user = new User()
            {
                Age = 43
            };
            Assert.Equal(43, user.Age);
        }
    }
}
