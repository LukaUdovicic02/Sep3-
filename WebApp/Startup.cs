using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.InMemory;
using Domain;
using Domain.Interfaces;
using Domain.Products;
using Domain.Products.Interfaces;
using Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApp.Data;

namespace WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();


            //  data storage dependency injection
            services.AddScoped<ICategoryRepo, CategoryInMemoRepo>();
            services.AddScoped<IProductRepo, ProductInMemoRepo>();
            
            //  domain and repos dependency injection
            services.AddTransient<IViewCategoriesDomain, ViewCategoriesDomain>();
            services.AddTransient<IAddCategoryDomain, AddCategoryDomain>();
            services.AddTransient<IEditCategoryDomain , EditCategoryDomain>();
            services.AddTransient<IGetCategoryByIdDomain, GetCategoryByIdDomain>();
            services.AddTransient<IDeleteCategoryDomain, DeleteCategoryDomain>();
            services.AddTransient<IViewProductDomain, ViewProductDomain>();
            services.AddTransient<IAddProductsDomain, AddProductsesDomain>();
            services.AddTransient<IEditCategoryDomain, EditCategoryDomain>();
            services.AddTransient<IGetProductByIdDomain, GetProductByIdDomain>();
            services.AddTransient<IDeleteProductDomain, DeleteProductDomain>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
