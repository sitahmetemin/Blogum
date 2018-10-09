using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Domain.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blogum.DataAccess
{
    public class BlogumContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BlogumDB;Trusted_Connection=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagArticle> TagArticles { get; set; }
    }
}
