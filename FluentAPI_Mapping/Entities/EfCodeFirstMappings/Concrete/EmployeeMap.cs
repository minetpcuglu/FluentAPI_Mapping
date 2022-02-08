﻿using FluentAPI_Mapping.Entities.Concrete;
using FluentAPI_Mapping.Entities.EfCodeFirstMappings.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI_Mapping.Entities.EfCodeFirstMappings.Concrete
{
    public class EmployeeMap:BaseMap<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(10).IsRequired(true);
            builder.Property(x => x.Surname).HasMaxLength(10).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired(false);
       
          

            builder.HasMany(x => x.Orders).WithOne(x => x.Employee).HasForeignKey(x => x.EmployeeID).OnDelete(DeleteBehavior.Restrict);
         
            //builder.HasOne(x => x.AppUser).WithMany(x => x.Tweets).HasForeignKey(x => x.AppUserId);


            base.Configure(builder);



          

         ;

        }
    }
}
