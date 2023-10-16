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
    public class CateogryConfiguration : IEntityTypeConfiguration<Cateogry>
    {
        public void Configure(EntityTypeBuilder<Cateogry> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(30);

            //Seed
            builder.HasData(
                new Cateogry { Id=1,Name="Cateogry one",Description="Des1"},
                new Cateogry { Id = 2, Name = "Cateogry two", Description = "Des2" },
                new Cateogry { Id = 3, Name = "Cateogry three", Description = "Des3" }

                );
        }
    }
}
