﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCore.Model;

namespace NetCore.Migrations
{
    [DbContext(typeof(NetCoreContext))]
    partial class NetCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCore.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Direccion")
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("FechaNaciemiento")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Nombre")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Telefono")
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("ADM_Cliente");
                });

            modelBuilder.Entity("NetCore.Entities.Detalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("INT");

                    b.Property<int>("IdFactura")
                        .HasColumnType("INT");

                    b.Property<int>("IdProducto")
                        .HasColumnType("INT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("DECIMAL(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ADM_Detalle");
                });

            modelBuilder.Entity("NetCore.Entities.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo_Control")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("Codigo_Tarjeta")
                        .HasColumnType("INT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("DATETIME");

                    b.Property<int>("IdCliente")
                        .HasColumnType("INT");

                    b.Property<decimal>("Importe")
                        .HasColumnType("DECIMAL(18,2)");

                    b.Property<int>("Modo_Pago")
                        .HasColumnType("INT");

                    b.Property<int>("Nit")
                        .HasColumnType("INT");

                    b.Property<string>("Razon_Social")
                        .HasColumnType("VARCHAR(MAX)");

                    b.HasKey("Id");

                    b.ToTable("ADM_Factura");
                });

            modelBuilder.Entity("NetCore.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoMaterno");

                    b.Property<string>("ApellidoPaterno");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("ADM_Persona");
                });

            modelBuilder.Entity("NetCore.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Costo")
                        .HasColumnType("DECIMAL(18,2)");

                    b.Property<string>("Nombre")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("DECIMAL(18,2)");

                    b.Property<decimal>("Stock")
                        .HasColumnType("DECIMAL(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ADM_Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
