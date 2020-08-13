using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Chocolate.Models
{

    public class Object
    {

    }
    public class FlavoursDetail
    {
        public int Id { get; set; }
        [Display(Name = "Flavour")]
        public string Title { get; set; }
        [Display(Name = "Product Description")]
        public productDescription Product { get; set; }
        [Display(Name = "Price for each")]
        public decimal Price { get; set; }

        
    }

    
}
