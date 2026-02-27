using CirqulyProject.Core.Features.Articles.Models;

namespace CirqulyProject.Core.Services
{
    public interface IArticleService
    {
        public Task<List<Article>> GetAllAsync();
        public Task<Article?> GetByIdAsync(int id);
    }
}
