using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FoodForum.Models;
using Microsoft.AspNetCore.HttpOverrides;
using System.Net;
using Microsoft.WindowsAzure.Storage;

namespace FoodForum
{
  public class Startup{
        public Startup(IConfiguration configuration){
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services){
            services.AddDbContext<FoodForumContext>(options => options.UseSqlServer(Configuration["DBInfo:ConnectionString"]));
            services.AddSession();            
            services.AddMvc();
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.KnownProxies.Add(IPAddress.Parse("10.0.0.100"));
            });
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env){
            if (env.IsDevelopment()){
                app.UseDeveloperExceptionPage();
            }
            
            app.UseSession();
            app.UseStaticFiles();
            app.UseMvc();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseAuthentication();
        }
    }
}
