using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class UserGustav
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}