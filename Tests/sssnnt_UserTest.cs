using Xunit;
using MvcSample.Web.Models;  

namespace MvcSample.Tests
{
    public class sssnnt_UserTest
    {
        [Fact]
        public void NameTest()
        {
            User user = new sssnnt_User()
            {
                Name = "Lennart Kjellén"
            };
            Assert.Equal("Lennart Kjellén", user.Name);
        }
    }
}
