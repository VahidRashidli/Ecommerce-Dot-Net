using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountInStock { get; set; }
        public Category Category { get; set; }
        public List<Order> Orders { get; set; }
        public List<Basket> Baskets { get; set; }
        public List<Favourite> Favourites{ get; set; }
    }
}
