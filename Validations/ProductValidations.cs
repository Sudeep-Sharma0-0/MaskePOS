using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskePOS.Validations
{
    public static class ProductValidations
    {
        public static bool DataTypeValidation(Product product)
        {
            if (product == null)
            {
                MessageBox.Show("No Product Passed! \n If you see this error, contact admin");
                return false;
            }
            if (product.Name == null || product.Name == "")
            {
                MessageBox.Show("Product must have a name!");
                return false;
            }
            if (product.Price == 0)
            {
                MessageBox.Show("Product must have a price!");
                return false;
            }
            if (product.Price.GetType() != typeof(decimal))
            {
                MessageBox.Show("Product's price must be Decimal!");
                return false;
            }

            return true;
        }
    }
}