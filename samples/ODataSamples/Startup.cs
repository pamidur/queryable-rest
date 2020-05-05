﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ODataSamples.Contexts;

namespace ODataSamples
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.                
                AddDbContext<DataContext>(o => o.UseInMemoryDatabase("TestDb"));

            services
               .AddQRest()
               .UseODataSemantics()
               .UseStandardCompiler(cpl =>
               {
                   cpl.UseCompilerCache = false;
               });

            services.AddMvc();

            var resolver = services.BuildServiceProvider();
            var ctx = resolver.GetService<DataContext>();
            //ctx.Database.Migrate();
            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
