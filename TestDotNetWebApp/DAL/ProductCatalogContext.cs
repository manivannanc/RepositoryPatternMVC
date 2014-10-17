
using TestDotNetWebApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TestDotNetWebApp.DAL
{
    public class ProductCatalogContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Category>()
             .Property(c => c.ParentID).IsOptional();
            modelBuilder.Entity<Category>()
             .HasMany(c => c.SubCategories).WithOptional(c => c.Parent).HasForeignKey(c => c.ParentID);

            modelBuilder.Entity<Category>()
             .HasMany(c => c.Products).WithMany(i => i.Categories)
             .Map(t => t.MapLeftKey("CategoryID")
                 .MapRightKey("ProductID")
                 .ToTable("CategoryProduct"));
        }
    }
}