using System;
using System.Collections.Generic;
using System.Text;

namespace KassaSysteem
{
    public class Stock
    {
        private Dictionary<int, Product> productsInStock = new Dictionary<int, Product>();

        public void AddItem(Product product)
        {
            productsInStock.Add(1, product);
        }

        public void RemoveItem(Product product)
        {
            productsInStock.Remove(1, out product);
        }
    }
}
