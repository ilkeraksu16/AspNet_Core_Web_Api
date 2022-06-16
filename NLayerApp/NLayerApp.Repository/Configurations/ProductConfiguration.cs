using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Stock).IsRequired();
            // ################.## -> 16+2 = 18
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.ToTable("Products");

            /*
             Bir product'ın bir Category'si olur. (HasOne(x => x.Category))
            Bir Category'nin biden fazla Products'ı olur. (.WithMany(X => X.Products))
            Products tablomuzda foreignkey alanımız CategoryID 'dir. (.HasForeignKey(x => x.CategoryId))
             */
            builder.HasOne(x => x.Category)
                .WithMany(X => X.Products)
                .HasForeignKey(x => x.CategoryId);

        }
    }
}
