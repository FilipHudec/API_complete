using api_complete.Models;
using Microsoft.EntityFrameworkCore;

namespace api_complete.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
            // fluent
            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    ArticleId = 1,
                    Title = "First Article",
                    Content = "This is the content of the first article"
                },
                new Article
                {
                    ArticleId = 2,
                    Title = "Second Article",
                    Content = "This is the content of the second article"
                }
            );
            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    CommentId = 1,
                    Text = "This is the first comment",
                    ArticleId = 1
                },
                new Comment
                {
                    CommentId = 2,
                    Text = "This is the second comment",
                    ArticleId = 1
                },
                new Comment
                {
                    CommentId = 3,
                    Text = "This is the third comment",
                    ArticleId = 2
                }

                );
        }
    }
}
