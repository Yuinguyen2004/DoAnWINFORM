using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL
{
    public class ProductDAL
    {
        private Cafe_Management db = new Cafe_Management();

        public List<Product> GetAllProducts()
        {
            return db.Products.Include("Product").ToList();
        }

        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = db.Products.Find(product.ProductID);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.Price = product.Price;
                existingProduct.CategoryID = product.CategoryID;
                existingProduct.Description = product.Description;
                existingProduct.Images = product.Images;
                db.SaveChanges();
            }
        }

        public void DeleteProduct(string productID)
        {
            var product = db.Products.Find(productID);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }
    }

}
