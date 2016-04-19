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
                Name = "Aida Baydono"
            };
            Assert.Equal("Aida Baydono", user.Name);
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
