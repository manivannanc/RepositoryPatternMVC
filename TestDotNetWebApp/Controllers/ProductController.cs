using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using TestDotNetWebApp.Models;
using TestDotNetWebApp.DAL;
using PagedList;

namespace TestDotNetWebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;

     
      public ProductController(IProductRepository productRepository)
      {
         this.productRepository = productRepository;
      }

        //
        // GET: /Product/

      public ActionResult Index(int id)
      {
          Product Product = productRepository.GetProductByID(id);
          return View(Product);
      }
       
        protected override void Dispose(bool disposing)
        {
            productRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}