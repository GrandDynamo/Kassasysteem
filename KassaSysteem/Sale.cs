using System;
using System.Collections.Generic;
using System.Text;

namespace KassaSysteem
{
    public class Sale
    {
        List<Product> productTypes = new List<Product>();
        private double PriceSale;

        public Sale(double PriceSale)
        {
            this.PriceSale = PriceSale;
        }

        public double GetPriceSale()
        {
            return this.PriceSale;
        }

        public void AddProductToSale(Product product)
        {
            productTypes.Add(product);
        }

        public void DeleteProductFromSale(Product product)
        {
            productTypes.Remove(product);
        }

        public void GetAllItemFromList()
        {
            foreach(Product item in productTypes)
            {
                Console.WriteLine(item.GetProductName());
            }
        }
    }
}
