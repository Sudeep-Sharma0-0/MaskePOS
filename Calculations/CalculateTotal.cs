using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskePOS.Calculations
{
    class CalculateTotal
    {
        public decimal Total { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DisPercent { get; set; }
        public decimal DisAmount { get; set; }
        public List<Product> Products { get; set; }

        public CalculateTotal(List<Product> products, decimal taxp, decimal disp=0)
        {
            this.TaxPercentage = taxp;
            this.DisPercent = disp;
            this.Products = products;

            for (int i = 0; i < products.Count; i++)
            {
                this.Total += products[i].Price;
            }

            this.DisAmount = (disp / 100) * this.Total;
            this.Total -= DisAmount;

            this.TaxAmount = (taxp / 100) * this.Total;
            this.Total += TaxAmount;
        }
    }
}
