using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public partial class UserTestSsseqj
    {
        [Fact]
        public void NameTest()
        {
            User user = new User()
            {
                Name = "Johan Eriksson"
            };
            Assert.Equal("Johan Eriksson", user.Name);
        }

        [Fact]
        public void AgeTest()
        {
            User user = new User()
            {
               Age = 20
            };
            Assert.Equal(2, user.Age);
        }
    }
}
