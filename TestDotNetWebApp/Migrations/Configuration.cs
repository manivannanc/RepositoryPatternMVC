namespace TestDotNetWebApp.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestDotNetWebApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestDotNetWebApp.DAL.ProductCatalogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestDotNetWebApp.DAL.ProductCatalogContext context)
        {
            Category c1 = new Category()
            {
                Name = "Mens Dresses",
                OrderIndex = 101,
                Products = new List<Product>
                {
                             new Product()
                             {
                              Sku = "53X86/5202",
                              Title = "Aquabumps Makaha Ring Traingle Top",
                              Description = "This stunning and limited edition Aquabumps triangle top is made from recycled polyester and lycra, making it the perfect choice.",
                              ImageUrl = "https://images.truealliance.com.au/brand/speedo/product/53X86_5202_1_xlarge.jpg",
                              ThumbnailUrl = "https://images.truealliance.com.au/brand/speedo/product/53X46_5202_1_medium150.jpg"
                             }
                            

                  },
                SubCategories = new List<Category>
                {
                    new Category()
                    {
                         Name = "Mens Formal Shirt",
                         OrderIndex = 102,
                         Products = new List<Product>
                        {
                             new Product()
                             {
                                Sku = "53X46/5202",
                                Title = "Aquabumps Makaha Soft Halter Tankini",
                                Description = "This stunning limited edition Aquabumps soft halter tankini is made from recycled polyester and lycra, making it the perfect choice.",
                                ImageUrl = "https://images.truealliance.com.au/brand/speedo/product/53X46_5202_1_xlarge.jpg",
                                ThumbnailUrl = "https://images.truealliance.com.au/brand/speedo/product/53X46_5202_1_medium150.jpg"
                             }
                         
                        }
                    },
         
                    new Category()
                     {
                          Name = "Mens Casual Shirt ",
                          OrderIndex = 103,
                           Products = new List<Product>
                        {
                             new Product()
                             {
                     Sku = "53W97/5196",
                    Title = "Ulysses Ruffle Top",
                    Description = "This stunning and colourful ruffle top made from recycled polyester and lycra is the perfect choice for a B/C cup.",
                    ImageUrl = "https://images.truealliance.com.au/brand/speedo/product/53W97_5196_1_xlarge.jpg",
                    ThumbnailUrl = "https://images.truealliance.com.au/brand/speedo/product/53W97_5196_1_medium150.jpg"
                             }
                        }
                   }
            }
            };
            Category c2 = new Category()
            {
                Name = "Womens Dresses",
                OrderIndex = 104,
                Products = new List<Product>
                        {
                             new Product()
                             {
                    Sku = "35X35/5209",
                    Title = "80'S STRIPE WATERSHORT",
                    Description = "This 37cm short is the perfect multi purpose short. The quick drying fabric makes them ideal for leisure, swimming and sport as shorts stay light and easy to move in.",
                    ImageUrl = "https://images.truealliance.com.au/brand/speedo/product/35X35_5209_1_xlarge.jpg",
                    ThumbnailUrl = "https://images.truealliance.com.au/brand/speedo/product/35X35_5209_1_medium150.jpg"
                }},
                SubCategories = new List<Category>
                {
                    new Category()
                    {
                        Name = "Womens Casual Shirt",
                        OrderIndex = 105,
                        Products = new List<Product>
                        {
                             new Product()
                             {
                    Sku = "33W02/5036",
                    Title = "ZIGGY STRIPE JAMMER",
                    Description = "A Speedo favourite, this jammer is great for swimming lessons and just having fun. Made from Endurance, an exclusive Speedo fabric designed to last longer, it is 100% chlorine-resistant to prevent snagging and fading 20 times longer than any other swim fabric. This fabric also features 4 way stretch technology for added softness and comfort.",
                    ImageUrl = "https://images.truealliance.com.au/brand/speedo/product/33W02_5036_1_xlarge.jpg",
                    ThumbnailUrl = "https://images.truealliance.com.au/brand/speedo/product/33W02_5036_1_medium150.jpg"
                }}
                    }
                }
            };
            context.Categories.Add(c1);
            context.Categories.Add(c2);
            context.SaveChanges();
        }
    }
}
