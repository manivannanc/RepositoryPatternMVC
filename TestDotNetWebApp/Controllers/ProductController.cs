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

      public ActionResult Index()
      {
          return View(productRepository.GetProducts().ToList());
      }
        // GET: /Product/Details/5

        public ViewResult Details(int id)
        {
            Product Product = productRepository.GetProductByID(id);
            return View(Product);
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Product/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
           [Bind(Include = "Title, FirstMidName, EnrollmentDate")]
           Product Product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productRepository.InsertProduct(Product);
                    productRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(Product);
        }

        //
        // GET: /Product/Edit/5

        public ActionResult Edit(int id)
        {
            Product Product = productRepository.GetProductByID(id);
            return View(Product);
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
           [Bind(Include = "Title, Description")]
         Product Product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productRepository.UpdateProduct(Product);
                    productRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(Product);
        }

        //
        // GET: /Product/Delete/5

        public ActionResult Delete(bool? saveChangesError = false, int id = 0)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Product Product = productRepository.GetProductByID(id);
            return View(Product);
        }

        //
        // POST: /Product/Delete/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
             
                productRepository.DeleteProduct(id);
                productRepository.Save();
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            productRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}