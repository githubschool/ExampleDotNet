using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class MatsSkoglund_UserTest
    {
        [Fact]
        public void NameTest()
        {
            MatsSkoglund_User user = new MatsSkoglund_User()
            {
                Name = "Skoglund Mats"
            };
            Assert.Equal("Skoglund Mats", user.Name);
        }
    }
}

