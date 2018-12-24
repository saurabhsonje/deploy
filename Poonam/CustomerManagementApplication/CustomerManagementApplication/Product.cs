using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApplication
{
    class Product
    {
        public string name { set; get; }
        public double price { set; get; }
        public Product()
        {

        }
     public Product(string name,double price)
        {
            this.name = name;
            this.price = price;
        }
        public List<Product> getAllProduct()
        {
            List<Product> product = new List<Product>();
            product.Add(new Product("biscuits", 12));
            product.Add(new Product("pen", 10));
            product.Add(new Product("eraser", 5));
            return product;
        }
    }

}
