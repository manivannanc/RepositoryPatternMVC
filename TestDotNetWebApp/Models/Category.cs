using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestDotNetWebApp.Models
{
    public partial class Category : BaseEntity
    {
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public int? ParentID { get; set; }
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; }
    }
}