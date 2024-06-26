﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskePOS
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }

        public Product(string name, decimal price, string desc)
        {
            this.Name = name;
            this.Price = price;
            this.Desc = desc;
        }
    }
}