using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDotNetWebApp.Models;

namespace TestDotNetWebApp.DAL
{
   public interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void InsertProduct(Product Product);
        void DeleteProduct(int ProductID);
        void UpdateProduct(Product Product);
        void Save();
    }

}
