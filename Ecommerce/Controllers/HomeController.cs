using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.DAL;
using Ecommerce.Models;
using Ecommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // We add info only once here so that it doesn't repeat the same info every time we run the app

            //Role role1 = new Role() { Name = "Customer" };
            //Role role2 = new Role() { Name = "EmployeeRole1" };
            //User user1 = new User() { Name = "Vahid", Surname = "Rashidli", Role = role1};
            
            //Category category1 = new Category() { Name = "Electronics"};
            //Product product1 = new Product() { Name = "Iphone x",CountInStock=3,Category=category1 };
            //category1.Products = new List<Product>();
            //category1.Products.Add(product1);
            //Order order1 = new Order() { Product = product1, User = user1 };
            //product1.Orders = new List<Order>();
            //product1.Orders.Add(order1);
            //Basket basket1 = new Basket() { User = user1 };
            //basket1.Products = new List<Product>();
            //basket1.Products.Add(product1);
            //product1.Baskets = new List<Basket>();
            //product1.Baskets.Add(basket1);
            //Favourite favourite1 = new Favourite() { User = user1 };
            //favourite1.Products = new List<Product>();
            //favourite1.Products.Add(product1);
            //product1.Favourites = new List<Favourite>();
            //product1.Favourites.Add(favourite1);

            //_context.Baskets.Add(basket1);
            //_context.Categories.Add(category1);
            //_context.Favourites.Add(favourite1);
            //_context.Orders.Add(order1);
            //_context.Products.Add(product1);
            //_context.Roles.Add(role1);
            //_context.Roles.Add(role2);
            //_context.User.Add(user1);
            //_context.SaveChanges();
            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel()
            {
                Baskets = _context.Baskets.ToList(),
                Categories = _context.Categories.ToList(),
                Favourites=_context.Favourites.ToList(),
                Orders=_context.Orders.ToList(),
                Products=_context.Products.ToList(),
                Roles=_context.Roles.ToList(),
                Users=_context.User.ToList(),                
            };
            return View(homeIndexViewModel);
        }
    }
}
