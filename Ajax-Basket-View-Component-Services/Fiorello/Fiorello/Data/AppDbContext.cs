using Fiorello.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Data
{
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    public DbSet<Setting> Settings { get; set; }
    protected  override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Header>().HasQueryFilter(m => !m.IsDeleted);
        modelBuilder.Entity<Footer>().HasQueryFilter( m => !m.IsDeleted);
        modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.IsDeleted);
        modelBuilder.Entity<Setting>().HasQueryFilter(m => !m.IsDeleted);
        modelBuilder.Entity<Header>().HasData(
            new Header
            {
                Id = 1,
                IsDeleted = false,
                Image = "logo.png"
            }
            );
        modelBuilder.Entity<Blog>().HasData(
            new Blog
            {
                Id = 1,
                IsDeleted = false,
                Title = "Blog1",
                Desc = "Desc1",
                Image = "blog-feature-img-1.jpg",
                Date = DateTime.Now
            },
                new Blog
                {
                    Id = 2,
                    IsDeleted = false,
                    Title = "Blog2",
                    Desc = "Desc2",
                    Image = "blog-feature-img-3.jpg",
                    Date = DateTime.Now
                },
                new Blog
                {
                    Id = 3,
                    IsDeleted = false,
                    Title = "Blog3",
                    Desc = "Desc3",
                    Image = "blog-feature-img-4.jpg",
                    Date = DateTime.Now
                }

            );
        modelBuilder.Entity<Setting>().HasData(
            new Setting
            {
                Id = 1,
                IsDeleted = false,
                Key = "HeaderLogo",
                Value = "logo.png"
            },
                new Setting
                {
                    Id = 2,
                    IsDeleted = false,
                    Key = "Phone",
                    Value = "6516516516"
                },
                new Setting
                {
                    Id = 3,
                    IsDeleted = false,
                    Key = "ProductTake",
                    Value = "4"
                },
                new Setting
                {
                    Id = 4,
                    IsDeleted = false,
                    Key = "Email",
                    Value = "Azerrh@code.edu.az"
                }

            );
    }
}

}
