namespace GamesBlog.Domain.Entities
{
    public class Article : Base
    {
        public Title ArticleTitle { get; private set; }
        public Paragraph ArticleParagraph { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public string? Image { get; private set; }
        public bool IsValid { get; private set; }

        public Guid BlogPostId { get; private set; }
        public BlogPost BlogPost { get; private set; }

        public Article(Title articleTitle, Paragraph articleParagraph, string? image, DateTime createdAt, Guid blogPostId)
        {
            ArticleTitle = articleTitle;
            ArticleParagraph = articleParagraph;
            Image = image;
            CreatedAt = createdAt;
            BlogPostId = blogPostId;
        }

        public void Validate()
        {
            ArticleTitle.Validate();
            ArticleParagraph.Validate();
            if (ArticleTitle.IsValid && ArticleParagraph.IsValid)
            {
                IsValid = true;
            }
            else
            {
                IsValid= false;
            }
        }

        public void SetUpdateDate(DateTime updateDate)
        {
            UpdatedAt = updateDate;
        }
    }
}
