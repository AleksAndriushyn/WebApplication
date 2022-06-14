using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using WebAuthorization.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Library.DAL.Impl;
using Library.DAL.Abstract;
using Library.Bl.Impl;
using Library.Bl.Abstract;
using Microsoft.AspNetCore.Mvc;
using Library.Entities;

namespace WebAuthorization
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddDbContext<LibraryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("JsonConnection"), b => { b.MigrationsAssembly("WebAuthorization"); b.EnableRetryOnFailure(); }));
            services.AddScoped<ILibraryService, LibraryService>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IAuthors_BookRepository, Authors_BookRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddTransient<IChapterRepository, ChapterRepository>();
            services.AddTransient<IReaderRepository, ReaderRepository>();
            services.AddTransient<IReaders_CardRepository, Readers_CardRepository>();

            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IRecommendedBookService, RecommendedBookService>();
            services.AddScoped<IReaderService, ReaderService>();
            services.AddTransient<IAuthors_BookService, Authors_BookService>();
            services.AddTransient<IChapterService, ChapterService>();
            services.AddTransient<IReaders_CardService, Readers_CardService>();
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
            });
        }
    }
}
