using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass in the requested id
            Product product = new Product(productId);
            
            // Code that retrieves the defined product

            // Temporary hard-coded values to return
            // a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Set of 4 mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            // Code that saves the passed in product

            return true;
        }

    }
}
