using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCore.Migrations
{
    public partial class Factura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADM_Detalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdFactura = table.Column<int>(type: "INT", nullable: false),
                    IdProducto = table.Column<int>(type: "INT", nullable: false),
                    Precio = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Cantidad = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADM_Detalle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ADM_Factura",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(type: "INT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Importe = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Nit = table.Column<int>(type: "INT", nullable: false),
                    Razon_Social = table.Column<string>(type: "VARCHAR(MAX)", nullable: true),
                    Codigo_Control = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Modo_Pago = table.Column<int>(type: "INT", nullable: false),
                    Codigo_Tarjeta = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADM_Factura", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ADM_Producto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Costo = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Precio = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Stock = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADM_Producto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADM_Detalle");

            migrationBuilder.DropTable(
                name: "ADM_Factura");

            migrationBuilder.DropTable(
                name: "ADM_Producto");
        }
    }
}
