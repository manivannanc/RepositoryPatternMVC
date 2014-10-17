using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestDotNetWebApp.Models;

namespace TestDotNetWebApp.DAL
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        private ProductCatalogContext context;

        public ProductRepository(ProductCatalogContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public Product GetProductByID(int id)
        {
            return context.Products.Find(id);
        }

        public void InsertProduct(Product Product)
        {
            context.Products.Add(Product);
        }

        public void DeleteProduct(int ProductID)
        {
            Product Product = context.Products.Find(ProductID);
            context.Products.Remove(Product);
        }

        public void UpdateProduct(Product Product)
        {
            context.Entry(Product).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
    
