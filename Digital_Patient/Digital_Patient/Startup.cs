using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Patient.Data;
using Digital_Patient.Models.SimpleShopWebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Digital_Patient.Hubs;
using Digital_Patient.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;


namespace Digital_Patient
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


            services.AddRazorPages();

            services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });






            services.AddDbContext<ApplicationDbContext>(options =>
   options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")),
   contextLifetime: ServiceLifetime.Transient,
   optionsLifetime: ServiceLifetime.Singleton);



            //services.AddDbContextFactory<ApplicationDbContext>();


            services.AddDbContextFactory<ApplicationDbContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            //        services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));




            services.AddDatabaseDeveloperPageExceptionFilter();




            services.AddIdentity<IdentityUser, IdentityRole>()
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddDefaultUI()
           .AddDefaultTokenProviders();

            ////


            services.AddHttpClient();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .SetIsOriginAllowed((host) => true)
                        .AllowAnyHeader());
            });


         



            /////
            services.AddAuthorizationCore();


            services.AddControllersWithViews();
            ////

            services.AddScoped<UserManager<IdentityUser>>();

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();

            services.AddScoped<CookiesProvider>();

            services.AddSignalR();







        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ApplicationDbContext context)
        {




            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapHub<TaskHub>("/taskhub");
            });

            /////

            app.UseCors("CorsPolicy");

            //////

            SeedData data = new SeedData(context);
            data.EnsurePopulated();

        }
    }
}
