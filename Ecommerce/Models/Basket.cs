using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        [Required] // A Basket may not have orders but it must always have a customer
        public User User { get; set; }
    }
}
