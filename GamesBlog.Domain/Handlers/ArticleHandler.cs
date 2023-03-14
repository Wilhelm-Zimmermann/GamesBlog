using GamesBlog.Domain.Commands;
using GamesBlog.Domain.Commands.Contracts;
using GamesBlog.Domain.Entities;
using GamesBlog.Domain.Handlers.Contracts;

namespace GamesBlog.Domain.Handlers
{
    public class ArticleHandler : IHandler<CreateArticleCommand>
    {
        public async Task<ICommandResult> Handle(CreateArticleCommand command)
        {
            var article = new Article(command.ArticleTitle, command.ArticleParagraph, command.Image, DateTime.Now, command.BlogPostId);

            article.ArticleParagraph.Validate();
            article.ArticleTitle.Validate();
            article.Validate();

            if (!article.IsValid) return new GenericCommandResult(false, "could not create article", null);

            return new GenericCommandResult(true, "Article created successfully", article);
        }
    }
}
