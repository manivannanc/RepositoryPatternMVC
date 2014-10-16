using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDotNetWebApp.Models
{
    public partial class Product : BaseEntity
    {
        public string Sku { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}