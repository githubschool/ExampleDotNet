using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class AnnaHallRiveraUser
    {
        [Required]
        [MinLength(4)]
        public string myName { get; set; }
        public string myAddress { get; set; }
        public int myAge { get; set; }
    }
}