﻿using FluentAPI_Mapping.Entities.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI_Mapping.Entities.EfCodeFirstMappings.Abstract
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired(true);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.DeleteDate).IsRequired(false);
            //builder.Property(x => x.Status).IsRequired(true);
        }
    }
}
