
using GamesBlog.Domain.Entities;

namespace GamesBlog.Domain.Repositories.Contracts
{
    public interface IArticlesRepository
    {
        Task CreateArticle(Article article);
    }
}
