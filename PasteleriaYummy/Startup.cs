using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.PastelesYummy.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PasteleriaYummy
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbContextPasteleriaYummy>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //Como ya se tiene una bd real ahora se agregan las clases que afectan a la BD
            //services.AddScoped<IPastel, SimuladorRepositorioPastel>();
            //services.AddScoped<ICategoria, SimuladorRepositorioCategoria>();
            services.AddScoped<IPastel, DataPastel>();
            services.AddScoped<ICategoria, DataCategoria>();
            services.AddScoped<DataCarritoCompras>(sp => DataCarritoCompras.MostrarCarrito(sp));
            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute( 
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
            });
        }
    }
}
