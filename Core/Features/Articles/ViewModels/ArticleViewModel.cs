namespace CirqulyProject.Core.Features.Articles.ViewModels
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public decimal Price { get; set; }
        public required string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
