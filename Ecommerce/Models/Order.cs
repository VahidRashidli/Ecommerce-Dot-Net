﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Product Product { get; set; }
    }
}
