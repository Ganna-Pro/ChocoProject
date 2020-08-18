using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;

namespace Chocolate.Models
{
    public class Flavours
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Flavour { get; set; }
        [Required]
        public int Price { get; set; }

        public Flavours(string flavour, int price)
        {
            Flavour = flavour;
            Price = price;
        }
    }
}
