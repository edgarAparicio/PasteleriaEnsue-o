using Microsoft.EntityFrameworkCore.Migrations;

namespace EdgarAparicio.PastelesYummy.Data.Migrations
{
    public partial class CarritoComprasAgregado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticulosCarritoCompras",
                columns: table => new
                {
                    ArticuloCarritoComprasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PastelId = table.Column<int>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    CarritoComprasId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticulosCarritoCompras", x => x.ArticuloCarritoComprasId);
                    table.ForeignKey(
                        name: "FK_ArticulosCarritoCompras_Pasteles_PastelId",
                        column: x => x.PastelId,
                        principalTable: "Pasteles",
                        principalColumn: "PastelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticulosCarritoCompras_PastelId",
                table: "ArticulosCarritoCompras",
                column: "PastelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticulosCarritoCompras");
        }
    }
}
