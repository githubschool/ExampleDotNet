using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleDotNet.Models
{
    public class FBProduct
    {
        [Required]
        [MinLength(6)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
