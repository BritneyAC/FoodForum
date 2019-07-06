using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FoodForum.Models;
using System.Data.SqlClient;

namespace FoodForum{
    public class Startup{
        public Startup(IConfiguration configuration){
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services){
            services.AddDbContext<FoodForumContext>(options => options.UseSqlServer(Configuration["DBInfo:ConnectionString"]));
            services.AddSession();            
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env){
            if (env.IsDevelopment()){
                app.UseDeveloperExceptionPage();
            }
            
            app.UseSession();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
