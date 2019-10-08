using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PizzaShop.Core.AppServices;
using PizzaShop.Core.AppServices.Implementation;
using PizzaShop.Core.DomainServices;
using PizzaShop.Infrastructure;
using PizzaShop.Infrastructure.Repositories;

namespace PizzaShop.UI.RestAPI
{
    public class Startup
    {
        //test
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Environment = env;
        }

        public IConfiguration Configuration { get; }

        public IHostingEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddScoped<IFastFoodRepository, FastFoodRepository>();
            services.AddScoped<IFastFoodService, FastFoodService>();

            services.AddScoped<IPizzaRepository, PizzaRepository>();
            services.AddScoped<IPizzaService, PizzaService>();

            services.AddScoped<IDrinkRepository, DrinkRepository>();
            services.AddScoped<IDrinkService, DrinkService>();

            if (Environment.IsDevelopment())
            {
                services.AddDbContext<PizzaShopContext>(
                    opt => opt.UseSqlite("Data Source=PizzaShopSQLite.db")
                    );
            }

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<PizzaShopContext>();
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();
                    DbInitializer.Seed(context);
                }
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
