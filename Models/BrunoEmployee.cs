using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class BrunoEmployee
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        [Required]
        public long Salary { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
}