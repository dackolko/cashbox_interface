using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Item
    {
        private Product product;
        private int q;

        public Item(Product product, int q)
        {
            this.product = product;
            this.q = q;
        }
        public Product Product()
        {
            return product;
        }
        public int Quantity()
        {
            return q;
        }
    }
}
