
using Microsoft.EntityFrameworkCore;
using WebApplicationmvc.Models.Domain;

namespace WebApplicationmvc.Data
{
    public class BloggyDbContext : DbContext //inheriting property of DbContext class to BloggyDbContext, which is a part of EntityFrameworkCore
    {
        public BloggyDbContext(DbContextOptions options) : base(options) //constructor of bloggydbcontext
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; } //using this property table will be created for blogpost in entityframework
        public DbSet<Tag> Tags { get; set; }

    }
}
