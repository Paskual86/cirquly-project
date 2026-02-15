using CirqulyProject.Core.Features.Articles.Models;
using CirqulyProject.Core.Features.Articles.ViewModels;

namespace CirqulyProject.Core.Features.Articles.Extensions
{
    public static class ArticleMappers
    {
        public static List<ArticleViewModel> ToViewModels(this List<Article> articles)
        {
            return articles.Select(a => a.ToViewModel()).ToList();
        }

        public static ArticleViewModel ToViewModel(this Article article)
        {
            return new ArticleViewModel
            {
                Id = article.Id,
                Title = article.Title,
                Price = article.Price,
                Description = article.Description,
                CreatedDate = article.CreatedDate
            };
        }
    }
}
