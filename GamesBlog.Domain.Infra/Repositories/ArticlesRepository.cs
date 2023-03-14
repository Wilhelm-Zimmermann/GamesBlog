using GamesBlog.Domain.Entities;
using GamesBlog.Domain.Infra.Context;
using GamesBlog.Domain.Repositories.Contracts;

namespace GamesBlog.Domain.Infra.Repositories
{
    public class ArticlesRepository : IArticlesRepository
    {
        private DatabaseContext _ctx;

        public ArticlesRepository(DatabaseContext ctx)
        {
            _ctx = ctx;
        }

        public async Task CreateArticle(Article article)
        {
            _ctx.Articles.Add(article);
            await _ctx.SaveChangesAsync();
        }
    }
}
