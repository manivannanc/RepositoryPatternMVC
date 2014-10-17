using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDotNetWebApp.DAL;

namespace Productlist_sample.Controllers
{
    public class HomeController : Controller
    {
        private ICatalogRepository categoryRepository;

        public HomeController(ICatalogRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public ActionResult Index()
        {
            return View(categoryRepository.GetCategories().ToList());
        }       
    }
}