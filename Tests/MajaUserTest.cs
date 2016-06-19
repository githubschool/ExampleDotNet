using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class MajaUserTest
    {
        [Fact]
        public void NameTest()
        {
            MajaUser user = new MajaUser()
            {
                FirstName = "Maja"
            };
            Assert.Equal("Maja", user.FirstName);
        }

        [Fact]
        public void PetTest()
        {
            MajaUser user = new MajaUser()
            {
                Pet = "OctoCat"
            };
            Assert.Equal("OctoCat", user.Pet);
        }
    }
}
