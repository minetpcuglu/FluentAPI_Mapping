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
    public class OrderMap : BaseMap<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OrderDate).IsRequired(true);

            builder.HasOne(x => x.Product)
                           .WithMany(x => x.Orders)
                           .HasForeignKey(x => x.ProductID).OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
