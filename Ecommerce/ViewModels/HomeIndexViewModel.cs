using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;

namespace Ecommerce.ViewModels
{
    public class HomeIndexViewModel
    {
        public ICollection <Basket> Baskets { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Favourite> Favourites { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
