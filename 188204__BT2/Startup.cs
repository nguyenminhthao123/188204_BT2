using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace _188204__BT2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // code 400-500 thông báo lỗi ra màn hình 
            app.UseStatusCodePages(appError =>
            {
                appError.Run(async context =>
               {
                   var respone = context.Response;
                   var code = respone.StatusCode;
                   var content = $@"<html>
                                  <head>
                                        <meta charset='UTF-8'/>
                                        <title> Lỗi {code}</title>
                                  </head>
                                   <body>
                                        <p style='color:red;font-size:30px'>có lỗi xảy ra: {code} - {(HttpStatusCode)code}</p>
                                    </body>
                                </html>";
                   await respone.WriteAsync(content);
               });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "ProductDetail",
                   pattern: "san-pham/{id}",
                   defaults: new { controller = "Home", action = "Index", });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=DetailView}/{id?}");
            });
        }
    }
}
