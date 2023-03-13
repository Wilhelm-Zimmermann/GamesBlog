namespace GamesBlog.Domain.Entities
{
    public class BlogPost : Base
    {
        public IList<Article> Articles { get; private set; }
        public Title BlogPostTitle { get; private set; }
        public string BlogPostImage { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public BlogPost(Title blogPostTitle, string blogPostImage, DateTime createdAt)
        {
            BlogPostTitle = blogPostTitle;
            BlogPostImage = blogPostImage;
            CreatedAt = createdAt;
        }

        public void AddArticle(Article article)
        {
            Articles.Add(article);
        }
        
        public void RemoveArticle(Article article)
        {
            Articles.Remove(article);
        }

        public void SetUpdateDate(DateTime updateDate)
        {
            UpdatedAt = updateDate;
        }
    }
}
