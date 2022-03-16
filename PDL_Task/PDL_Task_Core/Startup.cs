using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PDL_Task_Core.Models;
using PDL_Task_Core.Repositories;
using PDL_Task_Core.Repositories.Implementaion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDL_Task_Core
{
    public class Startup
    {
        public Startup(IConfiguration Config) { this.Config = Config; }
        public IConfiguration Config { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PDL_TaskContext>(op => op.UseSqlServer(this.Config.GetConnectionString("sqlserver")));
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
