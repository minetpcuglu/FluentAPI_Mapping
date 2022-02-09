using FluentAPI_Mapping.Entities.Concrete;
using FluentAPI_Mapping.Entities.EfCodeFirstMappings.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI_Mapping.Entities.EfCodeFirstMappings.Concrete
{
    public class ProductMap : BaseMap<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(10).IsRequired(true);
            builder.Property(x => x.UnitPrice).HasMaxLength(10).IsRequired(true);
            builder.Property(x => x.UnitInStock).HasMaxLength(10).IsRequired(false);

          builder.HasMany(x=> x.Orders)
                .WithOne(x=> x.Product)
                .HasForeignKey(x => x.ProductID).OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
