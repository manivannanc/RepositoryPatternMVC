using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDotNetWebApp.Models;

namespace TestDotNetWebApp.DAL
{
    public interface ICatalogRepository : IDisposable
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryByID(int CategoryId);
        void InsertCategory(Category Category);
        void DeleteCategory(int CategoryID);
        void UpdateCategory(Category Category);
        void Save();
    }
}