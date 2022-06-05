using Library.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Library.DAL.Impl
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Authors_Book> Authors_Book { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Readers_Card> Readers_Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().ToTable("Authors");
            modelBuilder.Entity<Authors_Book>().ToTable("Author's Books");
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Chapter>().ToTable("Chapters");
            modelBuilder.Entity<Reader>().ToTable("Readers");
            modelBuilder.Entity<Readers_Card>().ToTable("Reader's Cards");
            //Storage.SeedDataBase(modelBuilder);
        }
    }
}
