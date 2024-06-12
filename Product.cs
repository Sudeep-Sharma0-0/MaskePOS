using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskePOS
{
    class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }

        public Product(string id, string name, decimal price, string desc, string image)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Desc = desc;
            this.Image = image;
        }
    }
}