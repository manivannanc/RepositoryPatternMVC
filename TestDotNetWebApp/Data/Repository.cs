using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDotNetWebApp.Models;

namespace TestDotNetWebApp.Data
{
    public partial class Repository
    {
        private ICollection<Product> _data;

        public Repository()
        {
            this._data.Add(
                new Product()
                {
                    Id = 1,
                    Sku = "53X86/5202",
                    Title = "Aquabumps Makaha Ring Traingle Top",
                    Description = "This stunning and limited edition Aquabumps triangle top is made from recycled polyester and lycra, making it the perfect choice.",
                    ImageUrl = "https://images.truealliance.com.au/brand/speedo/product/53X86_5202_1_xlarge.jpg",
                    ThumbnailUrl = "https://images.truealliance.com.au/brand/speedo/product/53X86_5202_1_medium150.jpg"
                });
            this._data.Add(
                new Product()
                {
                    Id = 2,
                    Sku = "53X46/5202",
                    Title = "Aquabumps Makaha Soft Halter Tankini",
                    Description = "This stunning limited edition Aquabumps soft halter tankini is made from recycled polyester and lycra, making it the perfect choice.",
                    ImageUrl = "https://images.truealliance.com.au/brand/speedo/product/53X46_5202_1_xlarge.jpg",
                    ThumbnailUrl = "https://images.truealliance.com.au/brand/speedo/product/53X46_5202_1_medium150.jpg"
                });
            this._data.Add(
                new Product()
                {
                    Id = 3,
                    Sku = "53W97/5196",
                    Title = "Ulysses Ruffle Top",
                    Description = "This stunning and colourful ruffle top made from recycled polyester and lycra is the perfect choice for a B/C cup.",
                    ImageUrl = "https://images.truealliance.com.au/brand/speedo/product/53W97_5196_1_xlarge.jpg",
                    ThumbnailUrl = "https://images.truealliance.com.au/brand/speedo/product/53W97_5196_1_medium150.jpg"
                });
            this._data.Add(
                new Product()
                {
                    Id = 4,
                    Sku = "35X35/5209",
                    Title = "80'S STRIPE WATERSHORT",
                    Description = "This 37cm short is the perfect multi purpose short. The quick drying fabric makes them ideal for leisure, swimming and sport as shorts stay light and easy to move in.",
                    ImageUrl = "https://images.truealliance.com.au/brand/speedo/product/35X35_5209_1_xlarge.jpg",
                    ThumbnailUrl = "https://images.truealliance.com.au/brand/speedo/product/35X35_5209_1_medium150.jpg"
                });
            this._data.Add(
                new Product()
                {
                    Id = 5,
                    Sku = "33W02/5036",
                    Title = "ZIGGY STRIPE JAMMER",
                    Description = "A Speedo favourite, this jammer is great for swimming lessons and just having fun. Made from Endurance, an exclusive Speedo fabric designed to last longer, it is 100% chlorine-resistant to prevent snagging and fading 20 times longer than any other swim fabric. This fabric also features 4 way stretch technology for added softness and comfort.",
                    ImageUrl = "https://images.truealliance.com.au/brand/speedo/product/33W02_5036_1_xlarge.jpg",
                    ThumbnailUrl = "https://images.truealliance.com.au/brand/speedo/product/33W02_5036_1_medium150.jpg"
                });

        }
    }
}