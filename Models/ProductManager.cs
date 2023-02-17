using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models
{
    public class ProductManager : IProductManager
    {
        List<Product> products = new List<Product>();
        private int _autoProductId = 1;
        public ProductManager()
        {
            Add(new Product { Name = "Pen1", Type = "Stationary", Description = "Pen from Lexi Company", Price = 100 });
            Add(new Product { Name = "Pen2", Type = "Stationary", Description = "Pen from Lexi Company", Price = 102 });
            Add(new Product { Name = "Pen3", Type = "Stationary", Description = "Pen from Lexi Company", Price = 103});
            Add(new Product { Name = "Pen4", Type = "Stationary", Description = "Pen from Lexi Company", Price = 101 });
            Add(new Product { Name = "Pen5", Type = "Stationary", Description = "Pen from Lexi Company", Price = 106 });

        }
        public List<Product> GetAll()
        {
            return products;
        }
        public Product Get(int id)
        {
            var product = products.Find(p => p.Id == id);
            return product;
        }


        public Product Add(Product product)
        {
           if(product == null)
            {
                throw new ArgumentNullException("product");
            }
            product.Id = _autoProductId++;
            products.Add(product);
            return product;
        }

        public void Remove(int id)
        {
            products.RemoveAll(p=> p.Id == id);

        }

        public bool Update(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            int Index = products.FindIndex(p => p.Id == product.Id);
            if (Index == -1)
            {
                return false;
            }
            products.RemoveAt(Index);
            products.Add(product);
            return true;
        }
    }
}