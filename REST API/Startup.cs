using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Bl.Abstract;
using Library.Bl.Impl;
using Library.DAL.Abstract;
using Library.DAL.Impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace REST_API
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
            services.AddControllers();
            services.AddDbContext<LibraryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => { b.MigrationsAssembly("WebApplication1"); b.EnableRetryOnFailure(); }));
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IAuthors_BookRepository, Authors_BookRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddTransient<IChapterRepository, ChapterRepository>();
            services.AddTransient<IReaderRepository, ReaderRepository>();
            services.AddTransient<IReaders_CardRepository, Readers_CardRepository>();

            services.AddScoped<IAuthorService, AuthorService>();
            services.AddTransient<IAuthors_BookService, Authors_BookService>();
            services.AddScoped<IBookService, BookService>();
            services.AddTransient<IChapterService, ChapterService>();
            services.AddScoped<IReaderService, ReaderService>();
            services.AddTransient<IReaders_CardService, Readers_CardService>();
            services.AddTransient<ILibraryService, LibraryService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
