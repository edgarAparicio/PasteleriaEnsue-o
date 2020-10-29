using Microsoft.EntityFrameworkCore.Migrations;

namespace EdgarAparicio.PastelesYummy.Data.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaNombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Pasteles",
                columns: table => new
                {
                    PastelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    DescripcionCorta = table.Column<string>(nullable: true),
                    DescripcionLarga = table.Column<string>(nullable: true),
                    InformacionAllergy = table.Column<string>(nullable: true),
                    Precio = table.Column<decimal>(nullable: false),
                    ImagenUrl = table.Column<string>(nullable: true),
                    ImagenThumbnailUrl = table.Column<string>(nullable: true),
                    PastelSemana = table.Column<bool>(nullable: false),
                    EnStock = table.Column<bool>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasteles", x => x.PastelId);
                    table.ForeignKey(
                        name: "FK_Pasteles_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pasteles_CategoriaId",
                table: "Pasteles",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pasteles");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
