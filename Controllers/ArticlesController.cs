using Microsoft.AspNetCore.Mvc;
using CirqulyProject.Core.Features.Articles.Extensions;
using CirqulyProject.Core.Services;

namespace CirqulyProject.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IArticleService _articleService;
        public ArticlesController(IArticleService service)
        {
            _articleService = service;
        }

        /// <summary>
        /// Handles HTTP GET requests for the main articles page and displays a list of all articles.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains an <see cref="ViewResult"/> that
        /// renders the articles list view.</returns>
        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAllAsync();
            return View(articles.ToViewModels());
        }

        /// <summary>
        /// Displays the details of the specified article.
        /// </summary>
        /// <param name="id">The unique identifier of the article to display.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains an <see cref="IActionResult"/>
        /// that renders the article details view if the article is found; otherwise, a NotFound result.</returns>
        public async Task<IActionResult> Details(int id)
        {
            var article = await _articleService.GetByIdAsync(id);
            if (article == null)
            {
                return View("NotFound");
            }
            return View(article.ToViewModel());
        }
    }
}
