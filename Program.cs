using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using GBCTravel105.Data;
using GBCTravel105.Areas.BookingManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis;
using System.Configuration;
using Serilog;
namespace GBCTravel105
{
   
    public class Program
    {

        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<GBCTravel105Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("GBCTravel105Context") ?? throw new InvalidOperationException("Connection string 'GBCTravel105Context' not found.")));

            builder.Services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<GBCTravel105Context>().AddDefaultUI().AddDefaultTokenProviders();

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

            builder.Services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddSerilog();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            




            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthorization();
            app.MapRazorPages();
            app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Flights}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            using(var scope = app.Services.CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var roles = new[] { "Admin", "Member","Manager"};
                foreach(var role in roles) {
                    if (!await roleManager.RoleExistsAsync(role))
                        await roleManager.CreateAsync(new IdentityRole(role)); 
                }
            }

            using (var scope = app.Services.CreateScope())
            {
                var userManager = scope.ServiceProvider
                    .GetRequiredService<UserManager<IdentityUser>>();

                string email = "admin@admin.com";
                string password = "Admin1234,";
                if(await userManager.FindByEmailAsync(email) == null)
                {
                    var user = new IdentityUser();
                    user.Email = email;
                    user.UserName = email;
                   await userManager.CreateAsync (user,password);
                    await userManager.AddToRoleAsync(user, "Admin");
                }
                
            }
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // For Web API controllers
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });



            app.Run();

        }
    }
}
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.AspNetCore.Hosting;
//using GBCTravel105.Data;
//using GBCTravel105.Models;
//using System;

//namespace GBCTravel105
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);
//            builder.Services.AddDbContext<GBCTravel105Context>(options =>
//                options.UseSqlServer(builder.Configuration.GetConnectionString("GBCTravel105Context") ?? throw new InvalidOperationException("Connection string 'GBCTravel105Context' not found.")));

//           // builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
//            //builder.Services.AddScoped<Booked>(sp => Booked.GetBooked(sp));
//            //// Add services to the container.
//            //builder.Services.AddControllersWithViews();
//            //builder.Services.AddDistributedMemoryCache();
//            //builder.Services.AddSession(options =>
//            //{
//            //    options.Cookie.HttpOnly = true;
//            //    options.Cookie.IsEssential = true;
//            //   // options.IdleTimeout = TimeSpan.FromSeconds(10);
//            //});

//          //  builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

//            var app = builder.Build();

//            // Initialize seed data
//            //using (var scope = app.Services.CreateScope())
//            //{
//            //    var services = scope.ServiceProvider;
//            //    try
//            //    {
//            //        var context = services.GetRequiredService<GBCTravel105Context>();
//            //        SeedData.Initialize(services);
//            //    }
//            //    catch (Exception ex)
//            //    {
//            //        // Log the error
//            //        Console.WriteLine("An error occurred while seeding the database.");
//            //        Console.WriteLine(ex.Message);
//            //    }
//            //}

//            // Configure the HTTP request pipeline.
//            if (!app.Environment.IsDevelopment())
//            {
//                app.UseExceptionHandler("/Home/Error");
//                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                app.UseHsts();
//            }


//            app.UseHttpsRedirection();
//            app.UseStaticFiles();

//            app.UseRouting();

//            app.UseAuthorization();
//            app.UseSession();
//            app.MapControllerRoute(
//                name: "default",
//                pattern: "{controller=Home}/{action=Index}/{id?}");


//            app.Run();
//        }
//    }
//}

