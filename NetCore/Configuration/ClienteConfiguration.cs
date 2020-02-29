using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Configuration
{
    public class ClienteConfiguration : EntityConfiguration<Cliente>
    {
      
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
           
            builder.OwnsOne(m => m.Direccion, a =>
            {
                a.Property(p => p.Barrio).HasMaxLength(100)
                    .HasColumnName("Barrio")
                    .HasDefaultValue("");
                a.Property(p => p.Calle).HasMaxLength(100)
                    .HasColumnName("Calle")
                    .HasDefaultValue("");
                a.Property(p => p.Numero)
                    .HasColumnName("Numero")
                    .HasDefaultValue(1);
            });

            base.Configure(builder);
        }
    }
}
