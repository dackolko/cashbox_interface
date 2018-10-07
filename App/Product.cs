using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Product
    {
        private readonly string name;
        private readonly string sku;
        private int price;

        public Product(string name, string sku, int price)
        {
            this.name = name;
            this.sku = sku;
            this.price = price;
        }

        public int Price()
        {
            return price; 
        }
        public string Name()
        {
            return name;
        }
        public string SKU()
        {
            return sku;
        }
    }
}
