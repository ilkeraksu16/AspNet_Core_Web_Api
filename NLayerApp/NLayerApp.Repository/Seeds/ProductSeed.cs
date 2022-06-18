using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id=1,
                CategoryId=1,
                Name="Kalem 1",
                Stock=20,
                Price=100,
                CreatedDate=DateTime.Now
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Kalem 2",
                Stock = 20,
                Price = 200,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Kalem 3",
                Stock = 20,
                Price = 300,
                CreatedDate = DateTime.Now


            },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "Kalem 1",
                Stock = 20,
                Price = 400,
                CreatedDate = DateTime.Now


            });
        }
    }
}
