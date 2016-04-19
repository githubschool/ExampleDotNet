using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class WooshUser : User
    {
        public string Email {get; set; }
    }
}