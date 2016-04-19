using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class WooshUser : User
    {
        public string Email {get; set; }
        public string Slack { get; set; }
        public string Skype { get; set; }
        public string Twitter { get; set; }
    }
}