
using GamesBlog.Domain.Entitties;

namespace GamesBlog.Domain.Repositories.Contracts
{
    public interface ArticleRepository
    {
        Task CreateArticle(Article article);
    }
}
