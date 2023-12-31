﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }

        public Product(string title, decimal weight, decimal price) :this()
        {
            Title = title;
            Weight = weight;
            Price = price;
        }
    }

}
