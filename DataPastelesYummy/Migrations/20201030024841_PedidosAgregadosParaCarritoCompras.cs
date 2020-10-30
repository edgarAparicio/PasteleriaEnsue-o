using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EdgarAparicio.PastelesYummy.Data.Migrations
{
    public partial class PedidosAgregadosParaCarritoCompras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(maxLength: 50, nullable: false),
                    Direccion1 = table.Column<string>(maxLength: 100, nullable: false),
                    Direccion2 = table.Column<string>(nullable: true),
                    CodigoPostal = table.Column<string>(maxLength: 10, nullable: false),
                    Ciudad = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<string>(maxLength: 50, nullable: false),
                    Pais = table.Column<string>(maxLength: 50, nullable: false),
                    NumeroCelular = table.Column<string>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PedidoTotal = table.Column<decimal>(nullable: false),
                    PedidoEntregado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                });

            migrationBuilder.CreateTable(
                name: "DetallePedidos",
                columns: table => new
                {
                    DetallePedidoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(nullable: false),
                    PastelId = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedidos", x => x.DetallePedidoId);
                    table.ForeignKey(
                        name: "FK_DetallePedidos_Pasteles_PastelId",
                        column: x => x.PastelId,
                        principalTable: "Pasteles",
                        principalColumn: "PastelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallePedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_PastelId",
                table: "DetallePedidos",
                column: "PastelId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_PedidoId",
                table: "DetallePedidos",
                column: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePedidos");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
