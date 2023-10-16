using Ecom.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Data.Cofiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(30);
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");

            //builder.HasOne(x => x.Cateogry).WithMany(x => x.Products).HasForeignKey(x => x.CateogryId);

            //Seed
            builder.HasData(
                new Product { Id=1,Name="Prod 1",Description="DesP1",Price=2000,CateogryId=1},
                new Product { Id = 2, Name = "Prod 2", Description = "DesP2", Price = 3000, CateogryId = 2 },
                new Product { Id = 3, Name = "Prod 3", Description = "DesP3", Price = 4000, CateogryId = 3 },
                new Product { Id = 4, Name = "Prod 4", Description = "DesP4", Price = 5000, CateogryId = 1 }

                );
        }
    }
}
