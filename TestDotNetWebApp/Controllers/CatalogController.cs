using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestDotNetWebApp.DAL;
using TestDotNetWebApp.Models;

namespace TestDotNetWebApp.Controllers
{
    public class CatalogController : Controller
    {
        private ICatalogRepository categoryRepository;

        public CatalogController(ICatalogRepository categoryRepository)
      {
         this.categoryRepository = categoryRepository;
      }

        // GET: Category
        public ActionResult Index(int id)
        {            
            Category category = categoryRepository.GetCategoryByID(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

          
        protected override void Dispose(bool disposing)
        {
            categoryRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
