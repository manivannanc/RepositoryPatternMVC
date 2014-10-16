using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDotNetWebApp.Models
{
    public class ProductCategory : BaseEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }
    }
}