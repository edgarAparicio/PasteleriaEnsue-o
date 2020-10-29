using EdgarAparicio.PastelesYummy.Business.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Data
{
    public class DbContextPasteleriaYummy : DbContext
    {
        public DbContextPasteleriaYummy(DbContextOptions<DbContextPasteleriaYummy> options) : base(options)
        {

        }

        public DbSet<Pastel> Pasteles { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<ArticuloCarritoCompras> ArticulosCarritoCompras { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaId = 1, CategoriaNombre = "Pastel de Frutas" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaId = 2, CategoriaNombre = "Pastel de Quesos" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaId = 3, CategoriaNombre = "Pastel de Temporada" });

            //seed pies

            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 1,
                Nombre = "Pastel de Manzana",
                Precio = 129.5M,
                DescripcionCorta = "¡Nuestras famosos pasteles de manzana!",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 1,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                EnStock = true,
                PastelSemana = true,
                ImagenThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                InformacionAllergy = ""
            });

            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 2,
                Nombre = "Pastel de Queso con Arandanos",
                Precio = 189.5M,
                DescripcionCorta = "¡Te encantará!",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 2,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                EnStock = true,
                PastelSemana = false,
                ImagenThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                InformacionAllergy = ""
            });

            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 3,
                Nombre = "Pastel de Queso",
                Precio = 189.5M,
                DescripcionCorta = "Pastel de queso simple. Duro Placer!",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 2,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                EnStock = true,
                PastelSemana = false,
                ImagenThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                InformacionAllergy = ""
            });

            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 4,
                Nombre = "Pastel de Cerezas",
                Precio = 159.5M,
                DescripcionCorta = "Un clasico de verano!",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 1,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                EnStock = true,
                PastelSemana = false,
                ImagenThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                InformacionAllergy = ""
            });

            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 5,
                Nombre = "Pastel de manzna de navidad",
                Precio = 139.5M,
                DescripcionCorta = "Felices vacaciones con este pastel",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 3,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                EnStock = true,
                PastelSemana = false,
                ImagenThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                InformacionAllergy = ""
            });

            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 6,
                Nombre = "Pastel de arandano",
                Precio = 179.5M,
                DescripcionCorta = "Una navidad favorita",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 3,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                EnStock = true,
                PastelSemana = false,
                ImagenThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                InformacionAllergy = ""
            });

            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 7,
                Nombre = "Pastel de durazno",
                Precio = 159.5M,
                DescripcionCorta = "Dulce como un Durazno",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 1,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                EnStock = false,
                PastelSemana = false,
                ImagenThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                InformacionAllergy = ""
            });

            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 8,
                Nombre = "Pastel de calabaza",
                Precio = 129.5M,
                DescripcionCorta = "Nuestro hallowen favorito",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 3,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                EnStock = true,
                PastelSemana = true,
                ImagenThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                InformacionAllergy = ""
            });


            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 9,
                Nombre = "Pastel de Riubarbo",
                Precio = 159.5M,
                DescripcionCorta = "Increible, demasiado dulce",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 1,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                EnStock = true,
                PastelSemana = true,
                ImagenThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                InformacionAllergy = ""
            });

            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 10,
                Nombre = "Pastel de Fresa",
                Precio = 159.5M,
                DescripcionCorta = "Nuestro delicioso pastel de fresa",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 1,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                EnStock = true,
                PastelSemana = false,
                ImagenThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                InformacionAllergy = ""
            });

            modelBuilder.Entity<Pastel>().HasData(new Pastel
            {
                PastelId = 11,
                Nombre = "Pastel de Fresas con Queso",
                Precio = 189.5M,
                DescripcionCorta = "Te encantara",
                DescripcionLarga =
                    "Glaseado de tarta de queso con gelatina de zanahoria. Rollo dulce mazapán malvavisco toffee brownie brownie caramelo tootsie roll. Pastel de chocolate, pan de jengibre, tootsie, pastel de avena, pastel, barra de chocolate, galleta, dragée, brownie. Lollipop pastel de avena de garra de oso de pastel de algodón de azúcar. Tarta de postre con bastones de caramelo Dragée. Mazapán dragée gomitas piruletas azufaifa barra de chocolate bastones de caramelo. Glaseado de pan de jengibre chupa chups galleta de algodón de azúcar gomitas de bombón glaseado dulce. Pastel de chocolate danés de galleta de brownie de piruleta de gomitas. Tarta danesa de donut de chocolate con macarrones y galletas en polvo. Pastel de zanahoria croissant grageas gotas de limón regaliz gotas de limón galleta piruleta toffee. Pastel de zanahoria pastel de zanahoria regaliz azúcar ciruela topping pastel de bombones muffin azufaifa. Caramelos de tarta de oblea de pastelería gelatina garra de oso. Tarta de tarta de tiramisú con gotas de limón danés. Gomitas de bizcocho de brownie dragée.",
                CategoriaId = 2,
                ImagenUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                EnStock = false,
                PastelSemana = false,
                ImagenThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                InformacionAllergy = ""
            });
        }
    }
}
