using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class RegUser_01
    {
        [Required]
        [MinLength(4)]
        public string RefName { get; set; }
        public string RefAddress01 { get; set; }
        public int RefAge { get; set; }
    }
}
