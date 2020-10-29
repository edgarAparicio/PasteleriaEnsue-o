using Microsoft.EntityFrameworkCore.Migrations;

namespace EdgarAparicio.PastelesYummy.Data.Migrations
{
    public partial class DatosAgregados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "CategoriaNombre", "Descripcion" },
                values: new object[] { 1, "Pastel de Frutas", null });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "CategoriaNombre", "Descripcion" },
                values: new object[] { 2, "Pastel de Quesos", null });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "CategoriaNombre", "Descripcion" },
                values: new object[] { 3, "Pastel de Temporada", null });

            migrationBuilder.InsertData(
                table: "Pasteles",
                columns: new[] { "PastelId", "CategoriaId", "DescripcionCorta", "DescripcionLarga", "EnStock", "ImagenThumbnailUrl", "ImagenUrl", "InformacionAllergy", "Nombre", "PastelSemana", "Precio" },
                values: new object[,]
                {
                    { 1, 1, "¡Nuestras famosos pasteles de manzana!", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", "", "Pastel de Manzana", true, 129.5m },
                    { 4, 1, "Un clasico de verano!", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", "", "Pastel de Cerezas", false, 159.5m },
                    { 7, 1, "Dulce como un Durazno", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", "", "Pastel de durazno", false, 159.5m },
                    { 9, 1, "Increible, demasiado dulce", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", "", "Pastel de Riubarbo", true, 159.5m },
                    { 10, 1, "Nuestro delicioso pastel de fresa", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", "", "Pastel de Fresa", false, 159.5m },
                    { 2, 2, "¡Te encantará!", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", "", "Pastel de Queso con Arandanos", false, 189.5m },
                    { 3, 2, "Pastel de queso simple. Duro Placer!", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", "", "Pastel de Queso", false, 189.5m },
                    { 11, 2, "Te encantara", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", "", "Pastel de Fresas con Queso", false, 189.5m },
                    { 5, 3, "Felices vacaciones con este pastel", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", "", "Pastel de manzna de navidad", false, 139.5m },
                    { 6, 3, "Una navidad favorita", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", "", "Pastel de arandano", false, 179.5m },
                    { 8, 3, "Nuestro hallowen favorito", "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", "", "Pastel de calabaza", true, 129.5m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pasteles",
                keyColumn: "PastelId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3);
        }
    }
}
