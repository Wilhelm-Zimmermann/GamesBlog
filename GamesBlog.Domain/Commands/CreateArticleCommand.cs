using GamesBlog.Domain.Entities;
using GamesBlog.Domain.Commands.Contracts;

namespace GamesBlog.Domain.Commands
{
    public class CreateArticleCommand : ICommand
    {
        public Title ArticleTitle { get; private set; }
        public Paragraph ArticleParagraph { get; private set; }
        public string? Image { get; private set; }
        public Guid BlogPostId { get; private set; }
        public bool IsValid { get; private set; }

        public CreateArticleCommand(Title articleTitle, Paragraph articleParagraph, string? image, Guid blogPostId)
        {
            ArticleTitle = articleTitle;
            ArticleParagraph = articleParagraph;
            Image = image;
            BlogPostId = blogPostId;
        }

    }
}
