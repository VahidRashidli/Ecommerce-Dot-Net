using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Favourite
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public User User { get; set; }
    }
}
