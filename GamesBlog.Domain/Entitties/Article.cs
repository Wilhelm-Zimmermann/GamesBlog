namespace GamesBlog.Domain.Entitties
{
    public class Article : Base
    {
        public Title ArticleTitle { get; private set; }
        public Paragraph ArticleParagraph { get; private set; }
        public string? Image { get; private set; }
        public bool IsValid { get; private set; }

        public Article(Title articleTitle, Paragraph articleParagraph, string? image)
        {
            ArticleTitle = articleTitle;
            ArticleParagraph = articleParagraph;
            Image = image;
        }

        public void Validate()
        {
            if (ArticleTitle.IsValid && ArticleParagraph.IsValid)
            {
                IsValid = true;
            }
            else
            {
                IsValid= false;
            }
        }
    }
}
