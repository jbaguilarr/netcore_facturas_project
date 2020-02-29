using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Configuration
{
    public abstract class EntityConfiguration<T> : IEntityTypeConfiguration<T>  
        where T : Entity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(m => m.DateCreated).HasColumnType("sysdatetime()").HasDefaultValueSql("sysdatetime()");
            builder.Property(p => p.DateUpdated).HasColumnType("sysdatetime()");
        }
    }
}
