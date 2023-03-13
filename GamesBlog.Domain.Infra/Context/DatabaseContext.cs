using Microsoft.EntityFrameworkCore;
using GamesBlog.Domain.Entities;
using GamesBlog.Domain.Repositories.Contracts;

namespace GamesBlog.Domain.Infra.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Article> Articles { get; private set; }
        public DbSet<BlogPost> BlogPosts { get; private set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("articles");
                entity.HasKey(a => a.Id);
                entity.Property(x => x.ArticleParagraph);
                entity.Property(x => x.ArticleTitle);
                entity.Property(x => x.Image);
                entity.Property(x => x.UpdatedAt);
                entity.Property(x => x.CreatedAt);
                entity.HasOne(x => x.BlogPost).WithMany(x => x.Articles).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.ToTable("blog_posts");
                entity.HasKey(a => a.Id);
                entity.Property(x => x.BlogPostTitle);
                entity.Property(x => x.BlogPostImage);
                entity.Property(x => x.UpdatedAt);
                entity.Property(x => x.CreatedAt);
            });
        }
}
