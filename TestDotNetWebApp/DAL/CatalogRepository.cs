using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestDotNetWebApp.Models;

namespace TestDotNetWebApp.DAL
{
    public class CatalogRepository : ICatalogRepository, IDisposable
    {
        private ProductCatalogContext context;

        public CatalogRepository(ProductCatalogContext context)
        {
            this.context = context;
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public Category GetCategoryByID(int id)
        {
            return context.Categories.Find(id);
        }

        public void InsertCategory(Category Category)
        {
            context.Categories.Add(Category);
        }

        public void DeleteCategory(int CategoryID)
        {
            Category Category = context.Categories.Find(CategoryID);
            context.Categories.Remove(Category);
        }

        public void UpdateCategory(Category Category)
        {
            context.Entry(Category).State = EntityState.Modified;
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
    
