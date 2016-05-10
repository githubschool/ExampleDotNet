using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class AnneUser
    {
        [Required]
        [MinLength(10)]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int Age { get; set; }
    }
}