using Xunit;
using MvcSample.Web.Models;

namespace MvcSample.Tests
{
    public class WooshUserTest
    {
        [Fact]
        public void EmailTest()
        {
            var user = new WooshUser()
            {
                Email = "mail@example.com"
            };
            Assert.Equal("mail@example.com", user.Email);
        }

        [Fact]
        public void SkypeTest()
        {
            var user = new WooshUser()
            {
                Skype = "SkypeUser"
            };
            Assert.Equal("SkypeUser", user.Skype);
        }

        [Fact]
        public void SlackTest()
        {
            var user = new WooshUser()
            {
                Slack = "a-slack-handle"
            };
            Assert.Equal("a-slack-handle", user.Slack);
        }

        [Fact]
        public void TwitterTest()
        {
            var user = new WooshUser()
            {
                Twitter = "justAnotherAccount"
            };
            Assert.Equal("justAnotherAccount", user.Twitter);
        }

    }
}
