using CirqulyProject.Core.Features.Articles.Models;

namespace CirqulyProject.Core.Services
{
    public class ArticleService : IArticleService
    {
        private readonly List<Article> _articles = new()
            {
                 new Article
    {
        Id = 1,
        Title = "Vintage Leather Jacket",
        Price = 95m,
        Description = "Preloved genuine leather jacket in excellent condition. Size M.",
        CreatedDate = DateTime.Now.AddDays(-12)
    },
    new Article
    {
        Id = 2,
        Title = "Nike Air Max Sneakers",
        Price = 60m,
        Description = "Lightly used Nike Air Max sneakers. Size 42 EU.",
        CreatedDate = DateTime.Now.AddDays(-8)
    },
    new Article
    {
        Id = 3,
        Title = "Designer Handbag",
        Price = 120m,
        Description = "Second-hand designer handbag with minimal wear. Includes dust bag.",
        CreatedDate = DateTime.Now.AddDays(-15)
    },
    new Article
    {
        Id = 4,
        Title = "Kids Winter Coat",
        Price = 35m,
        Description = "Warm winter coat for kids, size 8-10 years, gently used.",
        CreatedDate = DateTime.Now.AddDays(-3)
    },
    new Article
    {
        Id = 5,
        Title = "Vintage Table Lamp",
        Price = 45m,
        Description = "Retro-style table lamp in perfect working condition.",
        CreatedDate = DateTime.Now.AddDays(-20)
    },
    new Article
    {
        Id = 6,
        Title = "Classic Denim Jeans",
        Price = 30m,
        Description = "Preloved denim jeans, slim fit, size L.",
        CreatedDate = DateTime.Now.AddDays(-6)
    },
    new Article
    {
        Id = 7,
        Title = "Mountain Bike Helmet",
        Price = 25m,
        Description = "Used mountain bike helmet with adjustable strap.",
        CreatedDate = DateTime.Now.AddDays(-10)
    },
    new Article
    {
        Id = 8,
        Title = "Hardcover Novel Collection",
        Price = 40m,
        Description = "Bundle of 5 bestselling hardcover novels in good condition.",
        CreatedDate = DateTime.Now.AddDays(-18)
    },
    new Article
    {
        Id = 9,
        Title = "Silver Necklace",
        Price = 55m,
        Description = "Preloved sterling silver necklace with minimalist design.",
        CreatedDate = DateTime.Now.AddDays(-4)
    },
    new Article
    {
        Id = 10,
        Title = "Home Decor Wall Mirror",
        Price = 70m,
        Description = "Modern decorative wall mirror, lightly used.",
        CreatedDate = DateTime.Now.AddDays(-9)
    }
            };
        
        public async Task<List<Article>> GetAllAsync()
        {
            return await Task.FromResult(_articles);
        }

        public async Task<Article> GetByIdAsync(int id)
        {
        #pragma warning disable CS8603 // Possible null reference return.
            return await Task.FromResult(_articles.FirstOrDefault(fo => fo.Id == id)??default);
        #pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
